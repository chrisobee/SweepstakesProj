using System;
using System.Collections.Generic;
using System.Text;
using MailKit;
using MimeKit;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Random rand = new Random();
        Dictionary<int, Contestant> contestants;
        private string name;
        private int numOfContestants;
        public int NumOfContestests
        {
            get
            {
                return numOfContestants;
            }
            set
            {
                numOfContestants = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Sweepstakes(string name)
        {
            Name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {
            int newNum = contestants.Count + 1;
            contestants.Add(newNum, contestant);
            contestant.RegistrationNum = newNum;
            numOfContestants++;
        }
        
        public Winner PickWinner()
        {
            int randNumber;
            randNumber = rand.Next(numOfContestants);
            contestants[randNumber].IsWinner = true;
            Winner winner = Converter.ConvertContestantToWinner(contestants[randNumber]);
            return winner;
        }

        public void NotifyContestants(Winner winner)
        {
            foreach(KeyValuePair<int,Contestant> pair in contestants)
            {
                if(pair.Value.IsWinner == true)
                {
                    winner.Notify();
                }
                else
                {

                }
            }
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"The Contestant's name: {contestant.FirstName} {contestant.LastName}");
            Console.WriteLine($"The Contestant's email: {contestant.Email}");
            Console.WriteLine($"The Contestant's registration number: {contestant.RegistrationNum}");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
