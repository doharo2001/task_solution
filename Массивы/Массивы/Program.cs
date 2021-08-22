using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массивы
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[11];
            int i = 0;
            Random rnd = new Random();
            int rndnumber;
            for (i = 0; i < arr.Length; i++)
            {
                rndnumber = rnd.Next(-15, 15);
                arr[i] = rndnumber;
                Console.Write(arr[i] + "  ");
            }
            Console.ReadKey();
        }
    }
}
