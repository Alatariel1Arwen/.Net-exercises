using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Random random = new Random();

        int[] numbers = Enumerable.Range(1, 1000).Select(x => random.Next()).ToArray();

        var ascendingOrder = numbers.OrderBy(x => x);
        var descendingOrder = numbers.OrderByDescending(x => x);

        Console.WriteLine("Ascending order:");

        foreach (int number in ascendingOrder)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();

        Console.WriteLine("Descending order:");

        foreach (int number in descendingOrder)
        {
            Console.WriteLine(number);
        }
    }
}
