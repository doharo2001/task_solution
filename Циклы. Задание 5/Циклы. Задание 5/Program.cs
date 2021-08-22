using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Циклы.Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введиде число");
            n = Convert.ToInt32(Console.ReadLine());
            for (int j = 1; j <= 9; j++)
            {
                int s = n * j;
                Console.WriteLine(n +"*"+ j +"="+ s );
                
            }
            Console.ReadKey();
        }

    }
}
