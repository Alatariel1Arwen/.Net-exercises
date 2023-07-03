using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList myList = new ArrayList();

        myList.Add(7);
        myList.Add("Hello");
        myList.Add(3.14);
        myList.Add("World");

        foreach (var lista in myList)
        {
            Console.WriteLine(lista);
        }

        Console.ReadLine();
    }
}
