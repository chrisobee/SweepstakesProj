using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class Contestant
    {
        public string firstName;
        public string lastName;
        public string email;
        public int registrationNum;

        public Contestant()
        {
            Validate email = new Validate();
            firstName = UserInterface.EnterFirstName();
            lastName = UserInterface.EnterLastName();
            this.email = email.CheckForValidEmail();
        }
    }
}
