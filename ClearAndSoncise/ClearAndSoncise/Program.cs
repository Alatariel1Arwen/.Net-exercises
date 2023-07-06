using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Random random = new Random();
        List<int> numbers = new List<int>();

        for (int i = 0; i < 1000; i++)
        {
            numbers.Add(random.Next(1, 10000));
        }

        var oddNumbers = numbers.Where(number => number % 2 != 0);

        foreach (var number in oddNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
