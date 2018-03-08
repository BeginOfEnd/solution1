using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_BL
{
    public class MyFunctions
    {
        public string Text;
        public static int[,] StringToValue(string str)
        {
            return (int[,])Convert.ChangeType(str, typeof(int[,]));
        }
        public static int[,] ReadValue<T>(string varName)
        {
            while (true)
                try
                {
                    Console.Write("Введите {0}: ", varName);
                    return StringToValue(Console.ReadLine());
                }
                catch { }  // "маскируем" ошибку (выполнится еще раз тело цикла)
        }
        public static int[,] StringToArray(string str)
        {
            string[] lines = str.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int[] a = IOUtils.StrToArray<int>(lines[0]);
            int[,] result = new int[lines.GetLength(0), a.Length];
            for (int i = 0; i < result.GetLength(0); i++)
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    int[] b = IOUtils.StrToArray<int>(lines[i]);
                    result[i, j] = b[j];
                }
            return result;
        }
        public static int[,] ReadArray(string arrName)
        {
            while (true)
                try
                {
                    Console.WriteLine("Введите (через пробел или запятую) массив {0}: ", arrName);
                    Console.Write("  ");
                    return StringToArray(Console.ReadLine());
                }
                catch { }  // "маскируем" ошибку (выполнится еще раз тело цикла)
        }
        public static string ArrayToString(int[,] arr)
        {
            string element = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                element += ElementToString(arr[i, 0]);
                for (int j = 1; j < arr.GetLength(1); j++)
                {
                    element = element + ", " + ElementToString(arr[i, j]);
                }
                element += Environment.NewLine;
            }
            return element;
        }
        public static string ElementToString(int element)
        {
            string element0;
            element0 = Convert.ToString(element);
            return element0;
        }
        public static string DeleteNParagraph(string text, uint N)//paragraph-абзац
        {
            int j = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if ((text[i] == '\n') && ((text[i - 1] == '.') || (text[i - 1] == '?') || (text[i - 1] == '!')))
                {
                    j++;
                }
            }
            for (int k = 0; k < text.Length; k++)
            {
                if (j == N - 1)
                {
                    do
                    {
                        while ((text[k] != '\n') && (text[k - 1] != '\r') && ((text[k - 2] != '.') || (text[k - 2] == '?') || (text[k - 2] == '!')))
                        {
                            text.Remove(text[k], 1);
                        }
                    }
                    while ((text[k] != '\n') && (text[k - 1] != '\r') && ((text[k - 2] != '.') || (text[k - 2] == '?') || (text[k - 2] == '!')));

                }
            }
            return text;
        }
    }
}