using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Условный_оператор
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            int a, b;
            Console.WriteLine("Введите кол-во забитых голов хозяевами: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во забитых голов гостями: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Победили хозяева!");
            }
            else
                if (a < b)
            {
                Console.WriteLine("Победили гости!");
            }
            else
                Console.WriteLine("НИЧЬЯ!");

            // задание 2
            Console.WriteLine("Проверка на кратность, задание 2");
            int c;
            Console.WriteLine("Введите число");
            c = Convert.ToInt32(Console.ReadLine());
            if ((c % 3 == 0) && (c % 7 == 0))
            {
                Console.WriteLine("Число кратно 3 и 7");
            }
            else
                Console.WriteLine("Число некратно 3 и 7");

            Console.ReadKey();
        }
    }
}
