namespace PI
{
    partial class F_Diagram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.F_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.F_Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // F_Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.F_Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.F_Chart.Legends.Add(legend1);
            this.F_Chart.Location = new System.Drawing.Point(31, 32);
            this.F_Chart.Name = "F_Chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.F_Chart.Series.Add(series1);
            this.F_Chart.Size = new System.Drawing.Size(714, 388);
            this.F_Chart.TabIndex = 0;
            this.F_Chart.Text = "F_Chart";
            // 
            // F_Diagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.F_Chart);
            this.Name = "F_Diagram";
            this.Text = "F_Diagram";
            this.Load += new System.EventHandler(this.F_Diagram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.F_Chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart F_Chart;
    }
}