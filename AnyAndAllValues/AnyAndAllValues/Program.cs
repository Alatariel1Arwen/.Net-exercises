using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numeri = new List<int> { 2, 4, 6, 8, 10 };

        // Controlla se tutti gli elementi sono pari
        bool tuttiPari = numeri.All(n => n % 2 == 0);
        Console.WriteLine("All numbers are even? " + tuttiPari);

        // Controlla se alcuni elementi sono dispari
        bool alcuniDispari = numeri.Any(n => n % 2 != 0);
        Console.WriteLine("Some numbers are odd? " + alcuniDispari);

        Console.ReadLine();
    }
}
