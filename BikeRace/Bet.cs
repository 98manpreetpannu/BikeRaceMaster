using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BikeRace
{
    public class Bet {
        public int Amount;
        public int bikeNum;
        public BikeRacer Bettor;

        public Bet(int Amount, int bikeNum, BikeRacer Bettor) {
            this.Amount = Amount;
            this.bikeNum = bikeNum;
            this.Bettor = Bettor;
        }

        public string GetDescription() {
            string description = "";

            if(Amount > 0) {
                description = String.Format("{0} bets {1} on Bike #{2}",
                    Bettor.Name, Amount, bikeNum);
            } else {
                description = String.Format("{0} hasn't placed any bets", 
                    Bettor.Name);
            }
            return description;
        }

        public int Pay(int Winner) {
            if (bikeNum == Winner) {
                return Amount;
            }
            return -Amount;
        }
    }
}
