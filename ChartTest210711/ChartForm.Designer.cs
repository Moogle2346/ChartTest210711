
namespace ChartTest210711
{
    partial class ChartForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cht_LineGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_AddPoint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cht_LineGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // cht_LineGraph
            // 
            chartArea2.Name = "ChartArea1";
            this.cht_LineGraph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cht_LineGraph.Legends.Add(legend2);
            this.cht_LineGraph.Location = new System.Drawing.Point(21, 25);
            this.cht_LineGraph.Name = "cht_LineGraph";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.cht_LineGraph.Series.Add(series2);
            this.cht_LineGraph.Size = new System.Drawing.Size(618, 339);
            this.cht_LineGraph.TabIndex = 0;
            this.cht_LineGraph.Text = "chart1";
            // 
            // btn_AddPoint
            // 
            this.btn_AddPoint.Location = new System.Drawing.Point(86, 405);
            this.btn_AddPoint.Name = "btn_AddPoint";
            this.btn_AddPoint.Size = new System.Drawing.Size(169, 33);
            this.btn_AddPoint.TabIndex = 1;
            this.btn_AddPoint.Text = "追加";
            this.btn_AddPoint.UseVisualStyleBackColor = true;
            this.btn_AddPoint.Click += new System.EventHandler(this.btn_AddPoint_Click);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.btn_AddPoint);
            this.Controls.Add(this.cht_LineGraph);
            this.Name = "ChartForm";
            this.Text = "チャート";
            this.Load += new System.EventHandler(this.ChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cht_LineGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cht_LineGraph;
        private System.Windows.Forms.Button btn_AddPoint;
    }
}

