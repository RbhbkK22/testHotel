﻿using MySqlConnector;
using System;
using System.Windows.Forms;

namespace testHotel.AddEntryForm
{
    public partial class AddEmployeesForm : Form
    {
        Main main = new Main();
        DataGridView dataGridView = new DataGridView();
        Tools tools = new Tools();

        public AddEmployeesForm()
        {
            InitializeComponent();
        }

        public AddEmployeesForm(DataGridView d)
        {
            dataGridView = d;
            InitializeComponent();
            tools.FillingComboBox(PositionComboBox, "positions");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                main.dataBase.cn.Close();
                main.dataBase.cn.Open();
                main.command = new MySqlCommand("INSERT INTO employees (Name, SurName, PhoneNum, Position, positId) VALUES ('" + NameBox.Text + "','" + SurNameBox.Text + "','" + PhoneNumBox.Text + "'," +
                    "'" + PositionComboBox.Text + "', (SELECT id FROM positions WHERE PositName = '"+PositionComboBox.Text+"'))", main.dataBase.cn);
                main.command.ExecuteNonQuery();
                main.dataBase.cn.Close();
                MessageBox.Show("Данные успешно добавлены. Обновите таблицу");
                main.dataBase.DbLoad(dataGridView, "employees");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }
    }
}
