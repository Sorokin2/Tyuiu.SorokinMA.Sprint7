using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.SorokinMA.Sprint7.ProjectV11
{
    public partial class FormFilter : Form
    {
        FormMain fmain;
        public FormFilter(FormMain form)
        {
            InitializeComponent();
            this.fmain = form;
        }

        private void comboBoxFilterColumn_SMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxVariants_SMA.Items.Clear();
            int rowsVisible = 0;
            for (int i = 0; i < fmain.dataGridViewDate_SMA.RowCount - 1; i++)
            {
                if (fmain.dataGridViewDate_SMA.Rows[i].Visible) rowsVisible++;
            }
            int rows = fmain.dataGridViewDate_SMA.RowCount - 1;
            string[] list = new string[rowsVisible];
            int k = 0;
            for(int i = 0; i<rows;i++)
            {
                if(fmain.dataGridViewDate_SMA.Rows[i].Visible)
                {
                    list[k] =fmain.dataGridViewDate_SMA.Rows[i].Cells[comboBoxFilterColumn_SMA.SelectedIndex].Value.ToString();
                    k++;
                }
                
            }
            list = list.Distinct().ToArray();
            comboBoxVariants_SMA.Items.AddRange(list);
            comboBoxVariants_SMA.Enabled = true;
        }

        private void FormFilter_Load(object sender, EventArgs e)
        {

            int columns = fmain.dataGridViewDate_SMA.ColumnCount;
            int rows = fmain.dataGridViewDate_SMA.RowCount-1;
            string[] columnsHeaders = new string[columns];
            for (int i = 0; i < columns; ++i)
            {
                columnsHeaders[i] = fmain.dataGridViewDate_SMA.Columns[i].HeaderText;
            }
            comboBoxFilterColumn_SMA.Items.AddRange(columnsHeaders);
            comboBoxFilterColumn_SMA.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVariants_SMA.DropDownStyle = ComboBoxStyle.DropDownList;
            int k = 0;
            for (int i = 0; i < rows; i++)
            {
                if (fmain.dataGridViewDate_SMA.Rows[i].Visible) k++;
            }
            if (k != rows) buttonDeleteFilter_SMA.Enabled = true;
        }

        private void buttonMakeFilter_SMA_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < fmain.dataGridViewDate_SMA.RowCount - 1; i++)
                {
                    if (!fmain.dataGridViewDate_SMA.Rows[i].Cells[comboBoxFilterColumn_SMA.SelectedIndex].Value.ToString().Contains(comboBoxVariants_SMA.SelectedItem.ToString()))
                    {
                        fmain.dataGridViewDate_SMA.Rows[i].Visible = false;
                    }
                }
                this.Close(); 
            }
            catch
            {
                MessageBox.Show("Данные некорректны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonDeleteFilter_SMA_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < fmain.dataGridViewDate_SMA.RowCount - 1; i++)
            {
                fmain.dataGridViewDate_SMA.Rows[i].Visible = true;
            }
            this.Close();
        }
    }
}
