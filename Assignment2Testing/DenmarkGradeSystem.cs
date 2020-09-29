using System;
using System.Security.Cryptography.X509Certificates;

namespace Assignment2Testing
{
    public class DenmarkGradeSystem
    {
        public DenmarkGradeSystem()
        {
            
        }
        public int grade;
        public int ToGrade(int percentage)
        {
            if (percentage < 0 && percentage > 100)
            {
                throw new ArgumentOutOfRangeException($"No grades available");
            }
            
            if (percentage  >= 0 && percentage  <= 5)
            {
                 return grade = -3 ;
            }

            if (percentage  >= 6 && percentage <= 49)
            {
                 return grade = 0;
            }

            if (percentage >= 50 && percentage <= 59)
            {
                return grade = 2;
            }

            if (percentage >= 60 && percentage <= 79)
            {
                return grade = 4;
            }

            if (percentage >= 80 && percentage <= 84)
            {
                return grade = 7;
            }

            if (percentage >= 85 && percentage <= 94)
            {
               return  grade = 10;
            }

            if (percentage >=95 && percentage <= 100)
            {
                return grade = 12;
            }

            return grade;
        }
    }
}
