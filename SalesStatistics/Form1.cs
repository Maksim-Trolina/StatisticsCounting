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

        private Form3 form3;

        public Form1()
        {
            InitializeComponent();

            form2 = new Form2(this);

            form2.FormClosing += new FormClosingEventHandler(form2_FormClosing);

            form3 = new Form3(this);

            form3.FormClosing += new FormClosingEventHandler(form3_FormClosing);
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

        private void statisticsCalculationButton_Click(object sender, EventArgs e)
        {
            Hide();

            form3.SetStatistics();

            form3.Show();
        }

        private void form3_FormClosing(object sender, EventArgs e)
        {
            Close();
        }
    }
}
