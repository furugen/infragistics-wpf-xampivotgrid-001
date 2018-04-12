using Infragistics.Olap.FlatData;
using System.Collections.Generic;
using System.Windows;

namespace XamPivotGrid
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // サンプルデータを設定
            SettingDatas<SampleData>(SampleData.CreateTestData());
        }

        private void SettingDatas<T>(IEnumerable<T> datas)
        {
            // Gridへのデータソースを設定
            xamDataGrid.DataSource = datas;
            // Pivotに対するデータソースを設定
            FlatDataSource flatData = new FlatDataSource()
            {
                ItemsSource = datas,
                ConnectionSettings = new FlatDataConnectionSettings(){ ItemsSource = datas}
            };
            xamPivot.DataSource = flatData;
            xamPivotDataSelector.DataSource = flatData;
        }

    }
}
