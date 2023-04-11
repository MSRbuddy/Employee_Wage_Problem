namespace UseCase10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            // Declaring Objects for companies
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("ABC", 20, 20, 100);
            empWageBuilder.addCompanyEmpWage("XYZ", 40, 40, 70);
            empWageBuilder.computeEmpWage();
        }
    }
}