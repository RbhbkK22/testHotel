using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testHotel.AddEntryForm;

namespace testHotel.ChangeForm
{
    public partial class ChangePositionForm : Form
    {
        DataBase _dataBase = new DataBase();
        MySqlCommand _command;
        int id;
        DataGridView dataGridView;

        public ChangePositionForm(int id, DataGridView dataGridView)
        {
            InitializeComponent();
            this.dataGridView = dataGridView;
            this.id = id;
            PrintTextBox();
            _dataBase.Connect();
        }

        private void PrintTextBox()
        {
            NameText.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            Salary.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
        }

        private void ChangePositionOfStaff()
        {
            /*обновление названий должности у работников.*/
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _dataBase.cn.Close();
                _dataBase.cn.Open();
                _command = new MySqlCommand("UPDATE positions SET PositName = '" + NameText.Text + "', Salary = " + Salary.Text + "  WHERE id = " + id + "", _dataBase.cn);
                _command.ExecuteNonQuery();
                _dataBase.cn.Close();
                ChangePositionOfStaff();
                _dataBase.DbLoad(dataGridView, "positions");
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
