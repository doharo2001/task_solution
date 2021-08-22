using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Циклы.Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int N , M ;
            Console.WriteLine("Введите кол-во строк");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов");
            M = Convert.ToInt32(Console.ReadLine());
            int c = 0,e=0;

            int[,] array = new int[N, M];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    array[i, j] = rand.Next(2, 12);
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        c++;

                    }
                    else
                    {
                        e++;
                    }
                }
               
                
            }

            Console.WriteLine("Кол-во нечетных:" + e);
            Console.WriteLine("Кол-во четных:" + c);
            Console.ReadKey();
        }
    }
}
