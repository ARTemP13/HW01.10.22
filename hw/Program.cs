using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime1 = DateTime.Parse(Console.ReadLine());
            int a = dateTime1.Year;
            int dateTime3 = DateTime.Now.Year - a;
            Console.WriteLine(dateTime3 + " лет");
            Console.ReadKey();
        }

  

}
}
