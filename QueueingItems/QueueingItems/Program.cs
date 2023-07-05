using System.Collections;

class Program
{
    static Queue myQueue = new Queue();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Add to queue");
            Console.WriteLine("2. Remove from queue");
            Console.WriteLine("3. Peek");
            Console.WriteLine("0. Go out");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter a string to add to the queue:");
                    string input = Console.ReadLine();
                    EnqueueItem(input);
                    break;
                case 2:
                    DequeueItem();
                    break;
                case 3:
                    PeekItem();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void EnqueueItem(string item)
    {
        myQueue.Enqueue(item);
        Console.WriteLine("Item added to queue");
    }

    static void DequeueItem()
    {
        if (myQueue.Count == 0)
        {
            Console.WriteLine("The queue is empty");
        }
        else
        {
            string item = (string)myQueue.Dequeue();
            Console.WriteLine("Item removed from queue: " + item);
        }
    }

    static void PeekItem()
    {
        if (myQueue.Count == 0)
        {
            Console.WriteLine("The queue is empty");
        }
        else
        {
            string item = (string)myQueue.Peek();
            Console.WriteLine("Item at the top of the queue: " + item);
        }
    }
}
