using Projecting;

class Program
{
    static void Main()
    {
        Random random = new Random();
        List<int> numbers = Enumerable.Range(1, 100).Select(_ => random.Next(1, 1000)).ToList();

        List<NumberMetaData> metaDataList = numbers.Select(n => new NumberMetaData(n)).ToList();

        foreach (NumberMetaData metaData in metaDataList)
        {
            Console.WriteLine($"Number: {metaData.Number}, IsEven: {metaData.IsEven}, NumberOfCharacters: {metaData.NumberOfCharacters}");
        }
    }
}