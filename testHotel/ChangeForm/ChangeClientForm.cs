using MySqlConnector;
using System;
using System.Windows.Forms;


namespace testHotel.ChangeForm
{
    public partial class ChangeClientForm : Form
    {
        Main main = new Main();
        DataGridView dataGridView;
        private int id;

        public ChangeClientForm()
        {
            InitializeComponent();
        }

        public ChangeClientForm(int _id, DataGridView d)
        {
            id = _id;
            dataGridView = d;
            InitializeComponent();
            PrintTextBox();
            
        }

        private void PrintTextBox()
        {
            RoomNumTextBox.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            NameText.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            SurNameText.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            PhoneText.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            CheckInText.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            CheckOutText.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                main.dataBase.cn.Close();
                main.dataBase.cn.Open();
                main.command = new MySqlCommand("UPDATE clients SET RoomNum = '"+RoomNumTextBox.Text+"', Name = '"+NameText.Text+"'," +
                    " SurName = '"+SurNameText.Text+"', PhoneNum = '"+PhoneText.Text+"', CheckIn = '"+CheckInText.Text+"'," +
                    " CheckOut = '"+CheckOutText.Text+"' WHERE id = "+id+"", main.dataBase.cn);
                main.command.ExecuteNonQuery();
                main.dataBase.cn.Close();
                main.dataBase.DbLoad(dataGridView, "clients");
                MessageBox.Show("Data successfully updated");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
