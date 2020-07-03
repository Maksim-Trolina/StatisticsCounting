using System;
using System.Collections.Generic;
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

            numericUpDownDayNumber.Minimum = 1;

            numericUpDownDayNumber.Maximum = 31;

            List<string> days = new List<string>
            {
                "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"
            };

            domainUpDownDayOfWeek.Items.AddRange(days);
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

        private void buttonForDayNumber_Click(object sender, EventArgs e)
        {
            var data = dataManager.GetData();

            labelForDayNumber.Text = statistics.GetAverageValueByDayNumber(data, (int)numericUpDownDayNumber.Value);
        }

        private void buttonForDayOfWeek_Click(object sender, EventArgs e)
        {
            var data = dataManager.GetData();

            labelForDayOfWeek.Text = statistics.GetAverageValueByDayOfWeek(data, domainUpDownDayOfWeek.Text);
        }
    }
}
