﻿namespace _016_Chart2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnOneChart = new System.Windows.Forms.Button();
            this.btnTwoChart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(776, 381);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btnOneChart
            // 
            this.btnOneChart.Location = new System.Drawing.Point(186, 399);
            this.btnOneChart.Name = "btnOneChart";
            this.btnOneChart.Size = new System.Drawing.Size(149, 33);
            this.btnOneChart.TabIndex = 1;
            this.btnOneChart.Text = "합쳐서 그리기";
            this.btnOneChart.UseVisualStyleBackColor = true;
            this.btnOneChart.Click += new System.EventHandler(this.btnOneChart_Click);
            // 
            // btnTwoChart
            // 
            this.btnTwoChart.Location = new System.Drawing.Point(461, 399);
            this.btnTwoChart.Name = "btnTwoChart";
            this.btnTwoChart.Size = new System.Drawing.Size(149, 33);
            this.btnTwoChart.TabIndex = 2;
            this.btnTwoChart.Text = "나누어 그리기";
            this.btnTwoChart.UseVisualStyleBackColor = true;
            this.btnTwoChart.Click += new System.EventHandler(this.btnTwoChart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTwoChart);
            this.Controls.Add(this.btnOneChart);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnOneChart;
        private System.Windows.Forms.Button btnTwoChart;
    }
}

