using System;
using System.Windows.Forms;

namespace BikeRace
{
    public class BikeRacerFactory
    {
        public BikeRacer getBikeRacer(String Name,Label MaximumBet, Label bet)
        {
            BikeRacer p;
            switch (Name.ToLower())
            {
                case "kim":
                     p = new Kim(null, MaximumBet, 50, bet);
                    break;
                   
                case "barry":
                    p =  new Barry(null, MaximumBet, 50, bet);
                    break;
                    
                case "tom":
                    p = new Tom(null, MaximumBet, 50, bet);
                    break;
                   
                default:
                    p =  null ;
                    break;
            }
            p.setBikeRacerName();
            return p;
        }
    }
}