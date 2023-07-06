
class Program
{
    static void Main()
    {
        Random random = new Random();
        List<int> numbers = new List<int>();

        for (int i = 0; i < 1000; i++)
        {
            numbers.Add(random.Next(1, 1000));
        }

        var sortedNumbers = numbers.OrderBy(n => n.ToString().Length);

        foreach (var number in sortedNumbers)
        {
            Console.WriteLine(number);
        }
    }
}