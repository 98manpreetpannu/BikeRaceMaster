using System.Windows.Forms;

namespace BikeRace
{
    public class Tom : BikeRacer
    {
        public Tom(Bet bet, Label MaximumBet, int Cash, Label label) : base(bet, MaximumBet, Cash, label)
        {
        }

        public override void setBikeRacerName()
        {
            Name = "Tom";
        }
    }
}