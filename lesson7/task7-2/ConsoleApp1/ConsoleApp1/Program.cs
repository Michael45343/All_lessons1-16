

using System;

class TicTacToe
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static char currentPlayer = 'X';

    static void Main()
    {
        bool gameRunning = true;

        while (gameRunning)
        {
            Console.Clear();
            PrintBoard();

            Console.Write($"Player {currentPlayer}, choose a cell (1-9): ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int choice) || choice < 1 || choice > 9)
            {
                Console.WriteLine("Invalid input! Press Enter...");
                Console.ReadLine();
                continue;
            }

            if (board[choice - 1] == 'X' || board[choice - 1] == 'O')
            {
                Console.WriteLine("Cell already taken! Press Enter...");
                Console.ReadLine();
                continue;
            }

            board[choice - 1] = currentPlayer;

            if (CheckWin())
            {
                Console.Clear();
                PrintBoard();
                Console.WriteLine($"Player {currentPlayer} wins!");
                break;
            }

            if (CheckDraw())
            {
                Console.Clear();
                PrintBoard();
                Console.WriteLine("Draw!");
                break;
            }

            SwitchPlayer();
        }
    }

    // functions

    static void PrintBoard()
    {
        Console.WriteLine();
        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
        Console.WriteLine();
    }

    static bool CheckWin()
    {
        int[,] winCombinations =
        {
            {0,1,2}, {3,4,5}, {6,7,8}, // rows
            {0,3,6}, {1,4,7}, {2,5,8}, // columns
            {0,4,8}, {2,4,6}           // diagonals
        };

        for (int i = 0; i < winCombinations.GetLength(0); i++)
        {
            if (board[winCombinations[i, 0]] == currentPlayer &&
                board[winCombinations[i, 1]] == currentPlayer &&
                board[winCombinations[i, 2]] == currentPlayer)
            {
                return true;
            }
        }
        return false;
    }

    static bool CheckDraw()
    {
        foreach (char c in board)
        {
            if (c != 'X' && c != 'O')
                return false;
        }
        return true;
    }

    static void SwitchPlayer()
    {
        currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
    }
}

