using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipGame
{
    class Program
    {
        public static Board board = new Board();
        public static bool pointerRunning = true;
        public static void MovePointer(Player player)
        {      
            while (pointerRunning)
            {                
                Console.Clear();
                ShowBoard();
                bool insideRunning = true;
                char x = 'a';
                while (insideRunning)
                {
                    x = Console.ReadKey(true).KeyChar;
                    if (x == 'a' || x == 'd' || x == 'o')
                    { insideRunning = false; }
                }
                switch (x)
                {
                    // Move Left
                    case ('a'):
                        board.PointerAction("a");
                        break;
                    // Move Right
                    case ('d'):
                        board.PointerAction("d");
                        break;
                    // Press Action Button
                    case ('o'):
                        board.PointerAction("o");
                        break;
                }
                if (board.endThisTurn == true)
                {
                    pointerRunning = false;
                }
                if (board.firstChoice == 0 && board.numbersToChooseFrom.Count() == 0)
                {
                    board.CalculateValue(player);
                }
            }
        }
        public static void ShowBoard()
        {
            Console.WriteLine($"You rolled {board.firstRoll} and {board.secondRoll}");
            for (int i = 1; i <= 9; i++)
            {
                if (board.boardNumbers.Contains(i) && i != board.wherePointerIs && !board.numbersToChooseFrom.Contains(i))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(i);
                    Console.Write(" ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (board.usedNumbers.Contains(i) && i != board.wherePointerIs && !board.numbersToChooseFrom.Contains(i))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(i);
                    Console.Write(" ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (board.numbersToChooseFrom.Contains(i) && i != board.wherePointerIs)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(i);
                    Console.Write(" ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (i == board.wherePointerIs)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(i);
                    Console.Write(" ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        public static void StartGame(Player player)
        {
            
        }
        public static void ResetAfterThrow()
        {
            pointerRunning = true;
            board.endThisTurn = false;
            board.oneNumberChoosen = false;
        }
        static void Main(string[] args)
        {
            Player erik = new Player() { Name = "erik", Score = 0 };
            bool running = true;
            while (running)
            {

                ResetAfterThrow();
                Console.Clear();
                Console.WriteLine("Press enter to roll dices");
                Console.ReadLine();
                               
                board.RollDices();               
                board.CalculateOptions();            
                MovePointer(erik);
            }
            Console.ReadLine();
        }
    }
}

