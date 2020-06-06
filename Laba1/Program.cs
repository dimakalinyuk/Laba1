using System;

namespace Laba1
{
    public class Program
    {

        static public int Time(int n)
        {
            int a, b;
            a = n % 60;
            n -= a;
            n = n / 60;
            b = n % 60;
            n -= b;
            n = n / 60;
            Console.WriteLine("З початку доби пройшло " + n + " годин " + b + " хвилин " + a + " секунд ");
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть n");
            int n = int.Parse(Console.ReadLine());
            Time(n);
            Console.Read();
        }
    }
}
