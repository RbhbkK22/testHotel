using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testHotel.AddEntryForm
{
    public partial class AddRoomForm : Form
    {
        DataGridView dataGridView;
        Tools tool = new Tools();
        public AddRoomForm(DataGridView d)
        {
            InitializeComponent();
            dataGridView = d;
            tool.FillingComboBox(EmpComboBox, "employees", 0);
        }




    }
}
