using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testHotel.ChangeForm
{
    public partial class ChangeCategoriesForm : Form
    {
        DataBase _dataBase = new DataBase();
        MySqlCommand _command;
        int id;
        DataGridView dataGridView;

        public ChangeCategoriesForm(int id, DataGridView dataGridView)
        {
            this.id = id;
            this.dataGridView = dataGridView;
            InitializeComponent();
            PrintTextBox();
            _dataBase.Connect();

        }

        private void PrintTextBox()
        {
            NameBox.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _dataBase.cn.Close();
                _dataBase.cn.Open();
                _command = new MySqlCommand("UPDATE categories SET CategName = '"+NameBox.Text+"' WHERE id = "+id+"", _dataBase.cn);
                _command.ExecuteNonQuery();
                _dataBase.cn.Close();
                _dataBase.DbLoad(dataGridView, "categories");
                MessageBox.Show("Данные изменены.");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
