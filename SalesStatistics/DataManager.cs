using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace SalesStatistics
{
    public class DataManager
    {
        private string pathJsonFile = "sasi.json";

        public void DataSave(string number, DateTime selectedDate)
        {
            decimal sum = Convert.ToDecimal(number);

            var data = GetData();

            data = ChangeData(data, selectedDate);

            if(data == null)
            {
                data = new Data();

                data.daysData = new List<DayData>();
            }

            data.daysData.Add(new DayData(selectedDate, sum));

            WriteData(data, pathJsonFile);
        }

        public Data GetData()
        {
            string jsonString = ExtractData(pathJsonFile);

            if (jsonString == null)
            {
                return null;
            }

            var data = JsonSerializer.Deserialize<Data>(jsonString);

            return data;
        }

        private void WriteData(Data data,string path)
        {
            string jsonString = JsonSerializer.Serialize(data);

            using (StreamWriter sw = new StreamWriter(path, false, Encoding.Default))
            {
                sw.Write(jsonString);
            }
        }

        private string ExtractData(string path)
        {
            if (!File.Exists(path))
            {
                return null;
            }

            string jsonString;

            using (StreamReader sr = new StreamReader(path))
            {
                jsonString = sr.ReadToEnd();
            }

            return jsonString;
        }

        private Data ChangeData(Data data, DateTime date)
        {
            if(data == null)
            {
                return null;
            }

            data.daysData = data.daysData.Where(x => x.Day.Day != date.Day || x.Day.Month != date.Month || x.Day.Year != date.Year)
                .Select(x => x)
                .ToList();

            return data;
        }
    }
}
