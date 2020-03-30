using System;
using System.Linq;
using FlipGameDataBase.Models;
using FlipGameDataBase.Data;


namespace FlipGame
{
    class Program
    {
        public static Board board = new Board();
        public static bool pointerRunning = true;
        public static bool playerTurnEnded = false;
        public static bool firstTurn = true;
        public static void MovePointer(Player player)
        {
            while (pointerRunning)
            {
                Console.Clear();
                ShowBoard(player);

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
                        firstTurn = false;

                        if (board.endThisTurn == true)
                        {
                            pointerRunning = false;
                        }
                        break;
                }
            }
        }
        public static void ShowBoard(Player player)
        {
            Console.WriteLine($"{player.Name} rolled {board.firstRoll} and {board.secondRoll}");
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
            board = new Board();
            bool running = true;
            while (running)
            {
                ResetAfterThrow();
                Console.Clear();
                Console.WriteLine("Press enter to roll dices");
                Console.ReadLine();
                board.RollDices();
                board.CalculateOptions();
                if (board.numbersToChooseFrom.Count() == 0 && firstTurn == true)
                {
                    playerTurnEnded = true;
                    pointerRunning = false;
                    Console.Clear();
                    ShowBoard(player);
                    board.CalculateValue(player);
                    Console.WriteLine();
                    Console.WriteLine($"{player.Name} scored: {player.Score}");
                    Console.ReadLine();
                    running = false;
                }
                MovePointer(player);
            }
        }
        public static void ResetAfterThrow()
        {
            pointerRunning = true;
            board.endThisTurn = false;
            board.oneNumberChoosen = false;
            firstTurn = true;
        }
        static void Main(string[] args)
        {
            bool mainRunning = true;
            while (mainRunning)
            {
                Console.WriteLine("play game(1)");
                Console.WriteLine("create player(2)");
                Console.WriteLine("view players(3)");
                var input = Helper.ReadIntInput(3);

                switch (input)
                {
                    case (1):
                        PlayGame();
                        break;
                    case (2):
                        CreatePlayer();
                        break;
                    case (3):
                        ShowListOfPlayer();
                        break;
                }
            }
            Console.ReadLine();
        }
        public static void CreatePlayer()
        {
            var player_username = Helper.ReadInput("Enter your user_name: ", true);
            Person newPerson = new Person() { Name = player_username, CreatedOn = DateTime.Now };
            if (Repository.SearchForPerson(player_username))
            {
                Console.WriteLine("Name allready exist");
            }
            else
            {
                Console.WriteLine("Person Created");
                Repository.AddPerson(newPerson);
            }

        }
        public static void ShowListOfPlayer()
        {
            var list = Repository.GetListOfPersons();
            foreach(var person in list)
            {
                Console.WriteLine($"{person.Name}");
            }
            Console.ReadLine();
        }
        public static void PlayGame()
        {

        }
    }
}

