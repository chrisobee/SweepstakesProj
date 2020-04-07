using System;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulation sim = new Simulation();

            sim.CreateMarketingFirmWithManager();
            sim.SendEmail();
        }
    }
}
