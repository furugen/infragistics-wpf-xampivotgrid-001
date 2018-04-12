using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamPivotGrid
{
    public class SampleData
    {
        public SampleData(string name, string  category, decimal budget, decimal actual, DateTime date)
        {
            Name = name;
            Category = category;
            Budget = budget;
            Actual = actual;
            Date = date;
        }
        public DateTime Date { get; set; }

        public string Category { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public decimal Actual { get; set; }

        

        public static ObservableCollection<SampleData> CreateTestData()
        {
            ObservableCollection<SampleData> datas = new ObservableCollection<SampleData>();

            #region サンプルデータ
            datas.Add(new SampleData("通信費", "固定費", 6000, 5097, new DateTime(2018, 4, 5)));
            datas.Add(new SampleData("光熱費", "固定費", 100, 110, new DateTime(2018, 4, 5)));
            datas.Add(new SampleData("食費", "変動費", 200, 273, new DateTime(2018, 5, 7)));
            datas.Add(new SampleData("交通費", "変動費", 500, 648, new DateTime(2018, 5, 9)));
            datas.Add(new SampleData("雑費", "変動費", 798, 767, new DateTime(2018, 6, 1)));
            datas.Add(new SampleData("雑費", "変動費", 250, 226, new DateTime(2018, 6, 10)));
            datas.Add(new SampleData("食費", "変動費", 300, 374, new DateTime(2018, 9, 21)));
            datas.Add(new SampleData("雑費", "変動費", 2450, 943, new DateTime(2018, 9, 21)));
            datas.Add(new SampleData("食費", "変動費", 300, 281, new DateTime(2018, 9, 24)));
            datas.Add(new SampleData("食費", "変動費", 2000, 2705, new DateTime(2018, 10, 5)));
            datas.Add(new SampleData("雑費", "変動費", 2525, 3585, new DateTime(2018, 10, 9)));
            datas.Add(new SampleData("雑費", "変動費", 9980, 18113, new DateTime(2018, 11, 16)));
            datas.Add(new SampleData("接待費", "変動費", 24500, 14845, new DateTime(2018, 11, 17)));
            datas.Add(new SampleData("食費", "変動費", 5400, 8637, new DateTime(2018, 12, 01)));
            datas.Add(new SampleData("食費", "変動費", 2500, 1399, new DateTime(2018, 12, 05)));
            datas.Add(new SampleData("食費", "変動費", 2400, 3242, new DateTime(2019, 1, 15)));
            datas.Add(new SampleData("雑費", "変動費", 25800, 38053, new DateTime(2019, 1, 25)));
            datas.Add(new SampleData("雑費", "変動費", 2455, 2292, new DateTime(2019, 2, 25)));
            datas.Add(new SampleData("雑費", "変動費", 60000, 42393, new DateTime(2019, 3, 23)));
            #endregion


            return datas;
        }
    }
}
