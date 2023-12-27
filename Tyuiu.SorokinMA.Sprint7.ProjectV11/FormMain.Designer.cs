
namespace Tyuiu.SorokinMA.Sprint7.ProjectV11
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialogTask_SMA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogTask_SMA = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxButtons_SMA = new System.Windows.Forms.GroupBox();
            this.buttonGuide_SMA = new System.Windows.Forms.Button();
            this.buttonInfo_SMA = new System.Windows.Forms.Button();
            this.buttonFilter_SMA = new System.Windows.Forms.Button();
            this.buttonSort_SMA = new System.Windows.Forms.Button();
            this.buttonSearch_SMA = new System.Windows.Forms.Button();
            this.buttonStatistic_SMA = new System.Windows.Forms.Button();
            this.buttonSaveFile_SMA = new System.Windows.Forms.Button();
            this.buttonOpenFile_SMA = new System.Windows.Forms.Button();
            this.groupBoxDate_SMA = new System.Windows.Forms.GroupBox();
            this.dataGridViewDate_SMA = new System.Windows.Forms.DataGridView();
            this.toolTipButton_SMA = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxButtons_SMA.SuspendLayout();
            this.groupBoxDate_SMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDate_SMA)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogTask_SMA
            // 
            this.openFileDialogTask_SMA.FileName = "openFileDialogTask_SMA";
            // 
            // saveFileDialogTask_SMA
            // 
            this.saveFileDialogTask_SMA.FileName = "saveFileDialogTask_SMA";
            // 
            // groupBoxButtons_SMA
            // 
            this.groupBoxButtons_SMA.BackColor = System.Drawing.Color.DarkSalmon;
            this.groupBoxButtons_SMA.Controls.Add(this.buttonGuide_SMA);
            this.groupBoxButtons_SMA.Controls.Add(this.buttonInfo_SMA);
            this.groupBoxButtons_SMA.Controls.Add(this.buttonFilter_SMA);
            this.groupBoxButtons_SMA.Controls.Add(this.buttonSort_SMA);
            this.groupBoxButtons_SMA.Controls.Add(this.buttonSearch_SMA);
            this.groupBoxButtons_SMA.Controls.Add(this.buttonStatistic_SMA);
            this.groupBoxButtons_SMA.Controls.Add(this.buttonSaveFile_SMA);
            this.groupBoxButtons_SMA.Controls.Add(this.buttonOpenFile_SMA);
            this.groupBoxButtons_SMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxButtons_SMA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxButtons_SMA.Name = "groupBoxButtons_SMA";
            this.groupBoxButtons_SMA.Size = new System.Drawing.Size(784, 84);
            this.groupBoxButtons_SMA.TabIndex = 0;
            this.groupBoxButtons_SMA.TabStop = false;
            // 
            // buttonGuide_SMA
            // 
            this.buttonGuide_SMA.Location = new System.Drawing.Point(97, 19);
            this.buttonGuide_SMA.Name = "buttonGuide_SMA";
            this.buttonGuide_SMA.Size = new System.Drawing.Size(80, 55);
            this.buttonGuide_SMA.TabIndex = 5;
            this.buttonGuide_SMA.Text = "Руководство";
            this.toolTipButton_SMA.SetToolTip(this.buttonGuide_SMA, "Рыководство к приложению");
            this.buttonGuide_SMA.UseVisualStyleBackColor = true;
            this.buttonGuide_SMA.Click += new System.EventHandler(this.buttonGuide_SMA_Click);
            // 
            // buttonInfo_SMA
            // 
            this.buttonInfo_SMA.Location = new System.Drawing.Point(16, 19);
            this.buttonInfo_SMA.Name = "buttonInfo_SMA";
            this.buttonInfo_SMA.Size = new System.Drawing.Size(75, 55);
            this.buttonInfo_SMA.TabIndex = 5;
            this.buttonInfo_SMA.Text = "Справка";
            this.toolTipButton_SMA.SetToolTip(this.buttonInfo_SMA, "Справка о приложении");
            this.buttonInfo_SMA.UseVisualStyleBackColor = true;
            this.buttonInfo_SMA.Click += new System.EventHandler(this.buttonInfo_SMA_Click);
            // 
            // buttonFilter_SMA
            // 
            this.buttonFilter_SMA.Enabled = false;
            this.buttonFilter_SMA.Location = new System.Drawing.Point(548, 17);
            this.buttonFilter_SMA.Name = "buttonFilter_SMA";
            this.buttonFilter_SMA.Size = new System.Drawing.Size(75, 55);
            this.buttonFilter_SMA.TabIndex = 4;
            this.buttonFilter_SMA.Text = "Фильтр";
            this.toolTipButton_SMA.SetToolTip(this.buttonFilter_SMA, "Наложение/удаление фильтра");
            this.buttonFilter_SMA.UseVisualStyleBackColor = true;
            this.buttonFilter_SMA.Click += new System.EventHandler(this.buttonFilter_SMA_Click);
            // 
            // buttonSort_SMA
            // 
            this.buttonSort_SMA.Enabled = false;
            this.buttonSort_SMA.Location = new System.Drawing.Point(467, 17);
            this.buttonSort_SMA.Name = "buttonSort_SMA";
            this.buttonSort_SMA.Size = new System.Drawing.Size(75, 55);
            this.buttonSort_SMA.TabIndex = 3;
            this.buttonSort_SMA.Text = "Сортировка";
            this.toolTipButton_SMA.SetToolTip(this.buttonSort_SMA, "Сортировка строчек по возрастанию/убыванию");
            this.buttonSort_SMA.UseVisualStyleBackColor = true;
            this.buttonSort_SMA.Click += new System.EventHandler(this.buttonSort_SMA_Click);
            // 
            // buttonSearch_SMA
            // 
            this.buttonSearch_SMA.Enabled = false;
            this.buttonSearch_SMA.Location = new System.Drawing.Point(386, 17);
            this.buttonSearch_SMA.Name = "buttonSearch_SMA";
            this.buttonSearch_SMA.Size = new System.Drawing.Size(75, 55);
            this.buttonSearch_SMA.TabIndex = 2;
            this.buttonSearch_SMA.Text = "Поиск";
            this.toolTipButton_SMA.SetToolTip(this.buttonSearch_SMA, "Поисх определённых ячеек");
            this.buttonSearch_SMA.UseVisualStyleBackColor = true;
            this.buttonSearch_SMA.Click += new System.EventHandler(this.buttonSearch_SMA_Click);
            // 
            // buttonStatistic_SMA
            // 
            this.buttonStatistic_SMA.Enabled = false;
            this.buttonStatistic_SMA.Location = new System.Drawing.Point(629, 17);
            this.buttonStatistic_SMA.Name = "buttonStatistic_SMA";
            this.buttonStatistic_SMA.Size = new System.Drawing.Size(75, 55);
            this.buttonStatistic_SMA.TabIndex = 1;
            this.buttonStatistic_SMA.Text = "Статистика";
            this.toolTipButton_SMA.SetToolTip(this.buttonStatistic_SMA, "Статистика по видимой базе данных");
            this.buttonStatistic_SMA.UseVisualStyleBackColor = true;
            this.buttonStatistic_SMA.Click += new System.EventHandler(this.buttonStatistic_SMA_Click);
            // 
            // buttonSaveFile_SMA
            // 
            this.buttonSaveFile_SMA.Enabled = false;
            this.buttonSaveFile_SMA.Location = new System.Drawing.Point(305, 18);
            this.buttonSaveFile_SMA.Name = "buttonSaveFile_SMA";
            this.buttonSaveFile_SMA.Size = new System.Drawing.Size(75, 55);
            this.buttonSaveFile_SMA.TabIndex = 1;
            this.buttonSaveFile_SMA.Text = "Сохранить";
            this.toolTipButton_SMA.SetToolTip(this.buttonSaveFile_SMA, "Сохранение файла в формате csv");
            this.buttonSaveFile_SMA.UseVisualStyleBackColor = true;
            this.buttonSaveFile_SMA.Click += new System.EventHandler(this.buttonSaveFile_SMA_Click);
            // 
            // buttonOpenFile_SMA
            // 
            this.buttonOpenFile_SMA.AutoSize = true;
            this.buttonOpenFile_SMA.Location = new System.Drawing.Point(224, 19);
            this.buttonOpenFile_SMA.Name = "buttonOpenFile_SMA";
            this.buttonOpenFile_SMA.Size = new System.Drawing.Size(75, 55);
            this.buttonOpenFile_SMA.TabIndex = 0;
            this.buttonOpenFile_SMA.Text = "Открыть";
            this.toolTipButton_SMA.SetToolTip(this.buttonOpenFile_SMA, "Открытие файла в формате csv");
            this.buttonOpenFile_SMA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SMA.Click += new System.EventHandler(this.buttonOpenFile_SMA_Click);
            // 
            // groupBoxDate_SMA
            // 
            this.groupBoxDate_SMA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxDate_SMA.Controls.Add(this.dataGridViewDate_SMA);
            this.groupBoxDate_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDate_SMA.Location = new System.Drawing.Point(0, 84);
            this.groupBoxDate_SMA.Name = "groupBoxDate_SMA";
            this.groupBoxDate_SMA.Size = new System.Drawing.Size(784, 377);
            this.groupBoxDate_SMA.TabIndex = 0;
            this.groupBoxDate_SMA.TabStop = false;
            // 
            // dataGridViewDate_SMA
            // 
            this.dataGridViewDate_SMA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDate_SMA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDate_SMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDate_SMA.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDate_SMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDate_SMA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewDate_SMA.Name = "dataGridViewDate_SMA";
            this.dataGridViewDate_SMA.Size = new System.Drawing.Size(778, 358);
            this.dataGridViewDate_SMA.TabIndex = 0;
            this.dataGridViewDate_SMA.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDate_SMA_CellEndEdit);
            // 
            // toolTipButton_SMA
            // 
            this.toolTipButton_SMA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_SMA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBoxDate_SMA);
            this.Controls.Add(this.groupBoxButtons_SMA);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отдел кадров";
            this.groupBoxButtons_SMA.ResumeLayout(false);
            this.groupBoxButtons_SMA.PerformLayout();
            this.groupBoxDate_SMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDate_SMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SMA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTask_SMA;
        private System.Windows.Forms.GroupBox groupBoxButtons_SMA;
        private System.Windows.Forms.Button buttonOpenFile_SMA;
        private System.Windows.Forms.GroupBox groupBoxDate_SMA;
        private System.Windows.Forms.Button buttonSaveFile_SMA;
        private System.Windows.Forms.Button buttonStatistic_SMA;
        public System.Windows.Forms.DataGridView dataGridViewDate_SMA;
        private System.Windows.Forms.Button buttonSearch_SMA;
        private System.Windows.Forms.Button buttonSort_SMA;
        private System.Windows.Forms.Button buttonFilter_SMA;
        private System.Windows.Forms.Button buttonGuide_SMA;
        private System.Windows.Forms.Button buttonInfo_SMA;
        private System.Windows.Forms.ToolTip toolTipButton_SMA;
    }
}

