using System;
using System.Diagnostics.CodeAnalysis;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti un program care va afisa suma cifrelor unui numar n, n fiind citit de la tastatura */

            int n;
            
            Console.WriteLine("Introduceti numarul:");
            n = int.Parse(Console.ReadLine());

            int sumaNumerelor = 0;

             while (n != 0)
            {
                int ultimaCifra = n % 10;
                sumaNumerelor = sumaNumerelor + ultimaCifra;

                n = n / 10;
            }

            Console.WriteLine("\n"+"Suma numerelor este "+ sumaNumerelor + ".");
        }
    }
}
