namespace arr3_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                for(int j = array.Length - 1; j >= 0; j--)
                {
                    int t = array[array.Length - 1];
                    array[array.Length-1] = array[j];
                    array[j] = t;
                }
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}