﻿using MySqlConnector;
using System;
using System.Windows.Forms;

namespace testHotel.AddEntryForm
{
    public partial class AddCategoriesForm : Form
    {
        Main main = new Main();
        DataGridView dataGridView;
        public AddCategoriesForm(DataGridView dataGridView)
        {
            InitializeComponent();
            NameBox.AddPlaceHolderForTextBox("Название");
            this.dataGridView = dataGridView;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                main.dataBase.cn.Close();
                main.dataBase.cn.Open();
                main.command = new MySqlCommand("INSERT INTO categories(CategName) VALUES ('" + NameBox.Text + "')", main.dataBase.cn);
                main.command.ExecuteNonQuery();
                main.dataBase.cn.Close();
                MessageBox.Show("Данные успешно добавлены.");
                main.dataBase.DbLoad(dataGridView, "categories");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }
    }
}
