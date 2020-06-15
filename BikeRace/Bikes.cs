using System;
using System.Windows.Forms;
using System.Drawing;

namespace BikeRace
{
    public class Bikes {
        private static int StartingPosition;
        private static int BikeRacetrackLength;
        public PictureBox BikesPictureBox = null;
        public int Location = 0;
        public static Random MyRandom = new Random(); //declared random object as static to avoid same random number

        public static int StartingPosition1 { get => StartingPosition; set => StartingPosition = value; }
        public static int BikeRacetrackLength1 { get => BikeRacetrackLength; set => BikeRacetrackLength = value; }

        // generation across all Bikes objects

        public static bool Run(Bikes obj) {
            int distance = MyRandom.Next(2, 6);
            if (obj.BikesPictureBox != null)
            obj.MoveBikesPictureBox(distance);

            obj.Location += distance;
            if (obj.Location >= (BikeRacetrackLength1 - StartingPosition1)) {
                return true;
            }
            return false;
        }

        public void TakeStartingPosition() {
            MoveBikesPictureBox(-Location); //reset location to -ve distance ie. to starting point
            Location = 0;

        }

        public void MoveBikesPictureBox(int distance) {
            Point p = BikesPictureBox.Location;
            p.X += distance;
            BikesPictureBox.Location = p; //move Bikes in x-axis
        }
    }
}
