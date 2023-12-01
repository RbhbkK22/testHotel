using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace testHotel
{
    public class Total 
    {
        Main main = new Main();
        DataGridView dataGridView;
        public Total(DataGridView dataGridView) 
        {
            this.dataGridView = dataGridView;
        }
       private List<int> IdsClient()
        {
            List<int> ids = new List<int>();
            main.dataBase.cn.Close();
            main.dataBase.cn.Open();
            main.command = new MySqlCommand("SELECT * FROM clients", main.dataBase.cn);
            MySqlDataReader reader = main.command.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader.GetInt32(0);
                ids.Add(id);
            }
            main.dataBase.cn.Close();
            return ids;
        }

        private int Price(int id)
        {
            int price = 0;
            main.dataBase.cn.Close();
            main.dataBase.cn.Open();
            main.command = new MySqlCommand("SELECT PriceOfDay FROM rooms WHERE id = (SELECT RoomId FROM clients WHERE id = "+id+")", main.dataBase.cn);
            MySqlDataReader reader = main.command.ExecuteReader();
            while (reader.Read())
            {
                price = (int)reader.GetInt32(0);
            }
            return price;
        }

        public void CountTotal()
        {
            List<int> ids = IdsClient();
            foreach (int id in ids)
            {
                int price = Price(id);
                main.dataBase.cn.Close();
                main.dataBase.cn.Open();
                main.command = new MySqlCommand($"SELECT * FROM clients WHERE id = @clientId", main.dataBase.cn);
                main.command.Parameters.AddWithValue("@clientId", id);
                MySqlDataReader reader2 = main.command.ExecuteReader();
                if(reader2.Read())
                {
                    DateTime checkIn = reader2.GetDateTime(6);
                    DateTime checkOut = reader2.GetDateTime(7);
                    int days = (int)(checkOut - checkIn).TotalDays;
                    int total = days * price;
                    main.command = new MySqlCommand($"UPDATE clients SET Total = @total WHERE id = @clientId", main.dataBase.cn);
                    main.command.Parameters.AddWithValue("@total", total);
                    main.command.Parameters.AddWithValue("@clientId", id);
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
