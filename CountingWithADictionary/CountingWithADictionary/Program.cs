
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the path to the .txt file:");
        string filePath = Console.ReadLine();

        if (File.Exists(filePath))
        {
            Dictionary<string, int> wordFrequency = CountWordsFrequency(filePath);
            Console.WriteLine("Unique words and their frequencies:");
            foreach (var kvp in wordFrequency)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
        else
        {
            Console.WriteLine("The specified file does not exist.");
        }
    }

    static Dictionary<string, int> CountWordsFrequency(string filePath)
    {
        string text = File.ReadAllText(filePath);
        string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordFrequency = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        foreach (string word in words)
        {
            if (wordFrequency.ContainsKey(word))
            {
                wordFrequency[word]++;
            }
            else
            {
                wordFrequency[word] = 1;
            }
        }

        return wordFrequency;
    }
}