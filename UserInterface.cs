using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    public static class UserInterface
    {
        public static string EnterFirstName()
        {
            bool incorrectInput = false;
            string userInput = string.Empty;
            while (!incorrectInput)
            {
                Console.WriteLine("Type in the contestant's first name");
                userInput = Console.ReadLine();

                if (Int32.TryParse(userInput, out int result))
                {
                    Console.WriteLine("Invalid Input");
                    incorrectInput = true;
                }
                else
                {
                    incorrectInput = false;
                }
            }
            return userInput;
        }

        public static string EnterLastName()
        {
            bool incorrectInput = false;
            string userInput = string.Empty;
            while (!incorrectInput)
            {
                Console.WriteLine("Type in the contestant's last name");
                userInput = Console.ReadLine();

                if (Int32.TryParse(userInput, out int result))
                {
                    Console.WriteLine("Invalid Input");
                    incorrectInput = true;
                }
                else
                {
                    incorrectInput = false;
                }
            }
            return userInput;
        }
    }
}
