List<string> inputList = new List<string>();

for (int i = 0; i < 10; i++)
{
    Console.Write("enter a value: ");
    string input = Console.ReadLine();
    inputList.Add(input);
}

Console.WriteLine("\nList from first to last:");
foreach (string item in inputList)
{
    Console.WriteLine(item);
}

Console.WriteLine("\nList from last to first:");
for (int i = inputList.Count - 1; i >= 0; i--)
{
    Console.WriteLine(inputList[i]);
}
