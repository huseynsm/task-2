using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 99 && a <= 999)
            {
                Console.WriteLine($"{a}{a}");
            }
            else
            {
                Console.WriteLine("eded 3 reqemli deyil");
            }
        }
    }
}
