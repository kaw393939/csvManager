using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csvManager.Tests
{
    [TestClass()]
    public class ReadTests
    {
        [TestMethod()]
        public void getRecordsTest()
        {
            var _filename = "/Users//keith//OneDrive//Documents//csvData//test.csv";
            var _records = Read.getRecords<Foo>(_filename);
            Assert.AreEqual(2, _records.Count);
            //Debug.Write(_records.ToString());
        }

        public class Foo
        {
            public int Id { get; set; }
            public string Name { get; set; }

        }
    }
}