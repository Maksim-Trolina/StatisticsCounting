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

            string jsonString = ExtractData(pathJsonFile);

            var data = GetData(jsonString, selectedDate);

            data.daysData.Add(new DayData(selectedDate, sum));

            WriteData(data, pathJsonFile);
        }

        private void WriteData(Data data,string path)
        {
            string jsonString = JsonSerializer.Serialize(data);

            using (StreamWriter sw = new StreamWriter(path, false, Encoding.Default))
            {
                sw.Write(jsonString);
            }
        }

        private Data GetData(string jsonString, DateTime date)
        {
            Data data;

            if (jsonString == null)
            {
                data = new Data();

                data.daysData = new List<DayData>();
            }
            else
            {
                data = ChangeData(jsonString, date);
            }

            return data;
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

        private Data ChangeData(string jsonString, DateTime date)
        {
            var data = JsonSerializer.Deserialize<Data>(jsonString);

            data.daysData = data.daysData.Where(x => x.Day.Day != date.Day || x.Day.Month != date.Month || x.Day.Year != date.Year)
                .Select(x => x)
                .ToList();

            return data;
        }
    }
}
