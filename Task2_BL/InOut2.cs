using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2_BL
{
    public class InOut2
    {
        public int[] Text { get; set; }
        public string Filename { get; set; }

        public int[] ReadFromFile(string Filename)
        {
            StreamReader sr = new StreamReader(Filename);
            string line1 = sr.ReadToEnd();
            Text = IOUtils.StrToArray<int>(line1);
            sr.Close();
            return Text;
        }
        public void WriteToFile(string Filename, int n)
        {
            string rndArray = RndArray.RandomArray(n);
            File.WriteAllLines(Filename, new string[] { rndArray });
        }       
        public int[] CompressSort(int[] Text)//сжимающая сортировка
        {
            int[] arr2 = new int[Text.Length];
            for (int j = 0; j < Text.Length; j++)
            {
                if (j % 2 == 0)
                    arr2[j] = Text[j - (j / 2)];
                if (j % 2 == 1)
                    arr2[j] = Text[Text.Length - ((j + 1) / 2)];
            }
            Text = arr2;
            return Text;
        }
    }
}
