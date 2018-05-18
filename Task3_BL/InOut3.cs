using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Task3_BL
{
    public class InOut3
    {
        
        public string Text { get; set; }
        public string Filename { get; set; }
        public List<Student> students { get; set; }

        public InOut3()
        {
            List<Student> list = new List<Student>();
            students = list;
        }



        //сериализация
        public void WriteForSerialization(string Filename)
        {
            Text = "";
            StreamReader sr = new StreamReader(Filename);
            string reader = sr.ReadToEnd();
            Text += reader;
            sr.Close();
            int counter = 0;
            int i = 0;
            int k = 0;
            int listcounter = 0;
            int counter1 = 0;
            for (i = 0; i < Text.Length; i++)
            {
                if (i > 1)
                {
                    if (Text[i] == '\n' && Text[i - 1] == '\r' && Text[i - 2] == '\n')
                    {
                        Student Human = new Student();
                        for (int j = counter; j < i - 1; j++)
                        {
                            if (Text[j] == '\n')
                            {
                                counter1 = j;
                                string text = "";
                                for (k = counter; k < counter1 - 1; k++)
                                {
                                    text += Text[k];
                                }
                                Human.SNP = text;
                                counter = j + 1;
                                text = "";
                                for (k = counter; k < i - 1; k++)
                                {
                                    if (Text[k] == '\n')
                                    {
                                        counter1 = k;
                                        break;
                                    }
                                }
                                for (k = counter; k < counter1 - 1; k++)
                                {
                                    text += Text[k];
                                }
                                Human.DayOfTheBorn = Convert.ToDateTime(text);
                                counter = counter1 + 1;
                                for (k = counter; k < i - 1; k++)
                                {
                                    if (Text[k] == '\n')
                                    {
                                        counter1 = k;
                                        break;
                                    }
                                }
                                List<uint> marks = new List<uint>();
                                text = "";
                                for (k = counter; k < counter1 - 1; k++)
                                {
                                    if (Text[k] != ',' && Text[k] != ' ')
                                    {
                                        marks.Add(Convert.ToUInt32(Convert.ToString(Text[k])));
                                    }
                                    else
                                        continue;
                                }
                                Human.marks = marks.ToArray();
                                Human.AverageStudentMark();
                                text = "";
                                counter = counter1 + 1;
                                for (k = counter; k < i - 1; k++)
                                {
                                    if (Text[k] == '\n')
                                    {
                                        counter1 = k;
                                        break;
                                    }
                                }
                                for (k = counter; k < counter1 - 1; k++)
                                {
                                    Human.course = Convert.ToUInt32(Convert.ToString(Text[k]));
                                }
                                counter = counter1 + 1;
                                for (k = counter; k < i - 1; k++)
                                {
                                    if (Text[k] == '\n')
                                    {
                                        counter1 = k;
                                        break;
                                    }
                                }
                                for (k = counter; k < counter1 - 1; k++)
                                {
                                    Human.group = Convert.ToUInt32(Convert.ToString(Text[k]));
                                }
                                counter = i + 1;
                                listcounter++;
                                break;
                            }
                        }
                        students.Add(Human);
                    }
                }
            }
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("students.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, students);
            }
        }

        //работа с готовым
        public List<Student> ReadFromFile(string Filname)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Text = "";
            using (FileStream fs = new FileStream("students.dat", FileMode.OpenOrCreate))
            {
                students = (List<Student>)formatter.Deserialize(fs);
            }
            for (int i = 0; i < students.Count; i++)
            {
                Text += students[i].SNP;
                Text += "\r\n";
                Text += Convert.ToString(students[i].DayOfTheBorn.Day);
                Text += ".";
                Text += Convert.ToString(students[i].DayOfTheBorn.Month);
                Text += ".";
                Text += Convert.ToString(students[i].DayOfTheBorn.Year);
                Text += "\r\n";
                for (int j = 0; j < students[i].marks.Length; j++)
                {
                    Text += Convert.ToString(students[i].marks[j]);
                    if (j != students[i].marks.Length - 1)
                        Text += ",";
                }
                Text += "\r\n";
                Text += Convert.ToString(students[i].course);
                Text += "\r\n";
                Text += Convert.ToString(students[i].group);
                Text += "\r\n";
            }
            return students;
        }

        public string BelowTheAverageGroups(List<Student> students)//группы ниже среднего
        {
            string text = "";
            Text = "";
            int cycle = 0;
            uint course = 1;
            uint group = 1;
            double AverageCourse = 0;
            double AverageGroup = 0;
            uint maxcourse = 0;
            uint maxgroup = 0;
            for (cycle = 0; cycle < students.Count; cycle++)
            {
                if (students[cycle].course > maxcourse)
                    maxcourse = students[cycle].course;
                if (students[cycle].group > maxgroup)
                    maxgroup = students[cycle].group;
            }
            List<Student> Course = new List<Student>();
            List<Student> Group = new List<Student>();
            while (course <= maxcourse)
            {
                for (cycle = 0; cycle < students.Count; cycle++)
                {
                    if (students[cycle].course == course)
                        Course.Add(students[cycle]);
                }
                for (cycle = 0; cycle < Course.Count; cycle++)
                {
                        AverageCourse += students[cycle].average;
                }
                if (Course.Count > 0)
                {
                    AverageCourse /= Course.Count;
                }
                while (group <= maxgroup)
                {
                    for (cycle = 0; cycle < Course.Count; cycle++)
                    {
                        if (students[cycle].group == group)
                            Group.Add(students[cycle]);
                    }
                    for (cycle = 0; cycle < Group.Count; cycle++)
                    {
                        AverageGroup += students[cycle].average;
                    }
                    if (Group.Count > 0)
                    {
                        AverageGroup /= Group.Count;
                    }
                    if (AverageGroup < AverageCourse && AverageGroup > 1)
                        text += $"{group}  ";
                    group++;
                    Group.Clear();
                }
                Text += $"Группы{course}ого курса:  ";
                Text += text;
                course++;
                Course.Clear();
            }
            return Text;
        }

        //public List<Student> ReadFromFile(string Filename, List<Student> students)
        //{
        //    Text = "";
        //    StreamReader sr = new StreamReader(Filename);
        //    string reader = sr.ReadToEnd();
        //    Text += reader;
        //    sr.Close();
        //    int counter = 0;
        //    int i = 0;
        //    int k = 0;
        //    int listcounter = 0;
        //    int counter1 = 0;
        //    for (i = 0; i < Text.Length; i++)
        //    {
        //        if (i > 1)
        //        {
        //            if (Text[i] == '\n' && Text[i - 1] == '\r' && Text[i - 2] == '\n')
        //            {
        //                Student Human = new Student();
        //                for (int j = counter; j < i - 1; j++)
        //                {
        //                    if (Text[j] == '\n')
        //                    {
        //                        counter1 = j;
        //                        string text = "";
        //                        for (k = counter; k < counter1 - 1; k++)
        //                        {
        //                            text += Text[k];
        //                        }
        //                        Human.SNP = text;
        //                        counter = j + 1;
        //                        text = "";
        //                        for (k = counter; k < i - 1; k++)
        //                        {
        //                            if (Text[k] == '\n')
        //                            {
        //                                counter1 = k;
        //                                break;
        //                            }
        //                        }
        //                        for (k = counter; k < counter1 - 1; k++)
        //                        {
        //                            text += Text[k];
        //                        }
        //                        Human.DayOfTheBorn = Convert.ToDateTime(text);
        //                        counter = counter1 + 1;
        //                        for (k = counter; k < i - 1; k++)
        //                        {
        //                            if (Text[k] == '\n')
        //                            {
        //                                counter1 = k;
        //                                break;
        //                            }
        //                        }
        //                        int length = 0;
        //                        if (Human.DayOfTheBorn.Year == 1999)
        //                            length = 2;
        //                        if (Human.DayOfTheBorn.Year == 1998)
        //                            length = 4;
        //                        uint[] marks = new uint[length];
        //                        int arrcount = 0;
        //                        text = "";
        //                        for (k = counter; k < counter1 - 1; k++)
        //                        {
        //                            if (Text[k] != ',' && Text[k] != ' ')
        //                            {
        //                                marks[arrcount] = Convert.ToUInt32(Convert.ToString(Text[k]));
        //                                arrcount++;
        //                            }
        //                            else
        //                                continue;
        //                        }
        //                        Human.marks = marks;
        //                        text = "";
        //                        counter = counter1 + 1;
        //                        for (k = counter; k < i - 1; k++)
        //                        {
        //                            if (Text[k] == '\n')
        //                            {
        //                                counter1 = k;
        //                                break;
        //                            }
        //                        }
        //                        for (k = counter; k < counter1 - 1; k++)
        //                        {
        //                            Human.course = Convert.ToUInt32(Convert.ToString(Text[k]));
        //                        }
        //                        counter = counter1 + 1;
        //                        for (k = counter; k < i - 1; k++)
        //                        {
        //                            if (Text[k] == '\n')
        //                            {
        //                                counter1 = k;
        //                                break;
        //                            }
        //                        }
        //                        for (k = counter; k < counter1 - 1; k++)
        //                        {
        //                            Human.group = Convert.ToUInt32(Convert.ToString(Text[k]));
        //                        }
        //                        counter = i + 1;
        //                        listcounter++;
        //                        break;
        //                    }
        //                }
        //                students.Add(Human);
        //            }
        //        }
        //    }
        //    return students;
        //}



        //public string  BelowTheAverageGroups(List<Students> students)//группы ниже среднего
        //{
        //    Text = "";
        //    List<double> FirstCourse = new List<double>();
        //    List<double> SecondCourse = new List<double>();
        //    double firstfirstgroup = 0;
        //    double firstsecondgroup = 0;
        //    double firstthirdgroup = 0;
        //    double secondfirstgroup = 0;
        //    double secondsecondgroup = 0;
        //    double secondthirdgroup = 0;
        //    for (int i = students.Count - 1; i >= 0; i--)
        //    {
        //        string s = students[i].SNP;
        //        DateTime dt = students[i].DayOfTheBorn;
        //        List <uint> list = students[i].marks.ToList();
        //        uint c = students[i].course;
        //        uint g = students[i].group;
        //        if (students[i].course == 1)
        //        {
        //            if (students[i].group == 1)
        //            {
        //                uint first = 0;
        //                bool zero = false;
        //                if (firstfirstgroup == 0)
        //                {
        //                    zero = true;
        //                    for (int j = 0; j < students[i].marks.Length; j++)
        //                    {
        //                        firstfirstgroup += students[i].marks[j];
        //                    }

        //                }
        //                else
        //                {
        //                    zero = false;
        //                    for (int j = 0; j < students[i].marks.Length; j++)
        //                    {
        //                        first += students[i].marks[j];
        //                    }
        //                }
        //                if (zero)
        //                    firstfirstgroup = firstfirstgroup / students[i].marks.Length;
        //                else
        //                    firstfirstgroup = (firstfirstgroup + first) / 2;
        //            }
        //            if (students[i].group == 2)
        //            {
        //                uint second = 0;
        //                bool zero = false;
        //                if (firstsecondgroup == 0)
        //                {
        //                    zero = true;
        //                    for (int j = 0; j < students[i].marks.Length; j++)
        //                    {
        //                        firstsecondgroup += students[i].marks[j];
        //                    }

        //                }
        //                else
        //                {
        //                    zero = false;
        //                    for (int j = 0; j < students[i].marks.Length; j++)
        //                    {
        //                        second += students[i].marks[j];
        //                    }
        //                }
        //                if (zero)
        //                    firstsecondgroup = firstsecondgroup / students[i].marks.Length;
        //                else
        //                    firstsecondgroup = (firstsecondgroup + second) / 2;
        //            }
        //            if (students[i].group == 3)
        //            {
        //                uint third = 0;
        //                bool zero = false;
        //                if (firstthirdgroup == 0)
        //                {
        //                    zero = true;
        //                    for (int j = 0; j < students[i].marks.Length; j++)
        //                    {
        //                        firstthirdgroup += students[i].marks[j];
        //                    }

        //                }
        //                else
        //                {
        //                    zero = false;
        //                    for (int j = 0; j < students[i].marks.Length; j++)
        //                    {
        //                        third += students[i].marks[j];
        //                    }
        //                }
        //                if (zero)
        //                    firstthirdgroup = firstthirdgroup / students[i].marks.Length;
        //                else
        //                    firstthirdgroup = (firstthirdgroup + third) / 2;
        //            }
        //        }
        //            if (students[i].course == 2)
        //            {
        //                if (students[i].group == 1)
        //                {
        //                    uint first = 0;
        //                    bool zero = false;
        //                    if (secondfirstgroup == 0)
        //                    {
        //                        zero = true;
        //                        for (int j = 0; j < students[i].marks.Length; j++)
        //                        {
        //                            secondfirstgroup += students[i].marks[j];
        //                        }

        //                    }
        //                    else
        //                    {
        //                        zero = false;
        //                        for (int j = 0; j < students[i].marks.Length; j++)
        //                        {
        //                            first += students[i].marks[j];
        //                        }
        //                    }
        //                    if (zero)
        //                        secondfirstgroup = secondfirstgroup / students[i].marks.Length;
        //                    else
        //                        secondfirstgroup = (secondfirstgroup + first) / 2;
        //                }
        //                if (students[i].group == 2)
        //                {
        //                    uint second = 0;
        //                    bool zero = false;
        //                    if (secondsecondgroup == 0)
        //                    {
        //                        zero = true;
        //                        for (int j = 0; j < students[i].marks.Length; j++)
        //                        {
        //                            secondsecondgroup += students[i].marks[j];
        //                        }

        //                    }
        //                    else
        //                    {
        //                        zero = false;
        //                        for (int j = 0; j < students[i].marks.Length; j++)
        //                        {
        //                            second += students[i].marks[j];
        //                        }
        //                    }
        //                    if (zero)
        //                        secondsecondgroup = secondsecondgroup / students[i].marks.Length;
        //                    else
        //                        secondsecondgroup = (secondsecondgroup + second) / 2;
        //                }
        //                if (students[i].group == 3)
        //                {
        //                    uint third = 0;
        //                    bool zero = false;
        //                    if (secondthirdgroup == 0)
        //                    {
        //                        zero = true;
        //                        for (int j = 0; j < students[i].marks.Length; j++)
        //                        {
        //                            secondthirdgroup += students[i].marks[j];
        //                        }

        //                    }
        //                    else
        //                    {
        //                        zero = false;
        //                        for (int j = 0; j < students[i].marks.Length; j++)
        //                        {
        //                            third += students[i].marks[j];
        //                        }
        //                    }
        //                    if (zero)
        //                        secondthirdgroup = secondthirdgroup / students[i].marks.Length;
        //                    else
        //                        secondthirdgroup = (secondthirdgroup + third) / 2;
        //                }
        //            }
        //    }
        //    FirstCourse.Add(firstfirstgroup);
        //    FirstCourse.Add(firstsecondgroup);
        //    FirstCourse.Add(firstthirdgroup);
        //    SecondCourse.Add(secondfirstgroup);
        //    SecondCourse.Add(secondsecondgroup);
        //    SecondCourse.Add(secondthirdgroup);
        //    double firstcourse = 0;
        //    for (int f = 0; f < FirstCourse.Count; f++)
        //    {
        //        firstcourse += FirstCourse[f];
        //    }
        //    firstcourse = firstcourse / FirstCourse.Count;
        //    Text += "Группы 1ого курса: ";
        //    for (int f = 0; f < FirstCourse.Count; f++)
        //    {
        //        if (FirstCourse[f] < firstcourse)
        //            Text += $"{f + 1} ";
        //    }
        //    Text += "\r\n";
        //    double secondcourse = 0;
        //    for (int s = 0; s < SecondCourse.Count; s++)
        //    {
        //        secondcourse += SecondCourse[s];
        //    }
        //    secondcourse = secondcourse / SecondCourse.Count;
        //    Text += "Группы 2ого курса: ";
        //    for (int s = 0; s < SecondCourse.Count; s++)
        //    {
        //        if (SecondCourse[s] < secondcourse)
        //            Text += $"{s + 1} ";
        //    }
        //    Text += "\r\n";
        //    return Text;
        //}
    }
}
