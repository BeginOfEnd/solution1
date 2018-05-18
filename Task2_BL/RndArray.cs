using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_BL
{
    class RndArray
    {
        public static string RandomArray(int n)
        {
            int[] arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(-25, 25);
            string RandomArray = IOUtils.ArrayToStr(arr);
            return RandomArray;
        }
    }
}
