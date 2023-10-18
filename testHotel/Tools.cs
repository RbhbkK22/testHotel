using MySqlConnector;
using System;
using System.CodeDom;
using System.Windows.Forms;


namespace testHotel
{
    public class Tools
    {
        Main main = new Main();

        DataGridView dataGridView;

        public Tools() { }

        public Tools(DataGridView d)
        {
            dataGridView = d;
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
            main.dataBase.cn.Close();
            main.dataBase.cn.Open();
            main.command = new MySqlConnector.MySqlCommand("SELECT * FROM "+tabName+"", main.dataBase.cn);
            MySqlDataReader reader = main.command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string s = Convert.ToString(reader.GetValue(colum)); ;
                    comboBox.Items.Add(s);
                }
            }
            main.dataBase.cn.Close();
        }

        public void DeleteLast(ComboBox comboBox)
        {
            string TableName = GetComboboxName(comboBox);

            try
            {
                main.dataBase.cn.Close();
                main.dataBase.cn.Open();
                main.command = new MySqlCommand(($"DELETE FROM {TableName} ORDER BY id DESC limit 1"), main.dataBase.cn);
                main.command.ExecuteNonQuery();
                main.dataBase.cn.Close();
                main.dataBase.DbLoad(dataGridView, TableName);
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
                main.dataBase.cn.Close();
                main.dataBase.cn.Open();
                main.command = new MySqlCommand(($"DELETE FROM {TableName} WHERE id = '" + id + "'"), main.dataBase.cn);
                main.command.ExecuteNonQuery();
                main.dataBase.cn.Close();
                main.dataBase.DbLoad(dataGridView, TableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
