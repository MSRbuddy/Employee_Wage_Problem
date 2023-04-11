namespace UseCase9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program UC-9!");
            // Declaring Objects for companies
            EmployeeCompanyWageData abc = new EmployeeCompanyWageData("ABC", 20, 10, 50);
            EmployeeCompanyWageData xyz = new EmployeeCompanyWageData("XYZ", 10, 30, 400);
            // Calling the Objects
            abc.calculateWage();
            Console.WriteLine(abc.toString());
            xyz.calculateWage();
            Console.WriteLine(xyz.toString());
        }
    }
}