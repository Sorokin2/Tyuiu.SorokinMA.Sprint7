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
using System.IO;

namespace Tyuiu.SorokinMA.Sprint7.ProjectV11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_SMA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask_SMA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        DataService ds = new DataService();
        int rows;
        int columns;
        string openFilePath;
        string[,] matrix;

        private void buttonOpenFile_SMA_Click(object sender, EventArgs e)
        {
            if (openFileDialogTask_SMA.ShowDialog() == DialogResult.OK)
            {
                openFilePath = openFileDialogTask_SMA.FileName;
                matrix = ds.GetDataBase(openFilePath);
                rows = matrix.GetUpperBound(0)+1;
                columns = matrix.Length/rows;
                dataGridViewDate_SMA.ColumnCount = columns;
                dataGridViewDate_SMA.RowCount = rows;
                for (int i = 0; i<columns;i++)
                {
                    dataGridViewDate_SMA.Columns[i].HeaderText = matrix[0, i];
                    dataGridViewDate_SMA.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                for (int i = 1; i < rows; i++) 
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewDate_SMA.Rows[i - 1].Cells[j].Value =   matrix[i, j];
                        if (double.TryParse(dataGridViewDate_SMA.Rows[i - 1].Cells[j].Value.ToString(), out double number) && !(dataGridViewDate_SMA.Rows[i - 1].Cells[j].Value.ToString().StartsWith("+7")))
                        {
                            dataGridViewDate_SMA.Rows[i - 1].Cells[j].Value = number;
                        }
                    }
                }
                buttonSaveFile_SMA.Enabled = true;
                buttonSearch_SMA.Enabled = true;
                buttonSort_SMA.Enabled = true;
                buttonStatistic_SMA.Enabled = true;
                buttonFilter_SMA.Enabled = true;
            }   

        }

        private void buttonSaveFile_SMA_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_SMA.FileName = "SaveData.csv";
            saveFileDialogTask_SMA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_SMA.ShowDialog();
            string savePath = saveFileDialogTask_SMA.FileName;
            FileInfo fileInfo = new FileInfo(savePath);
            bool FileExists = fileInfo.Exists;
            if (FileExists) File.Delete(savePath);
            rows = dataGridViewDate_SMA.RowCount;
            string str = "";
            for (int c = 0; c < columns; c++)
            {
                if (c == columns - 1) str += dataGridViewDate_SMA.Columns[c].HeaderText;
                else str += dataGridViewDate_SMA.Columns[c].HeaderText + ";";
            }
            File.AppendAllText(savePath, str + Environment.NewLine);
            for (int i = 0; i < rows-1; i++)
            {
                str = "";
                for (int j = 0; j < columns; j++)
                {
                    
                    if (j == columns - 1) str += dataGridViewDate_SMA.Rows[i].Cells[j].Value;
                    else str += dataGridViewDate_SMA.Rows[i].Cells[j].Value + ";";
                }
                File.AppendAllText(savePath, str + Environment.NewLine);
            }

        }

        private void buttonStatistic_SMA_Click(object sender, EventArgs e)
        {
            FormStatistic formStatistic = new FormStatistic(this);
            formStatistic.ShowDialog();
        }

        private void buttonSearch_SMA_Click(object sender, EventArgs e)
        {
            FormSearch formSearch = new FormSearch(this);
            formSearch.ShowDialog();
        }

        private void buttonSort_SMA_Click(object sender, EventArgs e)
        {
            FormSort formSort = new FormSort(this);
            formSort.ShowDialog();
        }

        private void dataGridViewDate_SMA_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDate_SMA.CurrentCell.Value!=null && double.TryParse(dataGridViewDate_SMA.CurrentCell.Value.ToString(), out double number) && !(dataGridViewDate_SMA.CurrentCell.Value.ToString().StartsWith("+7")))
            {
                dataGridViewDate_SMA.CurrentCell.Value = number;
            }
        }

        private void buttonFilter_SMA_Click(object sender, EventArgs e)
        {
            FormFilter formFilter = new FormFilter(this);
            formFilter.ShowDialog();
        }

        private void buttonInfo_SMA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonGuide_SMA_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }
    }
}
