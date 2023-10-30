using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace testHotel
{
    public class Total : StateRoomManeger
    {
        public Total(DataGridView dataGridView) : base(dataGridView)
        {
        }

        private int TotalRoom(int id)
        {
            int priceOfDay = 0;
            main.dataBase.cn.Close();
            main.dataBase.cn.Open();
            main.command = new MySqlCommand($"SELECT * FROM rooms WHERE id = {id}", main.dataBase.cn);
            MySqlDataReader reader = main.command.ExecuteReader();
            while (reader.Read())
            {
                priceOfDay = reader.GetInt32(6);
            }

            main.dataBase.cn.Close();
            return priceOfDay;
        }

        public void CountTotal()
        {
            List<int> ids = FillArrIdRoomClients();
            foreach (int id in ids)
            {
                int priceOfDay = TotalRoom(id);
                main.dataBase.cn.Close();
                main.dataBase.cn.Open();
                main.command = new MySqlCommand($"SELECT * FROM clients WHERE roomId = {id}", main.dataBase.cn);
                MySqlDataReader reader2 = main.command.ExecuteReader();
                while (reader2.Read())
                {
                    DateTime checkIn = reader2.GetDateTime(6);
                    DateTime checkOut = reader2.GetDateTime(7);
                    int days = (int)(checkOut - checkIn).TotalDays;
                    main.command = new MySqlCommand($"UPDATE clients SET Total = {days * priceOfDay} WHERE roomId = {id}", main.dataBase.cn);
                }
                main.dataBase.cn.Close();
                main.dataBase.cn.Open();
                main.command.ExecuteNonQuery();
                main.dataBase.cn.Close();
                main.dataBase.DbLoad(dataGridView, "clients");
            }
        }
    }
}
