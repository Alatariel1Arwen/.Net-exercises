class Program
{
    static LinkedList<TrainStation> trainRoute = new LinkedList<TrainStation>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Add station");
            Console.WriteLine("2. Remove station");
            Console.WriteLine("3. View route");
            Console.WriteLine("0. Go out");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the station name:");
                    string stationName = Console.ReadLine();
                    AddStation(stationName);
                    break;
                case 2:
                    Console.WriteLine("Enter the name of the station to remove:");
                    string stationToRemove = Console.ReadLine();
                    RemoveStation(stationToRemove);
                    break;
                case 3:
                    DisplayRoute();
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

    static void AddStation(string stationName)
    {
        TrainStation newStation = new TrainStation(stationName);
        trainRoute.AddLast(newStation);
        Console.WriteLine("Station added to route");
    }

    static void RemoveStation(string stationName)
    {
        bool stationRemoved = false;
        LinkedListNode<TrainStation> currentNode = trainRoute.First;

        while (currentNode != null)
        {
            if (currentNode.Value.Name == stationName)
            {
                trainRoute.Remove(currentNode);
                stationRemoved = true;
                break;
            }

            currentNode = currentNode.Next;
        }

        if (stationRemoved)
        {
            Console.WriteLine("Station removed from route");
        }
        else
        {
            Console.WriteLine("Station not found in the path");
        }
    }

    static void DisplayRoute()
    {
        Console.WriteLine("Railway path:");

        foreach (TrainStation station in trainRoute)
        {
            Console.WriteLine(station.Name);
        }
    }
}