using System;
using FahrenheitToCelsiusConverter;

Console.WriteLine("Enter Temperature: ");

double value;
if (!double.TryParse(Console.ReadLine(), out value))
{
    Console.WriteLine("Invalid temperature value.");
    return;
}

Console.WriteLine("selected conversion: ");
Console.WriteLine("1 Celsius to Fahrenheit");
Console.WriteLine("2 Fahrenheit to Celsius");

char selected = Console.ReadKey().KeyChar;
Console.WriteLine();

TempConverter converter;

if (selected == '1')
{
    converter = new CelToFarConverter();
}
else if (selected == '2')
{
    converter = new FarToCelConverter();
}
else
{
    Console.WriteLine("Invalid command");
    return;
}
double result = converter.Convert(value);
Console.WriteLine($"the result is: {result}");