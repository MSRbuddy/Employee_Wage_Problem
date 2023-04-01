using System;

namespace UseCase3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PART_TIME = 1;
            int FULL_TIME = 2;
            int WAGE_PER_HOUR = 20;
            
            int workHrs = 0;
            int Wage = 0;
            Random random = new Random();

            int number = random.Next(0, 3);
            if(number==PART_TIME)
            {
                workHrs = 4;
            }
            else if(number==FULL_TIME)
            {
                workHrs = 8;
            }
            else
            {
                workHrs = 0;
            }
            Wage = workHrs * WAGE_PER_HOUR;
            Console.WriteLine("Employee Wage is: " + Wage);
        }
    }
}
