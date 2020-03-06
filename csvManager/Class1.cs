using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;

namespace csvManager
{
    public class Read
    {

        public static IList<T> getRecords<T>(string _filename)
        {
            IList<T> _records = new List<T>();

            using (var reader = new StreamReader(_filename))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                while (csv.Read())

                {
                    _records.Add(csv.GetRecord<T>());

                }
            }

            return _records;
        }

    }
}