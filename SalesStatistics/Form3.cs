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
    public partial class Form3 : Form
    {
        private Form1 form1;

        private DataManager dataManager;

        private Statistics statistics;

        public Form3(Form1 _form1)
        {
            InitializeComponent();

            form1 = _form1;

            dataManager = new DataManager();

            statistics = new Statistics();
        }

        private void startMenuButton_Click(object sender, EventArgs e)
        {
            Hide();

            form1.Show();
        }

        public void SetStatistics()
        {
            var data = dataManager.GetData();

            labelStatisticsForDay.Text = "Самый прибыльный день недели за всё время: " + statistics.GetMostProfitableDayOfWeek(data);

            labelForMonth.Text = "Самый прибыльный месяц за всё время: " + statistics.GetMostProfitableMonth(data);
        }
    }
}
