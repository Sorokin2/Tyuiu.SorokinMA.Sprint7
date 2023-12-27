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
    public partial class FormSort : Form
    {
        FormMain fmain;
        public FormSort(FormMain form)
        {
            InitializeComponent();
            this.fmain = form;
        }

        private void FormSort_Load(object sender, EventArgs e)
        {
            int columns = fmain.dataGridViewDate_SMA.ColumnCount;
            string[] columnsHeaders = new string[columns];
            for (int i = 0; i < columns; ++i)
            {
                columnsHeaders[i] = fmain.dataGridViewDate_SMA.Columns[i].HeaderText;
            }
            comboBoxChoseColumnToSort_SMA.Items.AddRange(columnsHeaders);
            comboBoxSortOrder_SMA.Items.AddRange(new string[] { "возрастанию","убыванию" });
            comboBoxChoseColumnToSort_SMA.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSortOrder_SMA.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void buttonDoneSort_SMA_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (comboBoxSortOrder_SMA.SelectedIndex == 0) 
                {
                    fmain.dataGridViewDate_SMA.Sort(fmain.dataGridViewDate_SMA.Columns[comboBoxChoseColumnToSort_SMA.SelectedIndex], ListSortDirection.Ascending);
                }
                else
                {
                    fmain.dataGridViewDate_SMA.Sort(fmain.dataGridViewDate_SMA.Columns[comboBoxChoseColumnToSort_SMA.SelectedIndex], ListSortDirection.Descending);
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("Данные некорректны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
