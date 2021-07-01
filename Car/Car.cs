using System;

namespace CarNS
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int GasTankSize { get; set; }
        public double GasTankLevel { get; set; }
        public double MilesPerGallon { get; set; }
        public double Odometer { get; set; } = 0;
        public double Miles { get; set; }

        public Car(string make, string model, int gasTankSize, double milesPerGallon)
        {
            Make = make;
            Model = model;
            this.GasTankSize = gasTankSize;
            // Gas tank level defaults to a full tank
            this.GasTankLevel = gasTankSize;
            this.MilesPerGallon = milesPerGallon;
        }

        /**
         * Drive the car an amount of miles. If not enough fuel, drive as far as fuel allows.
         * Adjust fuel levels based on amount needed to drive the distance requested.
         * Add miles to odometer.
         */
        public void Drive(double miles)
        {
            this.Miles = miles;
            //adjust fuel based on mpg and miles requested to drive

            double maxDistance = this.MilesPerGallon * this.GasTankLevel;
            //double milesAbleToTravel = miles > maxDistance ? maxDistance : miles;

            if (this.Miles <= maxDistance)
                {
                this.GasTankLevel = this.GasTankLevel - (this.Miles / this.MilesPerGallon);
                this.Odometer = this.Odometer + miles;
                }


            ///**the double below uses some syntax called the ternary operator.
            //    * if the value of miles is greater than the value of maxDistance,
            //    * then milesAbleToTravel = maxDistance.
            //    * otherwise, if miles is not greater than maxDistance,
            //    * then milesAbleToTravel = miles
            //    */
            //double gallonsUsed = milesAbleToTravel / MilesPerGallon;
            //GasTankLevel -= gallonsUsed;
            //Odometer += milesAbleToTravel;

        }

    }
}
