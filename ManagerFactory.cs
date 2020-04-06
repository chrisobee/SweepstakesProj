using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    static class ManagerFactory
    {
        public static ISweepstakesManager ChooseManager()
        {
            string userInput;
            ISweepstakesManager manager = null;
            Console.WriteLine("Choose which style of sweepstakes manager you would like to use\nChoose Queue or Stack");
            userInput = Console.ReadLine().ToLower();
            switch (userInput)
            {
                case "queue":
                    manager = new SweepstakesQueueManager();
                    return manager;
                case "stack":
                    manager = new SweepstakesStackManager();
                    return manager;
                default:
                    return ChooseManager();
            }
        }
    }
}
