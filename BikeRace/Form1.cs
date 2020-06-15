using System;
using System.Windows.Forms;

namespace BikeRace {
    public partial class Form1 : Form {
        Bikes[] Bikess = new Bikes[4];

        BikeRacerFactory pFactory = new BikeRacerFactory();
        BikeRacer[] BikeRacers = new BikeRacer[3];

        public Form1() {
            InitializeComponent();
            SetupBikeRaceTrack();
        }

        private void SetupBikeRaceTrack() {
            
            Bikes.StartingPosition1 = Bike1.Right - BikeRacetrack.Left; 
            Bikes.BikeRacetrackLength1 = BikeRacetrack.Size.Width - 70 ; //fixing length of BikeRace - till finish line
                
            Bikess[0] = new Bikes() { BikesPictureBox = Bike1};
            Bikess[1] = new Bikes() { BikesPictureBox = Bike2};
            Bikess[2] = new Bikes() { BikesPictureBox = Bike3};
            Bikess[3] = new Bikes() { BikesPictureBox = Bike4};

            BikeRacers[0] = pFactory.getBikeRacer("Kim",MaximumBet,KimBet); //getting Kim object from factory class
            BikeRacers[1] = pFactory.getBikeRacer("Barry", MaximumBet, BarryBet); //getting Barry object from factory class
            BikeRacers[2] = pFactory.getBikeRacer("Tom", MaximumBet, TomBet); //getting Tom object from factory class


            foreach (BikeRacer BikeRacer in BikeRacers) {
                BikeRacer.UpdateLabels();
            }
        }

        private void KimButton_CheckedChanged(object sender, EventArgs e) {
            setMaximumBetTextLabel(BikeRacers[0].Cash);
        }

        private void BarryButton_CheckedChanged(object sender, EventArgs e) {
            setMaximumBetTextLabel(BikeRacers[1].Cash);
        }

        private void TomButton_CheckedChanged(object sender, EventArgs e) {
            setMaximumBetTextLabel(BikeRacers[2].Cash);
        }

        private void setMaximumBetTextLabel(int Cash) {
            MaximumBet.Text= String.Format("Maximum Bet: ${0}", Cash);
        }

        // setting the bet for each BikeRacer and updating labels respectively
        private void Bets_Click(object sender, EventArgs e) {
            int BikeRacerNum = 0;

            if (KimButton.Checked) {
                BikeRacerNum = 0;
            }
            if (BarryRButton.Checked) {
                BikeRacerNum = 1;
            }
            if (TomRButton.Checked) {
                BikeRacerNum = 2;
            }

            BikeRacers[BikeRacerNum].PlaceBet((int)BikeRacerAmount.Value, (int)BikesNumber.Value);
            BikeRacers[BikeRacerNum].UpdateLabels();
        }

        private void BikeRace_Click(object sender, EventArgs e) {
            bool NoWinner = true;
            int winningBikes;
            BikeRace.Enabled = false; //disable start BikeRace button

            while (NoWinner) { // loop until we have a winner
                Application.DoEvents();
                for (int i = 0; i < Bikess.Length; i++ ) {
                    if (Bikes.Run(Bikess[i])) { 
                        winningBikes = i + 1;
                        NoWinner = false;
                        MessageBox.Show("winner of the BikeRace is - Bikes #" + winningBikes);
                        foreach (BikeRacer BikeRacer in BikeRacers) {
                            if (BikeRacer.bet != null) {
                                BikeRacer.Collect(winningBikes); //give double amount to all who've won or deduce betted amount
                                BikeRacer.bet = null; 
                                BikeRacer.UpdateLabels();
                            }
                        }
                        foreach (Bikes Bikes in Bikess) {
                            Bikes.TakeStartingPosition();
                        }
                        break;
                    }                    
                }                
            }
            if (BikeRacers[0].busted && BikeRacers[1].busted && BikeRacers[2].busted){  //stop BikeRacers from betting if they run out of cash
                String message = "Do you want to Play Again?";
                String title = "GAME OVER!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes) {
                    SetupBikeRaceTrack(); //restart game
                }
                else {
                    this.Close();  
                }

            }
            BikeRace.Enabled = true; //enable BikeRace button 
        }

        private void BikeRacetrack_Click(object sender, EventArgs e)
        {

        }

        private void BikeRacerAmount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MaximumBet_Click(object sender, EventArgs e)
        {

        }

        private void BikesNumber_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
