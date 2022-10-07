using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace HomeWork01._10._22
{
    internal class Program
    {
        static void Ur(double a, double b, double c)
        {
            double D = b * b - 2 * a * c;
            if (D == 0)
            {
                double x = -b / a * 2;
                Console.WriteLine($"Корень = {x}");
            }
            else if(D < 0)
            {
                Console.WriteLine("Корней нет");
            }
            else
            {
                double x1 = -b - Math.Sqrt(D) / a * 2;
                Console.WriteLine($"Корень 1 = {x1}");
                double x2 = -b + Math.Sqrt(D) / a * 2;
                Console.WriteLine($"Корень 2 = {x2}");
            }
        }


      
        static void Arr(double a, double b, int[] array)
        {
            int x =1 , x1 = 1;
            for (int i = 0; i < 20; i++)
            {
                if (array[i] == a)
                {
                    x = i;
                }
                if (array[i] == b)
                {
                    x1 = i;
                }
            }
            int g = array[x];
            array[x] = array[x1];
            array[x1] = g;
            for (int i = 0; i < 20; i++)
            {
                Console.Write(array[i] + " ");
            }

        }


        static void BubbleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
        }


        static void Arif(ref int[] mas1, params int[] mas)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < mas.Length; i++)
            {
                a += mas[i];
            }
            for (int i = 0; i < mas1.Length; i++)
            {
                b *= mas1[i];
            }
            Console.WriteLine("Сумма массива = " + a);
            Console.WriteLine("Произведение массива = " + b);
        }
        static void Arif4(int[] mas, out int mas2)
        {
            int a = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                a += mas[i];
            }
            mas2 = a / 20;

        }


        static void Num(int a)
        {
            try
            {
                if (a >= 0 && a < 10)
                {
                    Console.WriteLine("#");
                }
                else if (a > 9 || a < 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Ошибка!!!");
                    Thread.Sleep(3000);
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                }
            }
            catch
            {
                Console.WriteLine("Вы ввели неправильное значение, повторите попытку");
            }
            string KeyWord = "exit";
            string KeyWord5 = "закрыть";
            while (true)
            {
                string EnterWord = Console.ReadLine();

                if (EnterWord == KeyWord || EnterWord == KeyWord5)
                    Environment.Exit(0);
                Console.WriteLine("Введите закрыть или exit для закрытия программы");
            }
        }


        static void Bruice(string s)
        {
            int c = 0;
            for (int j = 0; j < s.Length; j++)
            {
                if (char.IsUpper(s[j]))
                    c++;
            }
            Console.WriteLine($"Бабка дала {c} фингал");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите коэффиценты a, b и c ");
            double a1 = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            double c1 = double.Parse(Console.ReadLine());
            Ur(a1, b1, c1);
            Console.ReadKey();


            Console.WriteLine("Задание 2");
            int[] array = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {

                array[i] = rnd.Next(1000);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n Введите два числа которые хотите поменять местами ");
            double a2 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            Arr(a2, b2, array);
            Console.Write(" \n");
            Console.ReadKey();


            Console.WriteLine("Задание 3.");
            Console.WriteLine("Введите массив:");
            int[] mas = new int[10];
            for (int i = 0; i < 10; i++)
            {
                mas[i] = int.Parse(Console.ReadLine());
            }
            BubbleSort(mas);
            Console.ReadKey();



            Console.WriteLine("Задание 4.");
            Console.WriteLine("Введите массив:");
            int[] array4 = new int[20];
            Random rnd4 = new Random();
            for (int i = 0; i < 20; i++)
            {

                array4[i] = rnd4.Next(1, 10);
                Console.Write(array4[i] + " ");
            }
            Arif(ref array4, array4);
            int arr4;
            Arif4(array4, out arr4);
            Console.WriteLine("Среднее арифмитическое массива = " + arr4);
            Console.ReadKey();


            Console.WriteLine("Задание 5.");
            Console.WriteLine("Введите число:");
            int a5 = int.Parse(Console.ReadLine());
            Num(a5);
            Console.ReadKey();


            Console.WriteLine("Задание 6.");
            string s2 = "Пидоры Уроды Бляди";
            string s3 = "Гады Черти Проститутки Путин - вор";
            string s4 = "Проститутки Ну и молодежь пошла";
            string s5 = "Суки";
            GrandFather Ded1 = new GrandFather();
            string s1 = "Проститутки Суки Гады";
            Ded1.name = "Аркадий";
            Ded1.LevelGrouch = 0;
            Ded1.bruice = 0;
            Ded1.phrase = s1;
            GrandFather Ded2 = new GrandFather();
            Ded2.name = "Дмитрий";
            Ded2.LevelGrouch = 1;
            Ded2.bruice = 0;
            Ded2.phrase = s2;
            GrandFather Ded3 = new GrandFather();
            Ded3.name = "Алексей";
            Ded3.LevelGrouch = 2;
            Ded3.bruice = 0;
            Ded3.phrase = s3;
            GrandFather Ded4 = new GrandFather();
            Ded4.name = "Илья";
            Ded4.LevelGrouch = 3;
            Ded4.bruice = 0;
            Ded4.phrase = s4;
            GrandFather Ded5 = new GrandFather();
            Ded5.name = "Евгений";
            Ded5.LevelGrouch = 4;
            Ded5.bruice = 0;
            Ded5.phrase = s5;

            Bruice(s1);
            Bruice(s2);
            Bruice(s3);
            Bruice(s4);
            Bruice(s5);
            Console.ReadKey();
        }
        struct GrandFather
        {
            public string name;
            public byte LevelGrouch;
            public string phrase;
            public byte bruice;
        }
        enum LvGr
        {
            kind,
            norm,
            angry,
            very_angry,
            very_very_angry
        }
    }
}
