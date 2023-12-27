
namespace Tyuiu.SorokinMA.Sprint7.ProjectV11
{
    partial class FormFilter
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
            this.comboBoxFilterColumn_SMA = new System.Windows.Forms.ComboBox();
            this.comboBoxVariants_SMA = new System.Windows.Forms.ComboBox();
            this.buttonMakeFilter_SMA = new System.Windows.Forms.Button();
            this.buttonDeleteFilter_SMA = new System.Windows.Forms.Button();
            this.labelFilterColumn_SMA = new System.Windows.Forms.Label();
            this.labelVariants_SMA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxFilterColumn_SMA
            // 
            this.comboBoxFilterColumn_SMA.FormattingEnabled = true;
            this.comboBoxFilterColumn_SMA.Location = new System.Drawing.Point(15, 25);
            this.comboBoxFilterColumn_SMA.Name = "comboBoxFilterColumn_SMA";
            this.comboBoxFilterColumn_SMA.Size = new System.Drawing.Size(142, 21);
            this.comboBoxFilterColumn_SMA.TabIndex = 0;
            this.comboBoxFilterColumn_SMA.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterColumn_SMA_SelectedIndexChanged);
            // 
            // comboBoxVariants_SMA
            // 
            this.comboBoxVariants_SMA.Enabled = false;
            this.comboBoxVariants_SMA.FormattingEnabled = true;
            this.comboBoxVariants_SMA.Location = new System.Drawing.Point(178, 25);
            this.comboBoxVariants_SMA.Name = "comboBoxVariants_SMA";
            this.comboBoxVariants_SMA.Size = new System.Drawing.Size(156, 21);
            this.comboBoxVariants_SMA.TabIndex = 0;
            // 
            // buttonMakeFilter_SMA
            // 
            this.buttonMakeFilter_SMA.Location = new System.Drawing.Point(229, 62);
            this.buttonMakeFilter_SMA.Name = "buttonMakeFilter_SMA";
            this.buttonMakeFilter_SMA.Size = new System.Drawing.Size(105, 37);
            this.buttonMakeFilter_SMA.TabIndex = 1;
            this.buttonMakeFilter_SMA.Text = "Добавить фильтр";
            this.buttonMakeFilter_SMA.UseVisualStyleBackColor = true;
            this.buttonMakeFilter_SMA.Click += new System.EventHandler(this.buttonMakeFilter_SMA_Click);
            // 
            // buttonDeleteFilter_SMA
            // 
            this.buttonDeleteFilter_SMA.Enabled = false;
            this.buttonDeleteFilter_SMA.Location = new System.Drawing.Point(15, 62);
            this.buttonDeleteFilter_SMA.Name = "buttonDeleteFilter_SMA";
            this.buttonDeleteFilter_SMA.Size = new System.Drawing.Size(142, 37);
            this.buttonDeleteFilter_SMA.TabIndex = 2;
            this.buttonDeleteFilter_SMA.Text = "Удалить все фильтры";
            this.buttonDeleteFilter_SMA.UseVisualStyleBackColor = true;
            this.buttonDeleteFilter_SMA.Click += new System.EventHandler(this.buttonDeleteFilter_SMA_Click);
            // 
            // labelFilterColumn_SMA
            // 
            this.labelFilterColumn_SMA.AutoSize = true;
            this.labelFilterColumn_SMA.Location = new System.Drawing.Point(12, 9);
            this.labelFilterColumn_SMA.Name = "labelFilterColumn_SMA";
            this.labelFilterColumn_SMA.Size = new System.Drawing.Size(114, 13);
            this.labelFilterColumn_SMA.TabIndex = 3;
            this.labelFilterColumn_SMA.Text = "Фильтр по столбику:";
            // 
            // labelVariants_SMA
            // 
            this.labelVariants_SMA.AutoSize = true;
            this.labelVariants_SMA.Location = new System.Drawing.Point(175, 9);
            this.labelVariants_SMA.Name = "labelVariants_SMA";
            this.labelVariants_SMA.Size = new System.Drawing.Size(106, 13);
            this.labelVariants_SMA.TabIndex = 4;
            this.labelVariants_SMA.Text = "Варианты фильтра:";
            // 
            // FormFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 111);
            this.Controls.Add(this.labelVariants_SMA);
            this.Controls.Add(this.labelFilterColumn_SMA);
            this.Controls.Add(this.buttonDeleteFilter_SMA);
            this.Controls.Add(this.buttonMakeFilter_SMA);
            this.Controls.Add(this.comboBoxVariants_SMA);
            this.Controls.Add(this.comboBoxFilterColumn_SMA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фильтр";
            this.Load += new System.EventHandler(this.FormFilter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFilterColumn_SMA;
        private System.Windows.Forms.ComboBox comboBoxVariants_SMA;
        private System.Windows.Forms.Button buttonMakeFilter_SMA;
        private System.Windows.Forms.Button buttonDeleteFilter_SMA;
        private System.Windows.Forms.Label labelFilterColumn_SMA;
        private System.Windows.Forms.Label labelVariants_SMA;
    }
}