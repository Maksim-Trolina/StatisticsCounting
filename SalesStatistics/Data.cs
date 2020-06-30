using System;


namespace SalesStatistics
{
    public class Data
    {
        public DayData[] daysData { get; set; }
    }

    public class DayData
    {
        public DateTime Day { get; set; }

        public decimal Profit { get; set; }
    }
}
