using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    static class Converter
    {
        public static Winner ConvertContestantToWinner(Contestant contestant)
        {
            Winner winner = new Winner();

            winner.FirstName = contestant.FirstName;
            winner.LastName = contestant.LastName;
            winner.Email = contestant.Email;
            winner.RegistrationNum = contestant.RegistrationNum;

            return winner;
        }
    }
}
