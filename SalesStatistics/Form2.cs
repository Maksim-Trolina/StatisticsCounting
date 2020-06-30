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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBoxForWritingData_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            
            if(symbol == 44)
            {
                string text = textBoxForWritingData.Text;

                IEnumerable<char> commas = text.Where(x => x == ',').Select(x => x);

                if (commas.Count() != 0 || text.Length == 0)
                {
                    e.Handled = true;
                }

                return;
            }

            if (!char.IsDigit(symbol) && symbol != 8)
            {
                e.Handled = true;
            }
        }
    }
}
