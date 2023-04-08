using System;

namespace UseCase7
{
    internal class Program
    {
        public const int PART_TIME = 1, FULL_TIME = 2 ;
        public const int WAGE_PER_HOUR = 20;
        public const int NO_OF_WORKING_DAYS = 2;
        public const int MAX_HRS_IN_MONTH = 10;
        public static int computeEmpWage()
        {
            int workHrs = 0, totalHrs = 0, totalWorkingDays = 0;
            while(totalHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NO_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int number = random.Next(0, 3);
                switch(number)
                {
                    case 0: PART_TIME:
                        workHrs = 4;
                        break;
                    case 1: FULL_TIME:
                        workHrs = 8;
                        break;
                    default:
                        workHrs = 0;
                        break;
                }
                totalHrs = totalHrs + workHrs;
                Console.WriteLine("Days is: " + totalWorkingDays + " Employee working Hrs: " + workHrs);
            }
            int totalWage = totalHrs * WAGE_PER_HOUR;
            Console.WriteLine("TOtal Wage Of Employee is: " + totalWage);
            return totalWage;
        }
        static void Main(string[] args)
        {
            computeEmpWage();
        }
    }
}
