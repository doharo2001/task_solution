using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Условный_оператор_задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, v, m,c,c1;
            Console.WriteLine("Введите ваш рост");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш вес");
            v= Convert.ToInt32(Console.ReadLine());
            m = r - 100+5;
            if (m < v)
            {
                c = v - m;
                Console.WriteLine("Вам необходимо похудеть на: "+c);
            }
            else
                if (m > v)
            {
                c1 = m - v;
                Console.WriteLine("Вам необходимо поправиться на: " +c1);
            }
            Console.ReadKey();
        }
    }
}
