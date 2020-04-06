using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    public static class UserInterface
    {
        public static string EnterFirstName()
        {
            bool correctInput = false;
            string userInput = string.Empty;
            while (!correctInput)
            {
                Console.WriteLine("Type in the contestant's first name");
                userInput = Console.ReadLine();

                if (Int32.TryParse(userInput, out int result))
                {
                    Console.WriteLine("Invalid Input");
                    correctInput = false;
                }
                else
                {
                    correctInput = true;
                }
            }
            return userInput;
        }

        public static string EnterLastName()
        {
            bool correctInput = false;
            string userInput = string.Empty;
            while (!correctInput)
            {
                Console.WriteLine("Type in the contestant's last name");
                userInput = Console.ReadLine();

                if (Int32.TryParse(userInput, out int result))
                {
                    Console.WriteLine("Invalid Input");
                    correctInput = false;
                }
                else
                {
                    correctInput = true;
                }
            }
            return userInput;
        }

        public static string EnterSweepstakeName()
        {
            bool correctInput = false;
            string userInput = string.Empty;
            while (!correctInput)
            {
                Console.WriteLine("Type in the name of the Sweepstake");
                userInput = Console.ReadLine();

                if (userInput == string.Empty)
                {
                    Console.WriteLine("Invalid Input");
                    correctInput = false;
                }
                else
                {
                    correctInput = true;
                }
            }
            return userInput;
        }
    }
}
