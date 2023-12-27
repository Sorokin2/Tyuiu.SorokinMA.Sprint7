using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.SorokinMA.Sprint7.ProjectV11.Lib
{
    public class DataService
    {
        public string[,] GetDataBase(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] a = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = a.Length;
            int columns = a[0].Split(';').Length;
            string[,] res = new string[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] aSmall = a[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    res[i, j] = aSmall[j];
                }
            }
            return res;
        }
        public double Sum(double[] array)
        {
            return array.Sum();
        }
        public double Average(double[] array)
        {
            return Math.Round(array.Sum()/array.Length,3);
        }

        public double Min(double[] array)
        {
            return array.Min();
        }

        public double Max(double[] array)
        {
            return array.Max();
        }

        
    }
}
