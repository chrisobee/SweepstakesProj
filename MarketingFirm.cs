using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class MarketingFirm
    {
        ISweepstakesManager _manager;
        public string Name { get; set; } = "The Boys";
        public string Email { get; set; } = "chrisobee2000@gmail.com";

        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
        }
        
        public void CreateSweepstake()
        {
            _manager.InsertSweepstakes(new Sweepstakes(UserInterface.EnterSweepstakeName()));
        }
    }
}
