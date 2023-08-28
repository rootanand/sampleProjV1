using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeV1
{
    class Program
    {
        //Declare and Initialize the TicTacToe Board as a 1D char array with 9 elements
        static char[] board = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static void Main(string[] args)
        {
            PrintBoard();
        }

        public static void PrintBoard()
        {
            //Logic to display a 1D char array of size 9 as a 3 x 3 - 2D Board on screen
            Console.WriteLine("Tic Tac Toe Board\n");
            for (int i = 0; i < board.Length; i++)
            {
                Console.Write(board[i] + "\t");
                if (i % 3 == 2)
                {
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
