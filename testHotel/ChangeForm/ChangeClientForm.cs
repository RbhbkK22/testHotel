using MySqlConnector;
using System;
using System.Windows.Forms;


namespace testHotel.ChangeForm
{
    public partial class ChangeClientForm : Form
    {
        Main main = new Main();
        DataGridView dataGridView;
        Tools tools = new Tools();
        private int id;

        public ChangeClientForm(int _id, DataGridView d)
        {
            id = _id;
            dataGridView = d;
            InitializeComponent();
            tools.FillingComboBox(RoomNumComboBox, "rooms", 1);
            PrintTextBox();

        }

        private void PrintTextBox()
        {
            RoomNumComboBox.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            NameText.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            SurNameText.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            PhoneText.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            CheckInText.Text = Convert.ToDateTime(dataGridView.CurrentRow.Cells[6].Value).ToString("yyyy-MM-dd");
            CheckOutText.Text = Convert.ToDateTime(dataGridView.CurrentRow.Cells[7].Value).ToString("yyyy-MM-dd");
            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                main.dataBase.cn.Close();
                main.dataBase.cn.Open();
                main.command = new MySqlCommand("UPDATE clients SET RoomNum = '" + RoomNumComboBox.Text + "', Name = '" + NameText.Text + "'," +
                    " SurName = '" + SurNameText.Text + "', PhoneNum = '" + PhoneText.Text + "', CheckIn = '" + CheckInText.Text + "'," +
                    " CheckOut = '" + CheckOutText.Text + "' WHERE id = " + id + "", main.dataBase.cn);
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