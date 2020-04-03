using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class Validate
    {
        ValidEmail email = new ValidEmail();
        bool emailNameExists;
        bool domainNameExists;
        public string CheckForValidEmail()
        {
            string userInput;
            bool validEmail;
            Console.WriteLine("Type in an email address");
            userInput = Console.ReadLine();
            do
            {
                if (CheckForSymbol(userInput) && CheckForTopLevelDomain(userInput) && CheckForSpacesInUserInput(userInput))
                {
                    string[] splitString = userInput.Split(email.symbol, 2);
                    CheckForEmailName(splitString);
                    CheckForDomainName(splitString);
                    if (emailNameExists && domainNameExists)
                    {
                        return userInput;
                    }
                    else
                    {
                        validEmail = false;
                        Console.WriteLine("Invalid Email");
                    }
                }
                else
                {
                    validEmail = false;
                    Console.WriteLine("Invalid Email");
                }
            }
            while (validEmail == false);
            return userInput;
        }

        public bool CheckForSpacesInUserInput(string userInput)
        {
            bool noSpaces = true;
            foreach (char character in userInput)
            {
                if (character == ' ')
                {
                    noSpaces = false;
                    return noSpaces;
                }
            }
            return noSpaces;
        }

        public bool CheckForSymbol(string userInput)
        {
            bool containsSymbol;
            if (userInput.Contains(email.symbol))
            {
                containsSymbol = true;
                return containsSymbol;
            }
            else
            {
                containsSymbol = false;
                return containsSymbol;
            }
        }

        public bool CheckForTopLevelDomain(string userInput)
        {
            bool containsTopLevelDomain = false;
            foreach (string stringCheck in email.topLevelDomain)
            {
                if (userInput.Contains(stringCheck))
                {
                    containsTopLevelDomain = true;
                    return containsTopLevelDomain;
                }
            }
            return containsTopLevelDomain;
        }

        public void CheckForEmailName(string[] splitString)
        {
            if (splitString[0] != string.Empty)
            {
                emailNameExists = true;
            }
            else
            {
                emailNameExists = false;
            }
        }

        public bool CheckForDomainName(string[] splitString)
        {
            domainNameExists = true;
            foreach (string stringCheck in email.topLevelDomain)
            {
                if (splitString[1] == stringCheck)
                {
                    domainNameExists = false;
                    return domainNameExists;
                }
            }
            return domainNameExists;
        }
    }
}
