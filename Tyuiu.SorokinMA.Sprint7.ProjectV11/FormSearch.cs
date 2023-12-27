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
    public partial class FormSearch : Form
    {
        FormMain fmain;
        public FormSearch(FormMain form)
        {
            InitializeComponent();
            this.fmain = form;
        }
        private void FormSearch_Load(object sender, EventArgs e)
        {
            int columns = fmain.dataGridViewDate_SMA.ColumnCount;
            string[] columnsHeaders = new string[columns];
            for (int i = 0; i < columns; ++i)
            {
                columnsHeaders[i] = fmain.dataGridViewDate_SMA.Columns[i].HeaderText;
            }
            comboBoxColumnSearch_SMA.Items.AddRange(columnsHeaders);
            comboBoxColumnSearch_SMA.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonDoneSearch_SMA_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < fmain.dataGridViewDate_SMA.RowCount; i++)
                {
                    fmain.dataGridViewDate_SMA.Rows[i].Selected = false;
                    int j = comboBoxColumnSearch_SMA.SelectedIndex;
                    if (Convert.ToString(fmain.dataGridViewDate_SMA.Rows[i].Cells[j].Value).Contains(textBoxRequest_SMA.Text))
                    {
                        fmain.dataGridViewDate_SMA.Rows[i].Selected = true;
                    }
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка поиска!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
