using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Циклы.Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string p;
            Console.WriteLine("Введите пароль: ");
            p = Convert.ToString(Console.ReadLine());
            while (p != "root")
            {
                Console.WriteLine("Неверный пароль! Введите пароль еще раз: ");
                p = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("Пароль верный!");
            Console.ReadKey();

        }
    }
}
