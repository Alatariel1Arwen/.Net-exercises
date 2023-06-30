class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the path to the file:");
        string percorsoFile = Console.ReadLine();

        if (File.Exists(percorsoFile))
        {
            try
        {
                string contenutoFile = File.ReadAllText(percorsoFile);
                Console.WriteLine("File content:");
                Console.WriteLine(contenutoFile);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
        }
        }
        else
        {
            Console.WriteLine("The specified file does not exist.");
        }

       
        Console.ReadLine();

    }
    
}
