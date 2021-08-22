using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Функции.Задание_3
{
    class Program
    {
        public static void MIN(int a, int b, int c)
        {
            if (a > b && b > c)
            {
                Console.WriteLine("Минимальное число= " + c);
            }
            else
            if (a < b && b < c)
            {
                Console.WriteLine("Минимальное число= " + a);
            }
            else
                Console.WriteLine("Минимальное число= " + b);
        }
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Введите 3 числа ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            MIN(a, b, c);
            Console.ReadKey();
        }
    }
}
