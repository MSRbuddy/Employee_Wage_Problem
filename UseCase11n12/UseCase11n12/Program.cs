namespace UseCase11
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
            empWageBuilder.ComputeEmpWage();
        }
    }

    public interface IComputeWage
    {
        void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        void ComputeEmpWage();
    }
}