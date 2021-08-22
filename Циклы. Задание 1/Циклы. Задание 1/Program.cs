using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Циклы.Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[21];
            arr[0] = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i + 1] = arr[i] + 3;
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
