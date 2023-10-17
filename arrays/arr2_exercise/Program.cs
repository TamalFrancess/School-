namespace arr2_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


                if(i % 2 == 0)
                {
                    secondArr[i-1] = arr[0];
                    firstArr[i-1] = arr[1];
                }
                else
                {
                    secondArr[i - 1] = arr[1];
                    firstArr[i - 1] = arr[0];
                }
            }
            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}