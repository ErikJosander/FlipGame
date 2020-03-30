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
        public static int wherePointerIs = 5;
        public static void MovePointer()
        {
            Console.Clear();
            board.ShowBoard(wherePointerIs);
            bool insideRunning = true;
            char x = 'p';
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
        }
        public static void ShowBoard()
        {
            bool showBoardRunning = true;
            while (showBoardRunning)
            {
                board.ShowBoard(wherePointerIs);
            }
        }
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                MovePointer();
            }
            Console.ReadLine();
        }
    }
}

