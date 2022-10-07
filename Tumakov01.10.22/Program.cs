using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov01._10._22
{
    internal class Program
    {
        static void Sravn(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else if (a == b)
            {
                Console.WriteLine("Равны");
            }
            else
            {
                Console.WriteLine(b);
            }
        }


        static void Men(ref int a2, ref int b2)
        {
            int t = b2;
            b2 = a2;
            a2 = t;
            Console.WriteLine(a2 + " " + b2);
        }


        static int Fack(ref int a)
        {
            int b = 1;
            if (a == 1)
            {
                return 1;
            }
            try {
                b = a * Factorial(a - 1);
                return 1;
            }
            catch
            {
                return 0;
            }
            
        }


        static int Factorial(int a)
        {

            if (a == 1)
            {
                return 1;
            }
            else {
                return a * Factorial(a - 1);
            }
        }


        static void Nod(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine(a);
            }
            else
            {
                while (a != b)
                { 
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
                }
                Console.WriteLine(a);
            }
        }


        static int Fibonachi(int a)
        {
            if (a == 1)
            {
                return 0;
            }
            else if(a == 2)
            {
                return 1;
            }
            else 
            { 
                return Fibonachi(a - 1) + Fibonachi(a - 2);
            }
        }
           
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 5.1");
            Console.WriteLine("Введите два числа");
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            Sravn(c, d);
            Console.ReadKey();


            Console.WriteLine("Задание 5.2");
            Console.WriteLine("Введите два параметра");
            int c2 = int.Parse(Console.ReadLine());
            int d2 = int.Parse(Console.ReadLine());
            Men(ref c2,ref d2);
            Console.ReadKey();


            Console.WriteLine("Задание 5.3");
            Console.WriteLine("Введите число для вычисления факториала");
            int c3 = int.Parse(Console.ReadLine());
            Fack(ref c3);
            if (c3 == 0)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
            Console.ReadKey();


            Console.WriteLine("Задание 5.4");
            Console.WriteLine("Введите число");
            int c4 = int.Parse(Console.ReadLine());
            int resualt4 = Factorial(c4);
            Console.WriteLine(resualt4);
            Console.ReadKey();


            Console.WriteLine("Задание 5.5");
            Console.WriteLine("Введите два числа");
            int c5 = int.Parse(Console.ReadLine());
            int b5 = int.Parse(Console.ReadLine());
            Nod(c5, b5);
            Console.ReadKey();



            Console.WriteLine("Задание 5.6");
            Console.WriteLine("Какой член ряда Фибоначчи надо найти ");
            int c6 = int.Parse(Console.ReadLine());
            int resualt6 = Fibonachi(c6);
            Console.WriteLine(resualt6);
            Console.ReadKey();
        }
    }
}
