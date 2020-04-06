using System;
using System.Collections.Generic;
using System.Text;

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
            contestants.Add(contestant.registrationNum, new Contestant());
            numOfContestants++;
        }

        
        public Contestant PickWinner()
        {
            int randNumber;
            randNumber = rand.Next(numOfContestants);
            return contestants[randNumber];
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"The Contestant's name: {contestant.firstName} {contestant.lastName}");
            Console.WriteLine($"The Contestant's email: {contestant.email}");
            Console.WriteLine($"The Contestant's registration number: {contestant.registrationNum}");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
