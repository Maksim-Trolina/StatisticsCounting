using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SalesStatistics
{

    public class Statistics
    {

        private string separator = "     С.п.: ";

        private int round = 6;

        public string GetMostProfitableDayOfWeek(Data data)
        {
            if(data == null)
            {
                return null;
            }

            var daysGroup = from day in data.daysData
                            group day by day.Day.DayOfWeek;

            decimal max = -1;

            string dayOfWeek = null;

            foreach(IGrouping<DayOfWeek,DayData> days in daysGroup)
            {
                decimal sum = 0;

                foreach(var day in days)
                {
                    sum += day.Profit;
                }

                if (sum/(days.Count()) > max)
                {
                    max = sum/(days.Count());

                    dayOfWeek = days.Key.ToString();
                }
            }

            max = Math.Round(max, round);

            return dayOfWeek + separator + max.ToString();
        }

        public string GetMostProfitableMonth(Data data)
        {
            if(data == null)
            {
                return null;
            }

            var daysGroup = from day in data.daysData
                            group day by day.Day.Month;

            decimal max = -1;

            string month = null;

            foreach(IGrouping<int,DayData> days in daysGroup)
            {
                decimal sum = 0;

                foreach(var day in days)
                {
                    sum += day.Profit;
                }

                if (sum / (days.Count()) > max)
                {
                    max = sum / (days.Count());

                    month = GetMonth(days.Key);
                }
            }

            max = Math.Round(max, round);

            return month + separator + max.ToString();
        }

        private string GetMonth(int month)
        {
            switch (month)
            {
                case 1:
                    return "Январь";

                case 2:
                    return "Февраль";

                case 3:
                    return "Март";

                case 4:
                    return "Апрель";

                case 5:
                    return "Май";

                case 6:
                    return "Июнь";

                case 7:
                    return "Июль";

                case 8:
                    return "Август";

                case 9:
                    return "Сентябрь";

                case 10:
                    return "Октябрь";

                case 11:
                    return "Ноябрь";

                case 12:
                    return "Декабрь";

                default:
                    return null;
            }
        }
    }
}
