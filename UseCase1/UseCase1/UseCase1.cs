using System;

namespace UseCase1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FULL_TIME = 1;
            Random random = new Random();

            int number = random.Next(0, 2);
            if (number==FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
