using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_3_Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10,x1=10,y=10,y1=10;
            Console.WriteLine("Постинкремент x++: "+x++);
            Console.WriteLine("x*2:"+x*2);
            Console.WriteLine("Преинкремент ++x: " + ++x1);
            Console.WriteLine("x*2: " +x1*2);

            Console.WriteLine("Постдекремент x--: " +y-- );
            Console.WriteLine("x*2:" + y * 2);
            Console.WriteLine("Постдекремент --x: " + --y1);
            Console.WriteLine("x*2: " + y1 * 2);
            Console.ReadKey();
        }
    }
}
