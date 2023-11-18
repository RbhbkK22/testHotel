using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace testHotel
{
    public class Tools
    {
        public DataBase dataBase = new DataBase();
        public MySqlCommand command;
        public MySqlDataAdapter dataApter;
        public DataTable dataTable;


        DataGridView dataGridView;

        public Tools() { dataBase.Connect(); }

        public Tools(DataGridView d)
        {
            dataGridView = d;
            dataBase.Connect();
        }

        private string GetComboboxName(ComboBox comboBox)
        {
            switch (comboBox.Text)
            {
                case "Клиенты":
                    return "clients";

                case "Комнаты":
                    return "rooms";

                case "Работники":
                    return "employees";

                case "Должности":
                    return "positions";

                case "Категории номеров":
                    return "categories";

            }
            return null;
        }

        public void FillingComboBox(ComboBox comboBox, string tabName, int colum)
        {
            dataBase.cn.Close();
            dataBase.cn.Open();
            command = new MySqlConnector.MySqlCommand("SELECT * FROM " + tabName + "", dataBase.cn);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string s = Convert.ToString(reader.GetValue(colum)); ;
                    comboBox.Items.Add(s);
                }
            }
            dataBase.cn.Close();
        }

        public void DeleteLast(ComboBox comboBox)
        {
            string TableName = GetComboboxName(comboBox);

            try
            {
                dataBase.cn.Close();
                dataBase.cn.Open();
                command = new MySqlCommand(($"DELETE FROM {TableName} ORDER BY id DESC limit 1"), dataBase.cn);
                command.ExecuteNonQuery();
                dataBase.cn.Close();
                dataBase.DbLoad(dataGridView, TableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BtnDelete(ComboBox comboBox, string id)
        {
            string TableName = GetComboboxName(comboBox);

            try
            {
                dataBase.cn.Close();
                dataBase.cn.Open();
                command = new MySqlCommand(($"DELETE FROM {TableName} WHERE id = '" + id + "'"), dataBase.cn);
                command.ExecuteNonQuery();
                dataBase.cn.Close();
                dataBase.DbLoad(dataGridView, TableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string GetStringDate()
        {
            string[] subsDt = DateTime.Now.ToShortDateString().Split('/');
            string res = subsDt[2] + "-" + subsDt[0] + "-" + subsDt[1];
            return res;
        }

        public void CountRoomOfCategories()
        {
            dataBase.cn.Close();
            dataBase.cn.Open();
            command = new MySqlCommand($"SELECT CategName FROM categories", dataBase.cn);
            List<string> list = new List<string>();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string s = reader.GetString(0);
                    list.Add(s);
                }
            }
            foreach (var i in list)
            {
                int n = 0;
                dataBase.cn.Close();
                dataBase.cn.Open();
                command = new MySqlCommand($"SELECT * FROM rooms WHERE Category = '{i}'", dataBase.cn);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        n += 1;
                    }
                }
                dataBase.cn.Close();
                dataBase.cn.Open();
                command = new MySqlCommand($"UPDATE categories SET NumOfRoom = {n} WHERE CategName = '{i}'", dataBase.cn);
                command.ExecuteNonQuery();
                dataBase.cn.Close();
            }
        }

        public void CountPositions()
        {
            dataBase.cn.Close();
            dataBase.cn.Open();
            command = new MySqlCommand($"SELECT PositName FROM positions", dataBase.cn);
            List<string> list = new List<string>();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string s = reader.GetString(0);
                    list.Add(s);
                }
            }
            foreach (var i in list)
            {
                int n = 0;
                dataBase.cn.Close();
                dataBase.cn.Open();
                command = new MySqlCommand($"SELECT * FROM employees WHERE Position = '{i}'", dataBase.cn);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        n += 1;
                    }
                }
                dataBase.cn.Close();
                dataBase.cn.Open();
                command = new MySqlCommand($"UPDATE positions SET NumOfEmploy = {n} WHERE PositName = '{i}'", dataBase.cn);
                command.ExecuteNonQuery();
                dataBase.cn.Close();
            }
        }
    }
}
