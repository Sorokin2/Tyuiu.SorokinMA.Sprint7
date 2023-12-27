
namespace Tyuiu.SorokinMA.Sprint7.ProjectV11
{
    partial class FormSearch
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
            this.comboBoxColumnSearch_SMA = new System.Windows.Forms.ComboBox();
            this.textBoxRequest_SMA = new System.Windows.Forms.TextBox();
            this.buttonDoneSearch_SMA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxColumnSearch_SMA
            // 
            this.comboBoxColumnSearch_SMA.FormattingEnabled = true;
            this.comboBoxColumnSearch_SMA.Location = new System.Drawing.Point(27, 29);
            this.comboBoxColumnSearch_SMA.Name = "comboBoxColumnSearch_SMA";
            this.comboBoxColumnSearch_SMA.Size = new System.Drawing.Size(195, 21);
            this.comboBoxColumnSearch_SMA.TabIndex = 0;
            // 
            // textBoxRequest_SMA
            // 
            this.textBoxRequest_SMA.Location = new System.Drawing.Point(27, 77);
            this.textBoxRequest_SMA.Name = "textBoxRequest_SMA";
            this.textBoxRequest_SMA.Size = new System.Drawing.Size(195, 20);
            this.textBoxRequest_SMA.TabIndex = 1;
            // 
            // buttonDoneSearch_SMA
            // 
            this.buttonDoneSearch_SMA.Location = new System.Drawing.Point(256, 42);
            this.buttonDoneSearch_SMA.Name = "buttonDoneSearch_SMA";
            this.buttonDoneSearch_SMA.Size = new System.Drawing.Size(84, 50);
            this.buttonDoneSearch_SMA.TabIndex = 2;
            this.buttonDoneSearch_SMA.Text = "Найти";
            this.buttonDoneSearch_SMA.UseVisualStyleBackColor = true;
            this.buttonDoneSearch_SMA.Click += new System.EventHandler(this.buttonDoneSearch_SMA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Столбик для поиска";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Запрос для поиска";
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 111);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDoneSearch_SMA);
            this.Controls.Add(this.textBoxRequest_SMA);
            this.Controls.Add(this.comboBoxColumnSearch_SMA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxColumnSearch_SMA;
        private System.Windows.Forms.TextBox textBoxRequest_SMA;
        private System.Windows.Forms.Button buttonDoneSearch_SMA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}