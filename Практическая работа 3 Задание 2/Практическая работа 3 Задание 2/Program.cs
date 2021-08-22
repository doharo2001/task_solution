using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_3_Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5.0, b = 7.0, S, c,e,c1,Y=90;
            S = (a * b) / 2;
            Console.WriteLine("Площадь равна: "+S);
            e = Math.Pow(a, 2) + Math.Pow(b, 2);
            c = Math.Sqrt(e);
            Console.WriteLine("Гипотенуза(по формуле Пифагора) равна: " + c);
            Y = Math.Cos(90 * Math.PI / 180);
            c1 =Math.Sqrt( e - 2 * a * b * Y);
            Console.WriteLine("Гипотенуза (по теореме треуголников) равна: "+c1);
            Console.ReadKey();
        }
    }
}
