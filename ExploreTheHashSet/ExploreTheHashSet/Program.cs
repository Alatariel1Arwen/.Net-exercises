
class Program
{
    static void Main()
    {
        HashSet<string> uniqueStrings = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        uniqueStrings.Add("Apple");
        uniqueStrings.Add("apple");
        uniqueStrings.Add("Banana");
        uniqueStrings.Add("banana");

        Console.WriteLine("Elements nel HashSet:");
        foreach (string str in uniqueStrings)
        {
            Console.WriteLine(str);
        }
    }
}