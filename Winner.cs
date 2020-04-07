using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class Winner:Contestant
    {
        public override void Notify()
        {
            Console.WriteLine("You have won the Sweepstakes!!!");
            Console.ReadLine();
        }
    }
}
