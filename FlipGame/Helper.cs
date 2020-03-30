using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipGame
{
    public class Helper
    {
        /// <summary>
        /// Reads user input from the console.
        /// </summary>
        /// <param name="prompt">The user prompt.</param>
        /// <param name="forceToLowercase">Whether or not to force the user's provided input to lowercase text.</param>
        /// <returns>A user's provided input as a string.</returns>
        public static string ReadInput(string prompt, bool forceToLowercase = false)
        {
            Console.WriteLine();
            Console.Write(prompt);
            string input = Console.ReadLine();
            return forceToLowercase ? input.ToLower() : input;
        }

        /// <summary>
        /// Reads user input from the console.
        /// </summary>
        /// <param name="prompt">The user prompt.</param>
        /// <param name="forceToLowercase">Whether or not to force the user's provided input to lowercase text.</param>
        /// <returns>A user's provided input as a string.</returns>
        public static int ReadIntInput(int range)
        {
            int toReturn = 0;
            bool running = true;
            while (running)
            {
                int input;
                var isInt = int.TryParse(Console.ReadLine(), out input);
                if (!isInt)
                {
                    Console.WriteLine("Error: Not an int");
                    continue;
                }
                if (input < 0 || input > range)
                {
                    Console.WriteLine("Error: out of range");
                    continue;
                }
                if (isInt)
                {
                    toReturn = input;
                    return toReturn;
                }
            }
            return toReturn;
        }
    }
}
