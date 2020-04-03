using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> contestants;
        private string name;
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
            contestants = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.registrationNum, new Contestant());
        }

        public Contestant PickWinner()
        {

        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
