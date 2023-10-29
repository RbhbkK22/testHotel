using MySqlConnector;
using System;
using System.Windows.Forms;

namespace testHotel.AddEntryForm
{
    public partial class AddRoomForm : Form
    {
        Main main = new Main();
        DataGridView dataGridView;
        Tools tool = new Tools();
        public AddRoomForm(DataGridView d)
        {
            InitializeComponent();
            dataGridView = d;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                main.dataBase.cn.Close();
                main.dataBase.cn.Open();
                main.command = new MySqlCommand("INSERT INTO rooms (NumRoom, EmployeeID, State, Category, categId, PriceOfDay) VALUES " +
                    "(" +RoomNumBox.Text+ "," +EmpComboBox.Text+ ", 'свободно', '" +CategComboBox.Text+ "'," +
                    "(SELECT id FROM categories WHERE CategName = '" + CategComboBox.Text + "'),"+PriceDayBox.Text+")", main.dataBase.cn);
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

        private void AddRoomForm_Load(object sender, EventArgs e)
        {
            tool.FillingComboBox(EmpComboBox, "employees", 0);
            tool.FillingComboBox(CategComboBox, "categories", 1);
            RoomNumBox.AddPlaceHolderForTextBox("Номер");
            EmpComboBox.AddPlaceHolderForComboBoc("Id работника");
            CategComboBox.AddPlaceHolderForComboBoc("Категория");
            PriceDayBox.AddPlaceHolderForTextBox("Стоимость сутки");
        }
    }
}
