using Hanishka_Final;
using System;

namespace Hanishka_Final
{
    class ComputerPlayer : Player
    {
        private readonly Random random;
        private readonly char[,] board;

        public ComputerPlayer(char symbol, char[,] gameBoard) : base(symbol)
        {
            random = new Random();
            board = gameBoard;
        }

        public override int GetMove()
        {
            int column;
            while (true)
            {
                column = random.Next(0, 7);
                if (IsValidMove(column))
                {
                    return column;
                }
            }
        }

        private bool IsValidMove(int column)
        {
            // Check if the column is valid and not full
            for (int row = 0; row < 6; row++)
            {
                if (board[row, column] == ' ')
                {
                    return true;
                }
            }

            return false;
        }
    }
}
