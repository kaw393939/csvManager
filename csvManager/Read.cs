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

            using (var _reader = new StreamReader(_filename))
            using (var _csv = new CsvReader(_reader, CultureInfo.InvariantCulture))
            {
                while (_csv.Read())

                {
                    _records.Add(_csv.GetRecord<T>());

                }
            }

            return _records;
        }

    }
}