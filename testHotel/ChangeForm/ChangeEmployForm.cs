using MySqlConnector;
using System;
using System.Windows.Forms;

namespace testHotel.ChangeForm
{
    public partial class ChangeEmployForm : Form
    {
        Main main = new Main();
        DataGridView dataGridView;
        Tools tools = new Tools();
        int id;
        public ChangeEmployForm()
        {
            InitializeComponent();
        }

        public ChangeEmployForm(int id, DataGridView d)
        {
            dataGridView = d;
            InitializeComponent();
            tools.FillingComboBox(PositionComboBox, "positions");
            PrintTextBox();
            this.id = id;
        }

        private void PrintTextBox()
        {
            NameBox.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            SurNameBox.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            PhoneNumBox.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            PositionComboBox.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                main.dataBase.cn.Close();
                main.dataBase.cn.Open();
                main.command = new MySqlCommand("UPDATE employees SET Name = '" + NameBox.Text + "', SurName = '" + SurNameBox.Text + "'," +
                    " PhoneNum = '" + PhoneNumBox.Text + "', Position = '" + PositionComboBox.Text + "' WHERE id = "+id+"", main.dataBase.cn);
                main.command.ExecuteNonQuery();
                main.dataBase.cn.Close();
                main.dataBase.DbLoad(dataGridView, "employees");
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
