using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HighSchoolGrigoreGrigoriu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sCHOOLDBDataSet.Class_I_Table' table. You can move, or remove it, as needed.
            this.class_I_TableTableAdapter.Fill(this.sCHOOLDBDataSet.Class_I_Table);

        }

        private void class_I_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.class_I_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sCHOOLDBDataSet);

        }
    }
}
