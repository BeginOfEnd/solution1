using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4_BL
{
    public class InOut4
    {
        public int HorizontalCell { get; set; }
        public int VerticalCell { get; set; }
        public string Cells { get; set; }
        public string FileName { get; set; }

        public string HorizontalToString(int hopizontal)
        {
            string text = "";
            if (hopizontal == 1)
                text += "A";
            if (hopizontal == 2)
                text += "B";
            if (hopizontal == 3)
                text += "C";
            if (hopizontal == 4)
                text += "D";
            if (hopizontal == 5)
                text += "E";
            if (hopizontal == 6)
                text = "F";
            if (hopizontal == 7)
                text += "G";
            if (hopizontal == 8)
                text += "H";
            return text;
        }
        public int StringToHorizontal(char text)
        {
            int horizontal = 0;
            if ((text == 'A') || (text == 'a'))
                horizontal = 1;
            if ((text == 'B') || (text == 'b'))
                horizontal = 2;
            if ((text == 'C') || (text == 'c'))
                horizontal = 3;
            if ((text == 'D') || (text == 'd'))
                horizontal = 4;
            if ((text == 'E') || (text == 'e'))
                horizontal = 5;
            if ((text == 'F') || (text == 'f'))
                horizontal = 6;
            if ((text == 'G') || (text == 'g'))
                horizontal = 7;
            if ((text == 'H') || (text == 'h'))
                horizontal = 8;
            return horizontal;
        }
        public void ReadFromFile(string FileName)
        {
            StreamReader sr = new StreamReader(FileName);
            string reader = sr.ReadToEnd();
            string text = reader.Trim();
            HorizontalCell = StringToHorizontal(text[0]);
            VerticalCell = Convert.ToInt32(text[1]);
        }
        public void ReadFromBox(string text)
        {
            string text2 = text.Trim();
            HorizontalCell = StringToHorizontal(text2[0]);
            VerticalCell = Convert.ToInt32(Convert.ToString((text2[1])));
        }
        public string OneCell(int HorizontalCell, int VerticalCell)
        {
            Cells += HorizontalToString(HorizontalCell);
            Cells += Convert.ToString(VerticalCell);
            Cells += "  ";
            return Cells;
        }
        public int turn(int horizontal, int vertical, int n)
        {
            HorizontalCell += horizontal;
            VerticalCell += vertical;
            OneCell(HorizontalCell, VerticalCell);
            n--;
            return n;
        }
        public string Turns(int horizontal, int vertical, int n)
        {
            int HorizontalMax = 8;
            int VerticalMax = 8;
            int HorizontalMin = 1;
            int VerticalMin = 1;
            if (n < 0)
            {
                OneCell(HorizontalCell, VerticalCell);
                return Cells;
            }
            else
            {
                if (Cells == null)
                {
                    OneCell(HorizontalCell, VerticalCell);
                }
                if ((Math.Abs(horizontal) > 1) || (Math.Abs(vertical) > 1) && (Math.Abs(horizontal) < 3) || (Math.Abs(vertical) < 3))
                {
                    if (vertical > 0 && horizontal > 0)
                    {
                        if ((HorizontalCell + horizontal <= HorizontalMax) && (VerticalCell + vertical <= VerticalMax))
                        {
                            n = turn(horizontal, vertical, n);
                        }
                        else
                            return Cells;
                    }
                    if (vertical > 0 && horizontal < 0)
                    {
                        if ((HorizontalCell + horizontal >= HorizontalMin) && (VerticalCell + vertical <= VerticalMax))
                        {
                            n = turn(horizontal, vertical, n);
                        }
                        else
                            return Cells;
                    }
                    if (vertical < 0 && horizontal > 0)
                    {
                        if ((HorizontalCell + horizontal >= HorizontalMin) && (VerticalCell + vertical >= VerticalMin))
                        {
                            n = turn(horizontal, vertical, n);
                        }
                        else
                            return Cells;
                    }
                    if (vertical > 0 && horizontal < 0)
                    {
                        if ((HorizontalCell + horizontal >= HorizontalMin) && (VerticalCell + vertical >= VerticalMin))
                        {
                            n = turn(horizontal, vertical, n);
                        }
                        else
                            return Cells;
                    }
                    Turns(horizontal, vertical, n);
                }
            }
            return Cells;
        }
    }
}
