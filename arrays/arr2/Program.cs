namespace arr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            int[] rounded = new int[numbers.Length];
            for(int i = 0; i < numbers.Length; i++)
            {
                rounded[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{Convert.ToDecimal(numbers[i])} => {Convert.ToDecimal(rounded[i])}");
            }
        }
    }
}