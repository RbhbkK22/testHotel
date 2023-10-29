using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using testHotel.AddEntryForm;
using testHotel.ChangeForm;

namespace testHotel
{
    public partial class Main : Form
    {
        public DataBase dataBase = new DataBase();
        public MySqlCommand command;
        public MySqlDataAdapter dataApter;
        public DataTable dataTable;

        public int index;
        public string tmp = "";
        
        public Main()
        {
            InitializeComponent();
            dataBase.Connect(dataGridView1);
            comboBox1.SelectedIndex = 0;
            IdTextBox.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dataBase.DbLoad(dataGridView1, "clients");
                    break;
                case 1:/*
                    dataBase.DbLoad(dataGridView1, "rooms");*/
                    StateRoomManeger stateRoomManeger = new StateRoomManeger(dataGridView1);
                    stateRoomManeger.ChangeStateRoom();
                    break;
                case 2:/*
                    dataBase.DbLoad(dataGridView1, "categories");*/
                    Tools tool = new Tools(dataGridView1);
                    tool.CountRoomOfCategories();
                    break;
                case 3:
                    dataBase.DbLoad(dataGridView1, "employees");
                    break;
                case 4:
                    dataBase.DbLoad(dataGridView1, "positions");
                    break;
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IdTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            index = dataGridView1.CurrentRow.Index;
        }

        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Клиенты":
                    AddClientForm addClientForm = new AddClientForm(dataGridView1);
                    addClientForm.Show();
                    break;
                case "Комнаты":
                    AddRoomForm addRoomForm = new AddRoomForm(dataGridView1);
                    addRoomForm.Show();
                    break;
                case "Работники":
                    AddEmployeesForm addEmployeesForm = new AddEmployeesForm(dataGridView1);
                    addEmployeesForm.Show();
                    break;
                case "Должности":
                    dataBase.DbLoad(dataGridView1, "positions");
                    break;
                case "Категории номеров":
                    dataBase.DbLoad(dataGridView1, "categories");
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Tools tools = new Tools(dataGridView1);
            tools.BtnDelete(comboBox1, IdTextBox.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            

            
        }
        private void btnReLoad_Click(object sender, EventArgs e)
        {/*
            StateRoomManeger srm = new StateRoomManeger();
            srm.ChangeStateRoom();
            dataBase.DbLoad(dataGridView1, "rooms");*/
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Клиенты":
                    ChangeClientForm changeClient = new ChangeClientForm(Convert.ToInt32(IdTextBox.Text), dataGridView1);
                    changeClient.Show();
                    break;
                case "Комнаты":
                    ChangeRoomForm changeRoomForm = new ChangeRoomForm(Convert.ToInt32(IdTextBox.Text), dataGridView1);
                    changeRoomForm.Show();
                    break;
                case "Работники":
                    ChangeEmployForm changeEmploy = new ChangeEmployForm(Convert.ToInt32(IdTextBox.Text), dataGridView1);
                    changeEmploy.Show();
                    break;
                case "Должности":
                    dataBase.DbLoad(dataGridView1, "positions");
                    break;
                case "Категории номеров":
                    dataBase.DbLoad(dataGridView1, "categories");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Total ta = new Total(dataGridView1);
            ta.CountTotal();

        }
    }
}
