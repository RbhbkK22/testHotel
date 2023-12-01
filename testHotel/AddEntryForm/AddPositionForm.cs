using MySqlConnector;
using System;
using System.Windows.Forms;

namespace testHotel.AddEntryForm
{
    public partial class AddPositionForm : Form
    {
        Main main = new Main();
        DataGridView dataGridView;

        public AddPositionForm(DataGridView dataGridView)
        {
            InitializeComponent();
            NameText.AddPlaceHolderForTextBox("Наазвание");
            Salary.AddPlaceHolderForTextBox("Зарплата");
            this.dataGridView = dataGridView;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                main.dataBase.cn.Close();
                main.dataBase.cn.Open();
                main.command = new MySqlCommand("INSERT INTO positions (PositName, Salary) VALUES ('" + NameText.Text + "'," + Convert.ToInt32(Salary.Text) + ")", main.dataBase.cn);
                main.command.ExecuteNonQuery();
                main.dataBase.cn.Close();
                MessageBox.Show("Данные успешно добавлены.");
                main.dataBase.DbLoad(dataGridView, "positions");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }
    }
}
