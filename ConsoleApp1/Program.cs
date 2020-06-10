using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateRandom();
        }
        static void  GenerateRandom()
        {
            Console.WriteLine("Password Generator");
            int min = 304;
            int max = 1940;
            Random _rdm = new Random();
            int num = new Random().Next(1000, 9999);
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
