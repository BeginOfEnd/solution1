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
    public class InOut1
    {
        public string Text { get; set; }
        public string Filename { get; set; }
        public string ReadFromFile(string FileName)
        {
            StreamReader sr = new StreamReader(FileName);
            string reader = sr.ReadToEnd();
            Text = "";
            Text += reader;
            sr.Close();            
            return Text;
        }
        // запись данных в файл
        public void WriteIntoFile(string filename, string text)
        {
            File.WriteAllLines(text, new string[] { text });
        }
        public string DeleteNParagraph(string Text, int N)//paragraph-абзац
        {
            int j = 0;
            int end = Text.Length;
            string clon = "";
            for (int i = 0; i < Text.Length; i++)
            {
                if (i > 1)
                {
                    if (((Text[i - 1] == '.') || (Text[i - 1] == '!') || (Text[i - 1] == '?')))
                    {
                        if ((Text[i + 1] == '\n') && (Text[i] == '\r'))
                        {
                            j++;
                            int count = clon.Length;
                            if (j == N + 1)
                            {
                                for (int l = clon.Length; l <= i; l++)
                                {
                                    clon += Text[count];
                                    if ((Text[count] == '.') || (Text[count] == '!') || (Text[count] == '?'))
                                    {
                                        if ((Text[count + 2] == '\n') && (Text[count + 1] == '\r'))
                                        {
                                            Text = Text.Remove(count, 3);
                                            break;
                                        }
                                    }                                    
                                    if ((Text[count] != '\n') && (Text[count] != '\r'))
                                    {
                                        Text = Text.Remove(count, 1);
                                    }
                                    if (((Text[count] == '\r') && (Text[count + 1] == '\n') && (Text[count + 2] == '\r')) || (Text[count] == '\n') && (Text[count + 1] == '\r') && (Text[count + 2] == '\n'))
                                    {
                                        count++;
                                        continue;
                                    }
                                    if ((((Text[count]) == '\r') && (Text[count + 1]) == '\n') && (Text[count + 2]) == ' ')
                                    {
                                        count++;
                                        continue;
                                    }
                                    if ((Text[count]) == '\n' && (Text[count + 1]) == ' ' && (clon[clon.Length - 2]) == '\r')
                                    {
                                        count++;
                                        continue;
                                    }
                                }
                            }
                            else
                                for (int k = count; k <= i + 1; k++)
                                    clon += Text[k];
                        }
                    }
                }
                    if ((i == Text.Length - 1) && ((Text[Text.Length - 1] == '.') || (Text[Text.Length - 1] == '!') || (Text[Text.Length - 1] == '?')))
                {
                    j++;
                    int count = clon.Length;
                    if (j == N + 1)
                            Text = Text.Remove(count);
                }
            }
            string NewText = Text;
            return NewText;
        }
    }
}
