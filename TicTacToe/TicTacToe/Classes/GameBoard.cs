using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Classes
{
    class GameBoard
    {
        public string[][] Board { get; set; }
        public string[][] Picked { get; set; }
        public string[][] defaultBoard = new string[][]
            {
                new string[] {"1","2","3"},
                new string[] {"4","5","6"},
                new string[] {"7","8","9"}
            };
        public string[][] defaultPick = new string[][]
        {
            new string[3],
            new string[3],
            new string[3]
        };
        public GameBoard()
        {
            Board = defaultBoard;
            Picked = defaultPick;
        }
        public bool DisplayGameBoard(string[][] board)
        {
            if (board.Length !=3){return false;}
            try
            {
                Console.WriteLine("Current game:");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Board could not be made: {e.Message}");
                return false;
            }

        }
    }
}
