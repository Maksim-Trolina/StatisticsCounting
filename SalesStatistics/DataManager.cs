using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SalesStatistics
{
    public class DataManager
    {
        private string path = "sasi.json";

        public void DataSave(string number, DateTime selectedDate)
        {
            decimal sum = Convert.ToDecimal(number);

            var day = new DayData(DateTime.Now,sum);

            var data = new Data
            {
                daysData = new List<DayData>()
            };

            Rewrite();

            data.daysData.Add(day);

            string jsonString = JsonSerializer.Serialize(data);

            using (StreamWriter sw = new StreamWriter(path, true, Encoding.Default))
            {
                sw.Write(jsonString);
            }
        }

        private void Rewrite()
        {
            if (!File.Exists(path))
            {
                return;
            }

            string jsonString;

            using (StreamReader sr = new StreamReader(path))
            {
                jsonString = sr.ReadToEnd();
            }

            var data = JsonSerializer.Deserialize<Data>(jsonString);

            if(data.daysData.Count == 0)
            {
                return;
            }

            int count = data.daysData.Count;

            if((DateTime.Now - data.daysData[count - 1].Day).Hours < 18)
            {
                data.daysData.RemoveAt(count - 1);

                jsonString = JsonSerializer.Serialize(data);

                using (StreamWriter sw = new StreamWriter(path, false, Encoding.Default))
                {
                    sw.Write(jsonString);
                }
            }
        }
    }
}
