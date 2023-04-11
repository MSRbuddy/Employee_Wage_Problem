namespace UseCase13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            // Declaring Objects for companies
            EmployeeWageBuilder empWageBuilder = new EmployeeWageBuilder();
            empWageBuilder.AddCompanyEmpWage("ABC", 20, 2, 20);
            empWageBuilder.AddCompanyEmpWage("XYZ", 15, 14, 40);
            //Calling the method to compute total wage and storing it in the class member
            empWageBuilder.ComputeEmpWage();
            //Calling the method to compute daily wage and storing it in the class member
            empWageBuilder.ComputeDailyWage();
        }
    }
    public interface IComputeWage
    {
        void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        void ComputeDailyWage();
        void ComputeEmpWage();
    }
}