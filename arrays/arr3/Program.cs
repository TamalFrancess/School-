namespace arr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries) 
                .ToArray();


            Console.WriteLine(string.Join(" ", input.Reverse()));
        }
    }
}