using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class ValidEmail
    {
        public string symbol;
        public string[] topLevelDomain;

        public ValidEmail()
        {
            symbol = "@";
            topLevelDomain = new string[] { ".com", ".net", ".org" };
        }
    }
}
