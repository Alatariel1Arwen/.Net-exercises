
Console.WriteLine("Please enter the first number: ");

string input1 = Console.ReadLine();
int parsedInpu1 = int.Parse(input1);

Console.WriteLine("Choose option: ");

string operaore=Console.ReadLine();

Console.WriteLine("Please enter the second number: ");

string input2 = Console.ReadLine();
int parsedInput2 = int.Parse(input2);


int result = parsedInpu1 + parsedInput2;

switch (operaore)
{
    case "+":
        result = parsedInpu1 + parsedInput2;
        break;
    case "-":
        result = parsedInpu1 - parsedInput2;
        break;
    case "*":
        result = parsedInpu1 * parsedInput2;
        break;
    case "/":
        result = parsedInpu1 / parsedInput2;
        break;

    default:
        Console.WriteLine($"Invalid operator, please try again");
     
    return;
        
}

Console.Write($"The result of: {parsedInpu1} {operaore} {parsedInput2} is ");
    Console.WriteLine(result);