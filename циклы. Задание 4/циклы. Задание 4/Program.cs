using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace циклы.Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {0,1,2,3,4,5,6,7,8,9,-1,-2,-3,-4,-5,-6,-7,-8,-9,20,21,22,23,24,25,26,27,28,29,30,60,61,62 };
            foreach (var i in array)
            {
                if (i > 20 && i < 50) Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
