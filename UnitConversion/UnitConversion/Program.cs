class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the temperature in degrees Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = celsius * 1.8 + 32;

        Console.WriteLine("The temperature in degrees Fahrenheit is: " + fahrenheit);
        Console.ReadKey();
    }
}