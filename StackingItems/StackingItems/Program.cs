
class Program
{
    static Stack<string> stack = new Stack<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Push");
            Console.WriteLine("2. Pop");
            Console.WriteLine("3. Peek");
            Console.WriteLine("4. Go out");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Push();
                    break;
                case "2":
                    Pop();
                    break;
                case "3":
                    Peek();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void Push()
    {
        Console.WriteLine("Insert a string to push on the stack:");
        string input = Console.ReadLine();
        stack.Push(input);
        Console.WriteLine("String pushed in stack.");
    }

    static void Pop()
    {
        if (stack.Count > 0)
        {
            string elemento = stack.Pop();
            Console.WriteLine("Item removed from stack: " + elemento);
        }
        else
        {
            Console.WriteLine("The stack is empty. Unable to pop.");
        }
    }

    static void Peek()
    {
        if (stack.Count > 0)
        {
            string elemento = stack.Peek();
            Console.WriteLine("Top element of the stack: " + elemento);
        }
        else
        {
            Console.WriteLine("The stack is empty.");
        }
    }
}