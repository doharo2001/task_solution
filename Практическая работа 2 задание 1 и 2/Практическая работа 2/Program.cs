using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            int a = 10,a1=10;
            short b = 5;
            a = b;
            Console.WriteLine("неявное преобразование: " +a);
            a1 = (short)b;
            Console.WriteLine("явное преобразование: " + a1);

            string surname = "Приходченко";
            string name = "Анастасия";
            string otch = "Александровна";
            int age = 17;
            double weight =60;

            string ToShow1 = surname + " " + name + " " + otch + ",возраст " + age + ",вес " + weight;
            System.Console.WriteLine(ToShow1);

            string surname1 = "Савкина";
            string name1 = "Александра";
            string otch1 = "Николаевна";
            int age1 = 18;
            double weight1 = 60;
            string ToShow2 = surname1 + " " + name1 + " " + otch1 + ",возраст " + age1 + ",вес " + weight1;
            System.Console.WriteLine(ToShow2);

            //задание2
            string str;
            Console.WriteLine("Как тебя зовут?");
            str = Console.ReadLine();
            Console.WriteLine("Привет " +str);
            Console.ReadKey();
            System.Console.ReadLine();
        }
    }
}
