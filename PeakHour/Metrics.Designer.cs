namespace PeakHour
{
    partial class Metrics
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
            this.dailyCard = new MaterialSkin.Controls.MaterialCard();
            this.dailyPiChart = new LiveCharts.WinForms.PieChart();
            this.weeklyCard = new MaterialSkin.Controls.MaterialCard();
            this.weeklyPiChart = new LiveCharts.WinForms.PieChart();
            this.lblWeeklyData = new MaterialSkin.Controls.MaterialLabel();
            this.lblDailyData = new MaterialSkin.Controls.MaterialLabel();
            this.dailyCard.SuspendLayout();
            this.weeklyCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // dailyCard
            // 
            this.dailyCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dailyCard.Controls.Add(this.dailyPiChart);
            this.dailyCard.Depth = 0;
            this.dailyCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dailyCard.Location = new System.Drawing.Point(14, 146);
            this.dailyCard.Margin = new System.Windows.Forms.Padding(14);
            this.dailyCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.dailyCard.Name = "dailyCard";
            this.dailyCard.Padding = new System.Windows.Forms.Padding(14);
            this.dailyCard.Size = new System.Drawing.Size(563, 361);
            this.dailyCard.TabIndex = 0;
            // 
            // dailyPiChart
            // 
            this.dailyPiChart.Location = new System.Drawing.Point(17, 17);
            this.dailyPiChart.Name = "dailyPiChart";
            this.dailyPiChart.Size = new System.Drawing.Size(522, 327);
            this.dailyPiChart.TabIndex = 0;
            this.dailyPiChart.Text = "daily";
            // 
            // weeklyCard
            // 
            this.weeklyCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.weeklyCard.Controls.Add(this.weeklyPiChart);
            this.weeklyCard.Depth = 0;
            this.weeklyCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.weeklyCard.Location = new System.Drawing.Point(605, 146);
            this.weeklyCard.Margin = new System.Windows.Forms.Padding(14);
            this.weeklyCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.weeklyCard.Name = "weeklyCard";
            this.weeklyCard.Padding = new System.Windows.Forms.Padding(14);
            this.weeklyCard.Size = new System.Drawing.Size(563, 361);
            this.weeklyCard.TabIndex = 0;
            // 
            // weeklyPiChart
            // 
            this.weeklyPiChart.Location = new System.Drawing.Point(17, 17);
            this.weeklyPiChart.Name = "weeklyPiChart";
            this.weeklyPiChart.Size = new System.Drawing.Size(522, 327);
            this.weeklyPiChart.TabIndex = 0;
            this.weeklyPiChart.Text = "weekly";
            // 
            // lblWeeklyData
            // 
            this.lblWeeklyData.AutoSize = true;
            this.lblWeeklyData.Depth = 0;
            this.lblWeeklyData.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWeeklyData.Location = new System.Drawing.Point(823, 521);
            this.lblWeeklyData.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWeeklyData.Name = "lblWeeklyData";
            this.lblWeeklyData.Size = new System.Drawing.Size(89, 19);
            this.lblWeeklyData.TabIndex = 1;
            this.lblWeeklyData.Text = "Weekly Data";
            // 
            // lblDailyData
            // 
            this.lblDailyData.AutoSize = true;
            this.lblDailyData.Depth = 0;
            this.lblDailyData.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDailyData.Location = new System.Drawing.Point(243, 521);
            this.lblDailyData.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDailyData.Name = "lblDailyData";
            this.lblDailyData.Size = new System.Drawing.Size(75, 19);
            this.lblDailyData.TabIndex = 1;
            this.lblDailyData.Text = "Daily Data";
            // 
            // Metrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 568);
            this.Controls.Add(this.lblDailyData);
            this.Controls.Add(this.lblWeeklyData);
            this.Controls.Add(this.weeklyCard);
            this.Controls.Add(this.dailyCard);
            this.Name = "Metrics";
            this.Text = "Metrics";
            this.Load += new System.EventHandler(this.Metrics_Load);
            this.dailyCard.ResumeLayout(false);
            this.weeklyCard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard dailyCard;
        private LiveCharts.WinForms.PieChart dailyPiChart;
        private MaterialSkin.Controls.MaterialCard weeklyCard;
        private LiveCharts.WinForms.PieChart weeklyPiChart;
        private MaterialSkin.Controls.MaterialLabel lblWeeklyData;
        private MaterialSkin.Controls.MaterialLabel lblDailyData;
    }
}