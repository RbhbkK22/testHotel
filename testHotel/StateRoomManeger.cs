using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySqlConnector;


namespace testHotel
{
    public class StateRoomManeger
    {
        protected Main main = new Main();
        protected DataGridView dataGridView;
        public StateRoomManeger(DataGridView dataGridView)
        {
           this.dataGridView = dataGridView;
        }
        
        private string GetDate()
        {
            string[] subsDt = DateTime.Now.ToShortDateString().Split('/');
            string res = subsDt[2] + "-" + subsDt[0] + "-" + subsDt[1];
            return res;
        }

        protected List<int> FillArrIdRoomClients()
        {
            List<int> ids = new List<int>();
            main.dataBase.cn.Close();
            main.dataBase.cn.Open();
            main.command = new MySqlCommand("SELECT * FROM clients", main.dataBase.cn);
            MySqlDataReader reader = main.command.ExecuteReader();
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    int id = Convert.ToInt32(reader.GetValue(2));
                    ids.Add(id);
                }
            }
            main.dataBase.cn.Close();
            return ids;
            
        }

        public void ChangeStateRoom()
        {
            string date = GetDate();
            List<int> ids = FillArrIdRoomClients();
            foreach (int id in ids)
            {
                main.dataBase.cn.Close();
                main.dataBase.cn.Open();
                main.command = new MySqlCommand($"SELECT * FROM clients WHERE roomId = {id}", main.dataBase.cn);
                MySqlDataReader reader = main.command.ExecuteReader();
                while (reader.Read())
                {
                    string checkIn = reader.GetDateTime(6).ToString("yyyy-MM-dd");
                    string checkOut = reader.GetDateTime(7).ToString("yyyy-MM-dd");
                    if(date == checkIn)
                    {
                        main.command = new MySqlCommand($"UPDATE rooms SET state = 'занято' WHERE id = {id}", main.dataBase.cn);
                        continue;
                    }

                    if(date == checkOut)
                    {
                        main.command = new MySqlCommand($"UPDATE rooms SET state = 'свободно' WHERE id = {id}", main.dataBase.cn);
                        continue;
                    }
                    
                }
                main.dataBase.cn.Close();
                main.dataBase.cn.Open();
                main.command.ExecuteNonQuery();
                main.dataBase.cn.Close();
            }
            main.dataBase.DbLoad(dataGridView, "rooms");
        }
    }
}