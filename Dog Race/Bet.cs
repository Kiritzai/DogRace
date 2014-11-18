using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_Race
{
    class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor; // The guy who placed the bet

        public string GetDescription()
        {
            if (Amount <= 0)
            {
                return Bettor.Name + " has not placed a bet";
            }
            else
            {
                return Bettor.Name + " bets " + Amount + " bucks on dog #" + Dog;
            }
        }

        public int PayOut(int Winner)
        {
            return 0;
        }
    }
}
