using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> numbers = new List<double> { 1.2, 2.3, 3.4, 4.5, 5.6 };

        double sum = numbers.Sum();

        double average = numbers.Average();

        int count = numbers.Count;

        Console.WriteLine("Elenco numeri:");

        foreach (double number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();
        Console.WriteLine("Somma: " + sum);
        Console.WriteLine("Media: " + average);
        Console.WriteLine("Numero totale di elementi: " + count);
    }
}
