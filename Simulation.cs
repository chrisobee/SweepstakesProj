using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            MarketingFirm firm = new MarketingFirm(ManagerFactory.ChooseManager());
        }
    }
}
