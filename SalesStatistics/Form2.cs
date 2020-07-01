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
        private Form1 form1;

        private string textForDateLabel = "Выбрана дата: ";

        private DataManager dataManager;

        public Form2(Form1 _form1)
        {
            InitializeComponent();

            form1 = _form1;

            dataManager = new DataManager();

            dateLabel.Text = textForDateLabel + calendar.SelectionRange.Start.ToShortDateString();
        }

        private bool isEnterSymbol(char symbol)
        {
            if(textBoxForWritingData.SelectionStart == 0 && symbol == 48)
            {
                return false;
            }

            if(symbol == 44)
            {
                string text = textBoxForWritingData.Text;

                IEnumerable<char> commas = text.Where(x => x == ',')
                    .Select(x => x);
                
                if(commas.Count()!=0 || textBoxForWritingData.SelectionStart == 0)
                {
                    return false;
                }

                return true;
            }

            if(!char.IsDigit(symbol) && symbol!=8)
            {
                return false;
            }

            return true;
        }

        private void textBoxForWritingData_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;

            e.Handled = !isEnterSymbol(symbol);
        }

        private void startMenuButton_Click(object sender, EventArgs e)
        {
            Hide();

            form1.Show();
        }

        private void enterDataButton_Click(object sender, EventArgs e)
        {
            dataManager.DataSave(textBoxForWritingData.Text,calendar.SelectionRange.Start);
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateLabel.Text = textForDateLabel + calendar.SelectionRange.Start.ToShortDateString();
        }
    }
}
