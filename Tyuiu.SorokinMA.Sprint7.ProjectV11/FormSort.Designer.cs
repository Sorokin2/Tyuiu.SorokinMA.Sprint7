
namespace Tyuiu.SorokinMA.Sprint7.ProjectV11
{
    partial class FormSort
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
            this.comboBoxChoseColumnToSort_SMA = new System.Windows.Forms.ComboBox();
            this.comboBoxSortOrder_SMA = new System.Windows.Forms.ComboBox();
            this.buttonDoneSort_SMA = new System.Windows.Forms.Button();
            this.labelChoseColumnToSort_SMA = new System.Windows.Forms.Label();
            this.labelSortOrder_SMA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxChoseColumnToSort_SMA
            // 
            this.comboBoxChoseColumnToSort_SMA.FormattingEnabled = true;
            this.comboBoxChoseColumnToSort_SMA.Location = new System.Drawing.Point(17, 22);
            this.comboBoxChoseColumnToSort_SMA.Name = "comboBoxChoseColumnToSort_SMA";
            this.comboBoxChoseColumnToSort_SMA.Size = new System.Drawing.Size(198, 21);
            this.comboBoxChoseColumnToSort_SMA.TabIndex = 0;
            // 
            // comboBoxSortOrder_SMA
            // 
            this.comboBoxSortOrder_SMA.FormattingEnabled = true;
            this.comboBoxSortOrder_SMA.Location = new System.Drawing.Point(17, 66);
            this.comboBoxSortOrder_SMA.Name = "comboBoxSortOrder_SMA";
            this.comboBoxSortOrder_SMA.Size = new System.Drawing.Size(198, 21);
            this.comboBoxSortOrder_SMA.TabIndex = 0;
            // 
            // buttonDoneSort_SMA
            // 
            this.buttonDoneSort_SMA.Location = new System.Drawing.Point(256, 22);
            this.buttonDoneSort_SMA.Name = "buttonDoneSort_SMA";
            this.buttonDoneSort_SMA.Size = new System.Drawing.Size(86, 65);
            this.buttonDoneSort_SMA.TabIndex = 1;
            this.buttonDoneSort_SMA.Text = "Сортировать";
            this.buttonDoneSort_SMA.UseVisualStyleBackColor = true;
            this.buttonDoneSort_SMA.Click += new System.EventHandler(this.buttonDoneSort_SMA_Click);
            // 
            // labelChoseColumnToSort_SMA
            // 
            this.labelChoseColumnToSort_SMA.AutoSize = true;
            this.labelChoseColumnToSort_SMA.Location = new System.Drawing.Point(14, 6);
            this.labelChoseColumnToSort_SMA.Name = "labelChoseColumnToSort_SMA";
            this.labelChoseColumnToSort_SMA.Size = new System.Drawing.Size(184, 13);
            this.labelChoseColumnToSort_SMA.TabIndex = 2;
            this.labelChoseColumnToSort_SMA.Text = "Выберите столбик для сортировки";
            // 
            // labelSortOrder_SMA
            // 
            this.labelSortOrder_SMA.AutoSize = true;
            this.labelSortOrder_SMA.Location = new System.Drawing.Point(14, 50);
            this.labelSortOrder_SMA.Name = "labelSortOrder_SMA";
            this.labelSortOrder_SMA.Size = new System.Drawing.Size(90, 13);
            this.labelSortOrder_SMA.TabIndex = 2;
            this.labelSortOrder_SMA.Text = "Сортировать по:";
            // 
            // FormSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 111);
            this.Controls.Add(this.labelSortOrder_SMA);
            this.Controls.Add(this.labelChoseColumnToSort_SMA);
            this.Controls.Add(this.buttonDoneSort_SMA);
            this.Controls.Add(this.comboBoxSortOrder_SMA);
            this.Controls.Add(this.comboBoxChoseColumnToSort_SMA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сортировка";
            this.Load += new System.EventHandler(this.FormSort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChoseColumnToSort_SMA;
        private System.Windows.Forms.ComboBox comboBoxSortOrder_SMA;
        private System.Windows.Forms.Button buttonDoneSort_SMA;
        private System.Windows.Forms.Label labelChoseColumnToSort_SMA;
        private System.Windows.Forms.Label labelSortOrder_SMA;
    }
}