using MySqlConnector;
using System;
using System.Windows.Forms;

namespace testHotel.AddEntryForm
{
    public partial class AddClientForm : Form
    {
        Main main = new Main();
        DataGridView dataGridView;

        public AddClientForm(DataGridView n)
        {
            dataGridView = n;
            InitializeComponent();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            { 
                main.dataBase.cn.Close();
                main.dataBase.cn.Open();
                main.command = new MySqlCommand("INSERT INTO clients(RoomNum, Name, SurName, PhoneNum, CheckIn, CheckOut) VALUES('"+RoomNumText.Text+"','"+NameText.Text+ "','"+SurNameText.Text+"'," +
                    "'"+PhoneText.Text+"','"+CheckInText.Text+"','"+CheckOutText.Text+"')", main.dataBase.cn);
                main.command.ExecuteNonQuery();
                main.dataBase.cn.Close();
                MessageBox.Show("Данные успешно добавлены. Обновите таблицу");
                main.dataBase.DbLoad(dataGridView, "clients");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
