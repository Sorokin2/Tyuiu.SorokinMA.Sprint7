using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SorokinMA.Sprint7.ProjectV11.Lib;

namespace Tyuiu.SorokinMA.Sprint7.ProjectV11
{
    public partial class FormStatistic : Form
    {
        FormMain fmain;
        public FormStatistic(FormMain form)
        {
            InitializeComponent();
            this.fmain = form;
        }
        DataService ds = new DataService();

        private void FormStatistic_Load(object sender, EventArgs e)
        {
            int columns = fmain.dataGridViewDate_SMA.ColumnCount;
            string[] columnsHeaders = new string[columns];
            for (int i = 0; i < columns; ++i)
            {
                columnsHeaders[i] = fmain.dataGridViewDate_SMA.Columns[i].HeaderText;
            }
            comboBoxLegend_SMA.Items.AddRange(columnsHeaders);
            comboBoxData_SMA.Items.AddRange(columnsHeaders);
            comboBoxLegend_SMA.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxData_SMA.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void buttonMakeChart_SMA_Click(object sender, EventArgs e)
        {
            int rows = fmain.dataGridViewDate_SMA.RowCount-1;

            int visibleRows = 0;
            for (int i = 0; i < rows; i++)
            {
                if (fmain.dataGridViewDate_SMA.Rows[i].Visible) visibleRows++;
            }

            double[] array = new double[visibleRows];
            string[] arrayLegend = new string[visibleRows];

            try
            {
                int legend = comboBoxLegend_SMA.SelectedIndex;
                int data = comboBoxData_SMA.SelectedIndex;
                int k = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (fmain.dataGridViewDate_SMA.Rows[i].Visible)
                    {
                        arrayLegend[k] = Convert.ToString(fmain.dataGridViewDate_SMA.Rows[i].Cells[legend].Value);
                        array[k] = Convert.ToInt32(fmain.dataGridViewDate_SMA.Rows[i].Cells[data].Value);
                        k++;
                    }
                    
                }

                textBoxCount_SMA.Text = visibleRows.ToString();
                textBoxSum_SMA.Text = ds.Sum(array).ToString();
                textBoxAverage_SMA.Text = ds.Average(array).ToString();
                textBoxMin_SMA.Text = ds.Min(array).ToString();
                textBoxMax_SMA.Text = ds.Max(array).ToString();

                chartData_SMA.Series[0].Points.Clear();
                chartData_SMA.Titles.Clear();
                chartData_SMA.Titles.Add($"Статистика по столбцу {fmain.dataGridViewDate_SMA.Columns[data].HeaderText}");

                for (int i = 0; i < k; i++)
                {
                    chartData_SMA.Series[0].Points.AddXY(arrayLegend[i], array[i]);
                }
            }
            catch
            {
                MessageBox.Show("Данные некорректны! Невозможно отобразить статистику!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
