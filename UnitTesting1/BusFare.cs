using System;

namespace UnitTesting1
{
    public class BusFare
    {
        public BusFare()
        {
            
        }

        public double CalculateFare(double km, int passengers)
        {
            if (km < 0 || passengers < 0)
            {
                throw new ArgumentOutOfRangeException($" passengersand distance cannot be less than zero");
            }

            if (km < 100 )
            {
                return km * 3.2 + 130;

            }

            if (km >100 && km < 500 && passengers < 12)
            {
                return km * 2.75 + 130;
            }

            if (km > 100 && km < 500 && passengers > 12)
            {
                return km * 3 + 130;
            }

            if (km > 500)
            {
                return km * 2.25;
            }

            return 0;

        }
    }
}
