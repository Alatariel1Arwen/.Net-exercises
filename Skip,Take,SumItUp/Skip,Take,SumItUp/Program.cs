using System;
using System.Collections.Generic;
using System.Linq;

namespace CalcoloStatistico
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numeri = new List<double> { 1.2, 2.3, 3.4, 4.5, 5.6 };

            Console.Write("Enter the number of items to skip: ");
            int daSaltare = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of items to consider: ");
            int daPrendere = Convert.ToInt32(Console.ReadLine());

            IEnumerable<double> sottoinsieme = numeri.Skip(daSaltare).Take(daPrendere);

            double somma = sottoinsieme.Sum();
            double media = sottoinsieme.Average();
            int conteggio = sottoinsieme.Count();

            Console.WriteLine("Sum: " + somma);
            Console.WriteLine("Average: " + media);
            Console.WriteLine("Total number of items: " + conteggio);

            Console.ReadLine();
        }
    }
}
