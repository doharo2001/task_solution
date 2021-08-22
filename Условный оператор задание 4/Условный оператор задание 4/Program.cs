using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Условный_оператор_задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите кол-во правельных ответов:");
            a= Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("За 1 правельный ответ вы получите 500р");
                    break;
                case 2:
                    Console.WriteLine("За 2 правельных ответа вы получите 1000р");
                    break;
                case 3:
                    Console.WriteLine("За 3 правельных ответа вы получите 2000р");
                    break;
                case 4:
                    Console.WriteLine("За 4 правельных ответа вы получите 3000р");
                    break;
                case 5:
                    Console.WriteLine("За 5 правельных ответа вы получите 5000р");
                    break;
                case 6:
                    Console.WriteLine("За 6 правельных ответов вы получите 10000р");
                    break;
                case 7:
                    Console.WriteLine("За 7 правельных ответов вы получите 15000р");
                    break;
                case 8:
                    Console.WriteLine("За 8 правельных ответов вы получите 25000р");
                    break;
                case 9:
                    Console.WriteLine("За 9 правельных ответов вы получите 50000р");
                    break;
                case 10:
                    Console.WriteLine("За 10 правельных ответов вы получите 100000р");
                    break;
                case 11:
                    Console.WriteLine("За 11 правельных ответов вы получите 200000р");
                    break;
                case 12:
                    Console.WriteLine("За 12 правельных ответов вы получите 400000р");
                    break;
                case 13:
                    Console.WriteLine("За 13 правельных ответов вы получите 800000р");
                    break;
                case 14:
                    Console.WriteLine("За 14 правельных ответов вы получите 1500000р");
                    break;
                case 15:
                    Console.WriteLine("За 15 правельных ответов вы получите 3000000р");
                    break;
                default:
                    Console.WriteLine("Максимальное кол-во вопросов 15");
                    break;
            }
            Console.ReadKey();
        }
    }
}
