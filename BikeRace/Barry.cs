using System.Windows.Forms;


namespace BikeRace
{
    using System;

    public class Barry : BikeRacer
    {
        public Barry(Bet bet, Label MaximumBet, int Cash, Label label) : base(bet, MaximumBet, Cash, label)
        {
        }

        public override void setBikeRacerName()
        {
            Name = "Barry";
        }
    }
}