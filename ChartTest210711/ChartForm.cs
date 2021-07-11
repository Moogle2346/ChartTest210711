using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ChartTest210711.LineGraph;

namespace ChartTest210711
{
    public partial class ChartForm : Form
    {
        ChartClass chart;

        public ChartForm()
        {
            InitializeComponent();
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            chart = new ChartClass(cht_LineGraph);
        }

        private void btn_AddPoint_Click(object sender, EventArgs e)
        {
            double[] data = new double[2] { 2.5, 4.2 };
            chart.Add(data);
        }
    }
}
