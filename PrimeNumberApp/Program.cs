using System;
using static System.Math;
using System.Threading.Tasks;

namespace PrimeNumberApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Int32 n;

            Console.WriteLine("Program sprawdza, czy wczytana liczba jest liczbą pierwszą.");

            Console.WriteLine("Podaj liczbę:");

            n = Int32.Parse(Console.ReadLine());

            bool pierwsza = true;

            Parallel.For(2, (int)Sqrt(n) + 1, (i) =>
           {
               if ((n % (int)i) == 0)
               {
                   Console.WriteLine("{0} dzieli się przez {1}.", n, i);
                   pierwsza = false;
               }
           });

            if (pierwsza)
            {
                Console.WriteLine("Liczba {0} jest liczbą pierwszą.", n);
            }
            else
            {
                Console.WriteLine("Liczba {0} nie jest liczbą pierwszą.", n);
            };
        }
    }
}
