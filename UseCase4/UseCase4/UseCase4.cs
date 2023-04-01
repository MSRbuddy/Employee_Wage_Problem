using System;

namespace UseCase4_3
{
    internal class Program
    {
        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;
        public const int WAGE_PER_HOUR = 20;
        static void Main(string[] args)
        {
            int workHrs = 0, Wage=0;
            Random random = new Random();

            int number = random.Next(0, 3);
            switch (number)
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
            Wage = workHrs * WAGE_PER_HOUR;
            Console.WriteLine("Employee Wage is: " + Wage);
        }
    }
}
