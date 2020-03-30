using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipGame
{
    public class Board
    {
        public List<int> boardNumbers = new List<int>();
        public List<int> usedNumbers = new List<int>();
        public List<int> numbersToChooseFrom = new List<int>();
        public Random rnd = new Random();
        public int wherePointerIs = 5;
        public bool oneNumberChoosen = false;
        public int firstChoice = 0;
        public int firstRoll;
        public int secondRoll;
        public int totalRoll = 0;
        public bool endThisTurn = false;
        public Board()
        {
            for (int i = 1; i <= 9; i++)
            {
                boardNumbers.Add(i);
            }
        }
        public void PointerAction(string input)
        {
            switch (input)
            {
                case ("a"):
                    if (wherePointerIs > 1)
                    {
                        wherePointerIs -= 1;
                    }
                    break;
                case ("d"):
                    if (wherePointerIs < 9)
                    {
                        wherePointerIs += 1;
                    }
                    break;
                case ("o"):
                    if (numbersToChooseFrom.Contains(wherePointerIs))
                    {                       
                        firstChoice = wherePointerIs;
                        AddNumberToUsedNunber(wherePointerIs);
                        oneNumberChoosen = true;
                        CalculateOptions();
                        if(numbersToChooseFrom.Count() == 0)
                        {
                            endThisTurn = true;
                        }
                    }
                    break;
            }
        }
        public void AddNumberToUsedNunber(int numberInput)
        {
            boardNumbers.Remove(numberInput);
            usedNumbers.Add(numberInput);
        }
        public void CalculateOptions()
        {
            numbersToChooseFrom.Clear();
            if (oneNumberChoosen == true)
            {
                totalRoll = (totalRoll - firstChoice);
            }
            foreach (var x in boardNumbers)
            {
                if (x == totalRoll)
                {
                    numbersToChooseFrom.Add(x);
                }
            }

            foreach (var x in boardNumbers)
            {
                foreach (var y in boardNumbers)
                {
                    if (x + y == totalRoll && x != y)
                    {
                        numbersToChooseFrom.Add(x);
                        numbersToChooseFrom.Add(y);
                    }
                    foreach (var z in boardNumbers)
                    {
                        if (x + y + z == totalRoll && x != y && x != z && y != z)
                        {
                            numbersToChooseFrom.Add(x);
                            numbersToChooseFrom.Add(y);
                            numbersToChooseFrom.Add(z);
                        }
                    }
                }
            }
            numbersToChooseFrom = numbersToChooseFrom.Distinct().ToList();
        }
        public void RollDices()
        {
            firstRoll = rnd.Next(1, 7);
            secondRoll = rnd.Next(1, 7);
            totalRoll = (firstRoll + secondRoll);
        }       
        public void CalculateValue(Player player)
        {
            int sum = 0;
            foreach(var numbers in boardNumbers)
            {
                sum += numbers;
            }
            player.Score += sum;
        }
    }
}
