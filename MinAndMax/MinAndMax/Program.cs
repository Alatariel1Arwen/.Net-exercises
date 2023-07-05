namespace MinAndMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<int> numeriCasuali = new List<int>();

            for (int i = 0; i < 1000; i++)
            {
                numeriCasuali.Add(random.Next(1, 1000));
            }

            int min = numeriCasuali[0];
            int max = numeriCasuali[0];

            foreach (int numero in numeriCasuali)
            {
                if (numero < min)
                {
                    min = numero;
                }

                if (numero > max)
                {
                    max = numero;
                }
            }

            Console.WriteLine("Random numbers generated:");
            Console.WriteLine(string.Join(", ", numeriCasuali));
            Console.WriteLine("Min number: " + min);
            Console.WriteLine("Max number: " + max);
        }
    }
}
