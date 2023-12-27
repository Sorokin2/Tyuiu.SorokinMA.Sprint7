
namespace Tyuiu.SorokinMA.Sprint7.ProjectV11
{
    partial class FormStatistic
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
            this.groupBoxInfo_SMA = new System.Windows.Forms.GroupBox();
            this.groupBoxChart_SMA = new System.Windows.Forms.GroupBox();
            this.comboBoxLegend_SMA = new System.Windows.Forms.ComboBox();
            this.comboBoxData_SMA = new System.Windows.Forms.ComboBox();
            this.chartData_SMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonMakeChart_SMA = new System.Windows.Forms.Button();
            this.groupBoxStatistic_SMA = new System.Windows.Forms.GroupBox();
            this.textBoxCount_SMA = new System.Windows.Forms.TextBox();
            this.textBoxSum_SMA = new System.Windows.Forms.TextBox();
            this.textBoxAverage_SMA = new System.Windows.Forms.TextBox();
            this.textBoxMin_SMA = new System.Windows.Forms.TextBox();
            this.textBoxMax_SMA = new System.Windows.Forms.TextBox();
            this.labelCount_SMA = new System.Windows.Forms.Label();
            this.labelSum_SMA = new System.Windows.Forms.Label();
            this.labelAverage_SMA = new System.Windows.Forms.Label();
            this.labelMin_SMA = new System.Windows.Forms.Label();
            this.labelMax_SMA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxInfo_SMA.SuspendLayout();
            this.groupBoxChart_SMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartData_SMA)).BeginInit();
            this.groupBoxStatistic_SMA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInfo_SMA
            // 
            this.groupBoxInfo_SMA.Controls.Add(this.label2);
            this.groupBoxInfo_SMA.Controls.Add(this.label1);
            this.groupBoxInfo_SMA.Controls.Add(this.groupBoxStatistic_SMA);
            this.groupBoxInfo_SMA.Controls.Add(this.buttonMakeChart_SMA);
            this.groupBoxInfo_SMA.Controls.Add(this.comboBoxData_SMA);
            this.groupBoxInfo_SMA.Controls.Add(this.comboBoxLegend_SMA);
            this.groupBoxInfo_SMA.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxInfo_SMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInfo_SMA.Name = "groupBoxInfo_SMA";
            this.groupBoxInfo_SMA.Size = new System.Drawing.Size(188, 461);
            this.groupBoxInfo_SMA.TabIndex = 0;
            this.groupBoxInfo_SMA.TabStop = false;
            // 
            // groupBoxChart_SMA
            // 
            this.groupBoxChart_SMA.Controls.Add(this.chartData_SMA);
            this.groupBoxChart_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxChart_SMA.Location = new System.Drawing.Point(188, 0);
            this.groupBoxChart_SMA.Name = "groupBoxChart_SMA";
            this.groupBoxChart_SMA.Size = new System.Drawing.Size(596, 461);
            this.groupBoxChart_SMA.TabIndex = 0;
            this.groupBoxChart_SMA.TabStop = false;
            // 
            // comboBoxLegend_SMA
            // 
            this.comboBoxLegend_SMA.FormattingEnabled = true;
            this.comboBoxLegend_SMA.Location = new System.Drawing.Point(15, 29);
            this.comboBoxLegend_SMA.Name = "comboBoxLegend_SMA";
            this.comboBoxLegend_SMA.Size = new System.Drawing.Size(160, 21);
            this.comboBoxLegend_SMA.TabIndex = 0;
            // 
            // comboBoxData_SMA
            // 
            this.comboBoxData_SMA.FormattingEnabled = true;
            this.comboBoxData_SMA.Location = new System.Drawing.Point(16, 79);
            this.comboBoxData_SMA.Name = "comboBoxData_SMA";
            this.comboBoxData_SMA.Size = new System.Drawing.Size(160, 21);
            this.comboBoxData_SMA.TabIndex = 0;
            // 
            // chartData_SMA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartData_SMA.ChartAreas.Add(chartArea1);
            this.chartData_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartData_SMA.Legends.Add(legend1);
            this.chartData_SMA.Location = new System.Drawing.Point(3, 16);
            this.chartData_SMA.Name = "chartData_SMA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartData_SMA.Series.Add(series1);
            this.chartData_SMA.Size = new System.Drawing.Size(590, 442);
            this.chartData_SMA.TabIndex = 0;
            // 
            // buttonMakeChart_SMA
            // 
            this.buttonMakeChart_SMA.Location = new System.Drawing.Point(45, 116);
            this.buttonMakeChart_SMA.Name = "buttonMakeChart_SMA";
            this.buttonMakeChart_SMA.Size = new System.Drawing.Size(95, 39);
            this.buttonMakeChart_SMA.TabIndex = 1;
            this.buttonMakeChart_SMA.Text = "Построить график";
            this.buttonMakeChart_SMA.UseVisualStyleBackColor = true;
            this.buttonMakeChart_SMA.Click += new System.EventHandler(this.buttonMakeChart_SMA_Click);
            // 
            // groupBoxStatistic_SMA
            // 
            this.groupBoxStatistic_SMA.Controls.Add(this.labelMax_SMA);
            this.groupBoxStatistic_SMA.Controls.Add(this.labelMin_SMA);
            this.groupBoxStatistic_SMA.Controls.Add(this.labelAverage_SMA);
            this.groupBoxStatistic_SMA.Controls.Add(this.labelSum_SMA);
            this.groupBoxStatistic_SMA.Controls.Add(this.labelCount_SMA);
            this.groupBoxStatistic_SMA.Controls.Add(this.textBoxMax_SMA);
            this.groupBoxStatistic_SMA.Controls.Add(this.textBoxMin_SMA);
            this.groupBoxStatistic_SMA.Controls.Add(this.textBoxAverage_SMA);
            this.groupBoxStatistic_SMA.Controls.Add(this.textBoxSum_SMA);
            this.groupBoxStatistic_SMA.Controls.Add(this.textBoxCount_SMA);
            this.groupBoxStatistic_SMA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxStatistic_SMA.Location = new System.Drawing.Point(3, 192);
            this.groupBoxStatistic_SMA.Name = "groupBoxStatistic_SMA";
            this.groupBoxStatistic_SMA.Size = new System.Drawing.Size(182, 266);
            this.groupBoxStatistic_SMA.TabIndex = 2;
            this.groupBoxStatistic_SMA.TabStop = false;
            this.groupBoxStatistic_SMA.Text = "Статистика";
            // 
            // textBoxCount_SMA
            // 
            this.textBoxCount_SMA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCount_SMA.Location = new System.Drawing.Point(12, 50);
            this.textBoxCount_SMA.Name = "textBoxCount_SMA";
            this.textBoxCount_SMA.ReadOnly = true;
            this.textBoxCount_SMA.Size = new System.Drawing.Size(160, 23);
            this.textBoxCount_SMA.TabIndex = 0;
            // 
            // textBoxSum_SMA
            // 
            this.textBoxSum_SMA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSum_SMA.Location = new System.Drawing.Point(13, 90);
            this.textBoxSum_SMA.Name = "textBoxSum_SMA";
            this.textBoxSum_SMA.ReadOnly = true;
            this.textBoxSum_SMA.Size = new System.Drawing.Size(160, 23);
            this.textBoxSum_SMA.TabIndex = 0;
            // 
            // textBoxAverage_SMA
            // 
            this.textBoxAverage_SMA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAverage_SMA.Location = new System.Drawing.Point(12, 137);
            this.textBoxAverage_SMA.Name = "textBoxAverage_SMA";
            this.textBoxAverage_SMA.ReadOnly = true;
            this.textBoxAverage_SMA.Size = new System.Drawing.Size(160, 23);
            this.textBoxAverage_SMA.TabIndex = 0;
            // 
            // textBoxMin_SMA
            // 
            this.textBoxMin_SMA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMin_SMA.Location = new System.Drawing.Point(13, 181);
            this.textBoxMin_SMA.Name = "textBoxMin_SMA";
            this.textBoxMin_SMA.ReadOnly = true;
            this.textBoxMin_SMA.Size = new System.Drawing.Size(160, 23);
            this.textBoxMin_SMA.TabIndex = 0;
            // 
            // textBoxMax_SMA
            // 
            this.textBoxMax_SMA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMax_SMA.Location = new System.Drawing.Point(13, 225);
            this.textBoxMax_SMA.Name = "textBoxMax_SMA";
            this.textBoxMax_SMA.ReadOnly = true;
            this.textBoxMax_SMA.Size = new System.Drawing.Size(160, 23);
            this.textBoxMax_SMA.TabIndex = 0;
            // 
            // labelCount_SMA
            // 
            this.labelCount_SMA.AutoSize = true;
            this.labelCount_SMA.Location = new System.Drawing.Point(10, 34);
            this.labelCount_SMA.Name = "labelCount_SMA";
            this.labelCount_SMA.Size = new System.Drawing.Size(127, 13);
            this.labelCount_SMA.TabIndex = 1;
            this.labelCount_SMA.Text = "Количество элементов:";
            // 
            // labelSum_SMA
            // 
            this.labelSum_SMA.AutoSize = true;
            this.labelSum_SMA.Location = new System.Drawing.Point(10, 74);
            this.labelSum_SMA.Name = "labelSum_SMA";
            this.labelSum_SMA.Size = new System.Drawing.Size(44, 13);
            this.labelSum_SMA.TabIndex = 1;
            this.labelSum_SMA.Text = "Сумма:";
            // 
            // labelAverage_SMA
            // 
            this.labelAverage_SMA.AutoSize = true;
            this.labelAverage_SMA.Location = new System.Drawing.Point(9, 121);
            this.labelAverage_SMA.Name = "labelAverage_SMA";
            this.labelAverage_SMA.Size = new System.Drawing.Size(59, 13);
            this.labelAverage_SMA.TabIndex = 1;
            this.labelAverage_SMA.Text = "Срееднее:";
            // 
            // labelMin_SMA
            // 
            this.labelMin_SMA.AutoSize = true;
            this.labelMin_SMA.Location = new System.Drawing.Point(7, 165);
            this.labelMin_SMA.Name = "labelMin_SMA";
            this.labelMin_SMA.Size = new System.Drawing.Size(78, 13);
            this.labelMin_SMA.TabIndex = 1;
            this.labelMin_SMA.Text = "Минимальное";
            // 
            // labelMax_SMA
            // 
            this.labelMax_SMA.AutoSize = true;
            this.labelMax_SMA.Location = new System.Drawing.Point(9, 209);
            this.labelMax_SMA.Name = "labelMax_SMA";
            this.labelMax_SMA.Size = new System.Drawing.Size(84, 13);
            this.labelMax_SMA.TabIndex = 1;
            this.labelMax_SMA.Text = "Максимальное";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Столбик для значений";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Столбик для Легенды";
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBoxChart_SMA);
            this.Controls.Add(this.groupBoxInfo_SMA);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormStatistic";
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.FormStatistic_Load);
            this.groupBoxInfo_SMA.ResumeLayout(false);
            this.groupBoxInfo_SMA.PerformLayout();
            this.groupBoxChart_SMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartData_SMA)).EndInit();
            this.groupBoxStatistic_SMA.ResumeLayout(false);
            this.groupBoxStatistic_SMA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo_SMA;
        private System.Windows.Forms.ComboBox comboBoxData_SMA;
        private System.Windows.Forms.ComboBox comboBoxLegend_SMA;
        private System.Windows.Forms.GroupBox groupBoxChart_SMA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData_SMA;
        private System.Windows.Forms.Button buttonMakeChart_SMA;
        private System.Windows.Forms.GroupBox groupBoxStatistic_SMA;
        private System.Windows.Forms.TextBox textBoxMax_SMA;
        private System.Windows.Forms.TextBox textBoxMin_SMA;
        private System.Windows.Forms.TextBox textBoxAverage_SMA;
        private System.Windows.Forms.TextBox textBoxSum_SMA;
        private System.Windows.Forms.TextBox textBoxCount_SMA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMax_SMA;
        private System.Windows.Forms.Label labelMin_SMA;
        private System.Windows.Forms.Label labelAverage_SMA;
        private System.Windows.Forms.Label labelSum_SMA;
        private System.Windows.Forms.Label labelCount_SMA;
    }
}