using System;
using System.Linq;
using FlipGameDataBase.Models;
using FlipGameDataBase.Data;
using System.Collections.Generic;

namespace FlipGame
{
    class Program
    {
        public static Board board = new Board();
        public static bool pointerRunning = true;
        public static bool playerTurnEnded = false;
        public static bool firstTurn = true;
        public static int MenuScrollerIs = 0;
        public static List<Person> listOfPlayers = new List<Person>();
        public static void MovePointer(Player player)
        {
            while (pointerRunning)
            {
                Console.Clear();
                ShowBoard(player);

                bool insideRunning = true;
                ConsoleKey x = ConsoleKey.UpArrow;
                while (insideRunning)
                {
                    x = Console.ReadKey(true).Key;
                    if (x == ConsoleKey.LeftArrow || x == ConsoleKey.RightArrow || x == ConsoleKey.Enter)
                    { insideRunning = false; }
                }
                switch (x)
                {
                    // Move Left
                    case (ConsoleKey.LeftArrow):
                        board.PointerAction("a");
                        break;
                    // Move Right
                    case (ConsoleKey.RightArrow):
                        board.PointerAction("d");
                        break;
                    // Press Action Button
                    case (ConsoleKey.Enter):
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
            string player_username = "";
            bool corretInput = false;
            while (corretInput == false)
            {
                player_username = Helper.ReadInput("Enter your user_name: ", true);
                if (Helper.InputValidation(player_username))
                {
                    corretInput = true;
                }
                else
                {
                    Console.WriteLine("Not valid");
                }
            }

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
            foreach (var person in list)
            {
                Console.WriteLine($"{person.Name}");
            }
            Console.ReadLine();
        }
        public static void PlayGame()
        {
            Console.WriteLine("Enter numbers of players (1-4)");
            var numberOfPlayers = Helper.ReadIntInput(4);
            ChoosePlayerMenu(numberOfPlayers);
            foreach(var person in listOfPlayers)
            {
                Player newPlayer = new Player() { Name = person.Name, Score = 0 };
                Console.WriteLine($"{newPlayer.Name} turn");
                StartGame(newPlayer);
            }
            Console.Clear();
        }
        public static List<Person> ChoosePlayerMenu(int numberOfPlayers)
        {
            Console.Clear();            
            ShowMenu(ConsoleKey.UpArrow);
            var users = Repository.GetListOfPersons();
            bool menuRunning = true;
            while (menuRunning)
            {
                bool insideRunning = true;
                ConsoleKey ch = ConsoleKey.UpArrow;
                while (insideRunning)
                {
                    ch = Console.ReadKey(false).Key;
                    if (ch == ConsoleKey.DownArrow || ch == ConsoleKey.UpArrow || ch == ConsoleKey.Enter || ch == ConsoleKey.Q)
                    { insideRunning = false; }
                }
                switch (ch)
                {
                    case (ConsoleKey.UpArrow):
                        ShowMenu(ConsoleKey.UpArrow);
                        break;
                    case (ConsoleKey.DownArrow):
                        ShowMenu(ConsoleKey.DownArrow);
                        break;
                    case (ConsoleKey.Enter):
                        var person = users[MenuScrollerIs];
                        if (listOfPlayers.Contains(person))
                        {
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.WriteLine("Can't add that person again");
                            Console.WriteLine("Press enter to continue");
                            ShowMenu(ConsoleKey.Enter);
                            Console.ReadLine();
                        }
                        else
                        {
                            listOfPlayers.Add(person);
                        }
                        break;
                    case (ConsoleKey.Q):
                        menuRunning = false;
                        break;
                    default:
                        break;
                }
                if(listOfPlayers.Count == numberOfPlayers)
                {
                    menuRunning = false;
                }
            }
            Console.Clear();
            return listOfPlayers;
        }
        public static void ShowMenu(ConsoleKey consoleKey)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press Q to Quit");
            Console.WriteLine("Press Enter to Select User");
            Console.Write("Selected players: ");
            foreach (var person in listOfPlayers)
            {
                Console.Write($"{person.Name} ");
            }
            Console.WriteLine();
            var list = Repository.GetListOfPersons();
            int lengthOfScrolles = list.Count();
            if (consoleKey == ConsoleKey.DownArrow)
            {
                if (MenuScrollerIs + 1 > lengthOfScrolles)
                {

                }
                else
                {
                    MenuScrollerIs += 1;
                }
            }
            if (consoleKey == ConsoleKey.UpArrow)
            {
                if (MenuScrollerIs == 0)
                {

                }
                else
                {
                    MenuScrollerIs -= 1;
                }
            }

            for (int i = MenuScrollerIs; i < MenuScrollerIs + 10; i++)
            {
                bool playerTaken = false;
                foreach (var person in listOfPlayers)
                {
                    try
                    {
                        if ((person.Name) == list[i].Name)
                        {
                            playerTaken = true;
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {

                    }
                }
                if (playerTaken == true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(list[i].Name);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (i == MenuScrollerIs && playerTaken == false)
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(list[i].Name);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("");
                    }
                }
                else if (i + 1 == MenuScrollerIs || i - 1 == MenuScrollerIs)
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(list[i].Name);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("");
                    }
                }
                else if (i + 2 == MenuScrollerIs || i - 2 == MenuScrollerIs)
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(list[i].Name);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("");
                    }
                }
                else if (i + 3 == MenuScrollerIs || i - 3 == MenuScrollerIs)
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(list[i].Name);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("");
                    }
                }
                else
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine(list[i].Name);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("");
                    }
                }

            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}


