using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 999 && a <= 9999)
            {

                Console.WriteLine($"{7}{a}{8}");
            }
            else
            {
                Console.WriteLine("eded 4 reqemli deyil");
            }
        }
    }
}
