using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace testHotel
{
    public class DataBase
    {
        public MySqlConnection cn;
        MySqlCommand command;
        MySqlDataAdapter dataApter;
        DataTable dataTable;
        public void Connect()
        {
            cn = new MySqlConnection("server=localhost; port=3306; username=root; password=; database=hotel");

        }

        public void DbLoad(DataGridView dataGridView, string tabName)
        {
            try
            {
                cn.Close();
                cn.Open();
                command = new MySqlCommand($"SELECT * FROM {tabName}", cn);
                command.ExecuteNonQuery();
                dataTable = new DataTable();
                dataApter = new MySqlDataAdapter(command);
                dataApter.Fill(dataTable);
                dataGridView.DataSource = dataTable.DefaultView;
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
