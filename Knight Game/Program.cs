using System;


namespace Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] board = new char[n][];

            for (int i = 0; i < n; i++)
            {
                board[i] = Console.ReadLine().ToCharArray();
            }

            int removedKnights = 0;

            while (true)
            {
                int maxAttacks = 0;
                int maxAttackerRow = -1;
                int maxAttackerCol = -1;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (board[row][col] == 'K')
                        {
                            int currentAttacks = CountAttacks(board, row, col);

                            if (currentAttacks > maxAttacks)
                            {
                                maxAttacks = currentAttacks;
                                maxAttackerRow = row;
                                maxAttackerCol = col;
                            }
                        }
                    }
                }
                if (maxAttacks == 0)
                {
                    break;
                }
                board[maxAttackerRow][maxAttackerCol] = '0';
                removedKnights++;
            }
            Console.WriteLine(removedKnights);
        }
        static int CountAttacks(char[][] board, int row, int col)
        {
            int attacks = 0;

             int[] rowMoves = { -2, -1, 1, 2, 2, 1, -1, -2 };
             int[] colMoves = { 1, 2, 2, 1, -1, -2, -2, -1 };

            for (int i = 0; i < 8; i++)
            {
                int newRow = row + rowMoves[i];
                int newCol = col + colMoves[i];

                if (ValidPosition(board, newRow, newCol) && board[newRow][newCol] == 'K')
                {
                    attacks++;
                }
            }
            return attacks;
        }
        static bool ValidPosition(char[][] board, int row, int col)
        {
            return row >= 0 && row < board.Length && col >= 0 && col < board[row].Length;
        }
    }
}
