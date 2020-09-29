using System;

namespace IsTeenager
{
    public class IsTeenager
    {
        public bool result;
         
        
        public bool GetAge(DateTime birthday)
        {
            int yearDifference = DateTime.Now.Year - birthday.Year;

            if (yearDifference >= 13 && yearDifference <= 19)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
