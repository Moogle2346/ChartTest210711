using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Data;

namespace ChartTest210711.LineGraph
{
    class ChartClass
    {
        private Chart Chart;
        public DataSet dataSet { get; private set; } = new DataSet();
        private DataTable dataTable = new DataTable();
        private string tableName = "データ";
        private string chartArea = "Line";
        private string legend1 = "Graph1";
        private string legend2 = "Graph2";
        private string AxisXTitle = "横軸";

        public ChartClass(Chart chart)
        {
            this.Chart = chart; 

            InitializeDataset();
            InitializeChart();
        }

        private void InitializeDataset()
        {
            dataTable.TableName = tableName;
            dataTable.Columns.Add(AxisXTitle, typeof(int));
            dataTable.Columns.Add(legend1, typeof(double));
            dataTable.Columns.Add(legend2, typeof(double));
            dataSet.Tables.Add(dataTable);

            // 初期値
            dataTable.Rows.Add(0, 0, 0);
            dataTable.Rows.Add(1, 3.1, 1.3);
            dataTable.Rows.Add(2, 2.3, 4.4);
            dataTable.Rows.Add(3, 5.3, 0);
            dataTable.Rows.Add(4, 1.2, 3.2);
            dataTable.Rows.Add(5, 4.2, 5.1);
        }

        private void InitializeChart()
        {
            // クリア
            Chart.Titles.Clear();
            Chart.Series.Clear();
            Chart.ChartAreas.Clear();

            // データソースにDataSetをセット
            // DataSetに追加しDataBindを呼び出せば更新される。
            Chart.DataSource = dataSet;

            // Chartの設定
            // タイトル
            Chart.Titles.Add(dataTable.TableName);

            // チャートエリア
            Chart.ChartAreas.Add(new ChartArea(chartArea));

            // 縦・横軸のタイトル
            Chart.ChartAreas[chartArea].AxisX.Title = dataSet.Tables[tableName].Columns[0].ColumnName.ToString(); ;
            Chart.ChartAreas[chartArea].AxisY.Title = "縦軸";

            // Series
            for (int i = 1; i < dataSet.Tables[tableName].Columns.Count; i++)
            {
                string columnName = dataSet.Tables[tableName].Columns[i].ColumnName;
                Chart.Series.Add(columnName);

                Chart.Series[columnName].ChartType = SeriesChartType.Line;

                Chart.Series[columnName].XValueMember = dataSet.Tables[tableName].Columns[0].ColumnName.ToString();

                Chart.Series[columnName].YValueMembers = columnName;
            }

            // グリッドの表示設定
            Chart.ChartAreas[chartArea].AxisX.MajorGrid.Enabled = false;
            Chart.ChartAreas[chartArea].AxisX.MinorGrid.Enabled = false;

            // 最小設定
            Chart.ChartAreas[chartArea].AxisX.Minimum = 0;
            Chart.ChartAreas[chartArea].AxisY.Interval = 0.5;

            // データの更新
            Chart.DataBind();
        }

        public void Add(double[] data)
        {
            for(int i = 0; i < 1000; i++)
            {
                dataTable.Rows.Add(dataTable.Rows.Count + 1, data[0], data[1]);
            }

            Chart.DataBind();
        }
    }
}
