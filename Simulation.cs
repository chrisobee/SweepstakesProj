using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class Simulation
    {
        MarketingFirm firm; 

        public void CreateMarketingFirmWithManager()
        {
            firm = new MarketingFirm(ManagerFactory.ChooseManager());
        }

        public void SendEmail()
        {
            EmailAPI email = new EmailAPI(firm.Name, firm.Email);
            email.SendEmailToLoser();
        }

    }
}
