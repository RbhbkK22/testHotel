using MySqlConnector;
using System;
using System.Windows.Forms;

namespace testHotel.AddEntryForm
{
    public partial class AddClientForm : Form
    {
        Main main = new Main();
        DataGridView dataGridView;
        Tools tools = new Tools();

        public AddClientForm(DataGridView n)
        {
            dataGridView = n;
            InitializeComponent();
            tools.FillingComboBox(RoomNumComboBox, "rooms", 1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                main.dataBase.cn.Close();
                main.dataBase.cn.Open();
                main.command = new MySqlCommand("INSERT INTO clients(id, RoomNum, RoomId, Name, SurName, PhoneNum, CheckIn, CheckOut, Total)" +
                    " VALUES(NULL, '" + RoomNumComboBox.Text + "', (SELECT id FROM rooms WHERE NumRoom = " + RoomNumComboBox.Text + ")," +
                    "'" + NameText.Text + "','" + SurNameText.Text + "'," +
                    "'" + PhoneText.Text + "','" + CheckInText.Text + "','" + CheckOutText.Text + "', 'NULL')", main.dataBase.cn);
                main.command.ExecuteNonQuery();
                main.dataBase.cn.Close();
                MessageBox.Show("Данные успешно добавлены. Обновите таблицу");
                main.dataBase.DbLoad(dataGridView, "clients");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {
            RoomNumComboBox.AddPlaceHolderForComboBoc("Номер комнаты");
            NameText.AddPlaceHolderForTextBox("Имя");
            SurNameText.AddPlaceHolderForTextBox("Фамилия");
            PhoneText.AddPlaceHolderForTextBox("Телефонный номер");
            CheckInText.AddPlaceHolderForTextBox("Заселение");
            CheckOutText.AddPlaceHolderForTextBox("Выезд");

        }
    }
}
