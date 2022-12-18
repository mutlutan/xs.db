using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace xsdb_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xsQuery1.Open(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xsQuery1.ReadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xsBindingSource1.EndEdit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            xsBindingSource1.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            xsQuery1.Close();            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            xsQuery1.Open();
            this.Text = xsQuery1.RecordCount().ToString();
        }


        private void xsBindingSource1_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }

        private void xsQuery1_RowChanging(object sender, DataRowChangeEventArgs e)
        {

        }
    }
}
