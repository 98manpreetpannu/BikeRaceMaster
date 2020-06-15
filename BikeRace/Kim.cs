using System.Windows.Forms;

namespace BikeRace
{
    using System;

    public class Kim : BikeRacer
    {
        public Kim(Bet MyBet, Label MaximumBet, int Cash, Label MyLabel) : base(MyBet, MaximumBet, Cash, MyLabel)
        {
        }

        public override void setBikeRacerName()
        {
            Name = "Kim";
        }
    }
}