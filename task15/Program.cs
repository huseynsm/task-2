using System;

namespace task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("birinci eded: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci eded: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("ucuncu eded: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("dorduncu eded: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("besinci eded: ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.Write("altinci eded: ");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.Write("yeddinci eded: ");
            int g = Convert.ToInt32(Console.ReadLine());
            if (a > 99 && a <= 999 && b > 99 && b <= 999 && c > 999 && c <= 9999 && d > 999 && d <= 9999 && e > 9999 && e <= 99999 && f > 9999 && f <= 99999 && g > 99999 && g <= 999999)
            {
                double x = a + b;
                Console.WriteLine($"{a}+{b}={x}");
                double y = c * d;
                Console.WriteLine($"{c}*{d}={y}");
                double z = x + y;
                Console.WriteLine($"{x}+{y}={z}");
                double w = double.Parse(z.ToString() + 7);
                Console.WriteLine(w);
                double m = w + e + f;
                Console.WriteLine($"{ w}+{ e}+{ f}={ m}");
                double n = a * b;
                Console.WriteLine($"{a}*{b}={n}");
                double l = double.Parse(n.ToString() + 1);
                Console.WriteLine(l);
                double r = m - l;
                Console.WriteLine($"{m}-{l}={r}");
                double s = r + g;
                Console.WriteLine($"{r}+{g}={s}");
                double t = s - (a + b) - (c + d);
                Console.WriteLine($"{s}-{a + b}-{c + d}={t}");
                double p = t * 18 * 1.0 / 100;
                Console.WriteLine($"{t} ededinin 18 faizi: {Math.Round(p)}");
                double q = p * 3 * 1.0 / 100;
                Console.WriteLine($"{Math.Round(p)} ededinin 3 faizi: {Math.Round(q)}");
                double o = q * 1 * 1.0 / 100;
                Console.WriteLine($"{Math.Round(q)} ededinin 1 faizi: {Math.Round(o)}");
                double v = o + (e + f);
                Console.WriteLine($"{Math.Round(o)}+{e + f}={Math.Round(v) }");
            }
            else
            {
                Console.WriteLine("sert duzgun odenilmeyib");
            }
        }
    }
}
