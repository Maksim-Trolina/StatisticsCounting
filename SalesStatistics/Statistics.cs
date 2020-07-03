using System;
using System.Linq;


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

        public string GetAverageValueByDayNumber(Data data,int day)
        {
            if(data == null)
            {
                return null;
            }

            var group = data.daysData.Where(x => x.Day.Day == day)
                .Select(x => x.Profit);

            if(group == null || group.Count() == 0)
            {
                return null;
            }

            decimal average = group.Average();

            average = Math.Round(average, round);

            return "С.п. равен: " + average.ToString();
        }

        public string GetAverageValueByDayOfWeek(Data data,string dayOfWeek)
        {
            if(data == null)
            {
                return null;
            }

            dayOfWeek = TranslateDayOfWeekToEnglish(dayOfWeek);

            var group = data.daysData.Where(x => x.Day.DayOfWeek.ToString() == dayOfWeek)
                .Select(x => x.Profit);

            if(group == null || group.Count() == 0)
            {
                return null;
            }

            decimal average = group.Average();

            average = Math.Round(average, round);

            return "C.п. равен: " + average.ToString();
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

        private string TranslateDayOfWeekToEnglish(string dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case "Понедельник":
                    return "Monday";

                case "Вторник":
                    return "Tuesday";

                case "Среда":
                    return "Wednesday";

                case "Четверг":
                    return "Thursday";

                case "Пятница":
                    return "Friday";

                case "Суббота":
                    return "Saturday";

                case "Воскресенье":
                    return "Sunday";

                default:
                    return null;
            }
        }
    }
}
