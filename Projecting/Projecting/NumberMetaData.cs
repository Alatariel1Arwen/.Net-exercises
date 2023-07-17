namespace Projecting
{
    class NumberMetaData
    {
        public int Number { get; }
        public bool IsEven { get; }
        public int NumberOfCharacters { get; }

        public NumberMetaData(int number)
        {
            Number = number;
            IsEven = number % 2 == 0;
            NumberOfCharacters = number.ToString().Length;
        }
    }
}
