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

        public void DataSave(string number)
        {
            decimal sum = Convert.ToDecimal(number);

            var day = new DayData(DateTime.Now,sum);

            var data = new Data();

            data.daysData = new List<DayData>();

            data.daysData.Add(day);

            string jsonString = JsonSerializer.Serialize(data);

            using (StreamWriter sw = new StreamWriter(path, true, Encoding.Default))
            {
                sw.Write(jsonString);
            }
        }
    }
}
