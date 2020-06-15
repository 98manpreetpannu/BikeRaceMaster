using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BikeRace;
namespace BikeRaceUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        BikeRacerFactory pFactory = new BikeRacerFactory();
        BikeRacer Tom;
        Bikes[] Bikess = new Bikes[2];
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void TestWinnerOutcome()
        {
            Bikes.StartingPosition1 = 0;
            Bikes.BikeRacetrackLength1 = 50;
            int BikeRacerAmount = 45;
            int BikesNumber = 2;
            int expectedWin = 90;
            int expectedLose = 0;
            Bikess[0] = new Bikes() { BikesPictureBox = null };
            Bikess[1] = new Bikes() { BikesPictureBox = null };
            Tom = pFactory.getBikeRacer("Tom", null, null);
            Tom.Cash = BikeRacerAmount;
            Tom.PlaceBet((int)BikeRacerAmount, BikesNumber);

            bool nowin = true;
            int win = -1;
            while (nowin)
            {
                for (int i = 0; i < Bikess.Length; i++)
                {
                    if (Bikes.Run(Bikess[i]))
                    {
                        win = i + 1;
                        Tom.Collect(win);
                        nowin = false;

                    }
                }
            }
            if (Tom.bet.bikeNum == win)
            {
                Assert.AreEqual(expectedWin, Tom.Cash, "Account doesn't credited ");
            }
            if (Tom.bet.bikeNum != win)
            {
                Assert.AreEqual(expectedLose, Tom.Cash, "Account doesn't debited ");

            }
        }
    }

}
