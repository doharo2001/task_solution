using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Циклы.Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1,2,3,4,5,6,7,8,9,0 };
            int[] array = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[] mas = new int[10];
            for (int i = 0; i < 10; i++)
            {
                mas[i] = arr[i] + array[i];
                Console.Write(" "+mas[i]);
            }
            Console.ReadKey();
        }
    }
}
