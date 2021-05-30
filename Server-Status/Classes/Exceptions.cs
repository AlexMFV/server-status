using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Status
{
    public class Exceptions
    {
        /*public class InvalidSteamID : Exception
        {
            public InvalidSteamID() : base(String.Format("The entered SteamID64 is invalid," +
                " please enter a new one and try again!"))
            { }

            public InvalidSteamID(string SteamID) : base(String.Format("\"" + SteamID + "\" is not a invalid SteamID64," +
                " please enter a new one and try again!"))
            { }
        }*/

        public class InvalidURLException : Exception
        {
            public InvalidURLException() : base(String.Format("The entered URL is not valid," +
                " please enter a new one and try again!"))
            { }
        }
    }
}
