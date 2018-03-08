using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Globalization;
using System.Diagnostics;

namespace Task1_BL
{
    public class InOut
    {
        public string input;
        public string output;
        public string ReadInputFromFile(string inFileName)
        {
            StreamReader sr = new StreamReader(inFileName);
            string reader = sr.ReadLine();
            while (reader != null)
                reader = sr.ReadLine();
            sr.Close();
            return reader;
        }
        // запись данных в файл
        public void WriteIntoFile(string filename, string text)
        {
            File.WriteAllLines(text, new string[] { text });
        }
    }
}
