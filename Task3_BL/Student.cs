using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_BL
{
    [Serializable]
    public class Student
    {
        public string SNP { get; set; } //ФИО(SurnameNamePatronymic)
        public DateTime DayOfTheBorn { get; set; }
        public uint[] marks { get; set; }
        public uint course { get; set; }
        public uint group { get; set; }
        public double average { get { return mark; } } //средняя оценка

        private double mark { get; set; }

        public void AverageStudentMark()
        {
            mark = 0;
            for (int i = 0; i < marks.Length; i++)
            {
               mark  += marks[i];
            }
            mark /= marks.Length;
        }
    }
}
