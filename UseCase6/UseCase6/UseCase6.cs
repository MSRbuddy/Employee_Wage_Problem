using System;

namespace UseCase6_3
{
    internal class Program
    {
        public const int PART_TIME = 1, FULL_TIME = 2;
        public const int WAGE_PER_HOUR = 20;
        public const int NO_OF_WORKING_DAYS = 2;
        public const int MAX_HRS_IN_MONTH = 10;
        static void Main(string[] args)
        {
            int workHrs = 0, totalWorkHrs = 0, totalWorkingDays = 0;
            while(totalWorkHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NO_OF_WORKING_DAYS)
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
                totalWorkHrs = totalWorkHrs + workHrs;
                Console.WriteLine("Emp working days: " + totalWorkingDays  + "Emp Hours is: " + workHrs);
            }
            int monthlyWage = totalWorkHrs * WAGE_PER_HOUR;
            Console.WriteLine("Total Month Wage of Emp is: " + monthlyWage);
        }
    }
}
