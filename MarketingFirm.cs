using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class MarketingFirm
    {
        ISweepstakesManager _manager;

        public MarketingFirm(ISweepstakesManager manager)
        {

        }
        
        public void CreateSweepstake()
        {
            _manager.InsertSweepstakes(new Sweepstakes(UserInterface.EnterSweepstakeName()));
        }
    }
}
