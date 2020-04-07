using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class Contestant:INotifiable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int RegistrationNum { get; set; }
        public bool IsWinner { get; set; }
        public Contestant()
        {
            Validate email = new Validate();
            FirstName = UserInterface.EnterFirstName();
            LastName = UserInterface.EnterLastName();
            Email = email.CheckForValidEmail();
        }

        public virtual void Notify()
        {
            Console.WriteLine($"Unfortunately, you did not win the Sweepstakes");
            Console.ReadLine();
        }
    }
}
