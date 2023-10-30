using MySqlConnector;
using System;
using System.Windows.Forms;

namespace testHotel.AddEntryForm
{
    public partial class ChangeRoomForm : Form
    {
        Main main = new Main();
        DataGridView dataGridView;
        Tools tool = new Tools();
        int id;

        public ChangeRoomForm(int id, DataGridView d)
        {
            InitializeComponent();
            this.dataGridView = d;
            this.id = id;
            tool.FillingComboBox(EmpComboBox, "employees", 0);
            tool.FillingComboBox(CategComboBox, "categories", 1);
            PrintTextBox();
        }

        private void PrintTextBox()
        {
            RoomNumBox.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            EmpComboBox.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            CategComboBox.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            PriceDayBox.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                main.dataBase.cn.Close();
                main.dataBase.cn.Open();
                main.command = new MySqlCommand("UPDATE rooms SET NumRoom = " + RoomNumBox.Text + ", EmployeeID = " + EmpComboBox.Text + ", " +
                    "Category = '" + CategComboBox.Text + "', categId = (SELECT id FROM categories WHERE CategName = '" + CategComboBox.Text + "'), " +
                    "PriceOfDay = " + PriceDayBox.Text + " WHERE id = " + id + "", main.dataBase.cn);
                main.command.ExecuteNonQuery();
                main.dataBase.cn.Close();
                MessageBox.Show("Данные успешно добавлены. Обновите таблицу");
                main.dataBase.DbLoad(dataGridView, "rooms");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }


    }
}
