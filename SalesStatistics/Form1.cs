using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesStatistics
{
    public partial class Form1 : Form
    {
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();

            form2 = new Form2(this);

            form2.FormClosing += new FormClosingEventHandler(form2_FormClosing);
        }

        private void writeDataButton_Click(object sender, EventArgs e)
        {
            Hide();

            form2.Show();
        }
        
        private void form2_FormClosing(object sender, EventArgs e)
        {
            Close();
        }
    }
}
