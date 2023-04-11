namespace UseCase14
{
    class EmpWageBuilder : IComputeWage, IComputeWageForQuery
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        // The company emp wages list and the dictionary mapped with key as company name
        
        private LinkedList<CompanyEmpWage> companyEmpWagesList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

        // Initializes a new instance of the <see cref="EmpWageBuilder"/> class.
        
        public EmpWageBuilder()
        {
            this.companyEmpWagesList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }

        // Adds the company emp wage.
        
        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.companyEmpWagesList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);
        }

        // Computes the emp wage.
        public void ComputeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWagesList)
            {
                int totalEmpWageTemp = this.ComputeEmpWage(companyEmpWage);
                companyEmpWage.SettotalEmpWage(totalEmpWageTemp);
                Console.WriteLine(companyEmpWage.toString());
            }
        }

        // Computes the emp wage.
        public int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int totalEmpHours = 0;
            int workingDays = 0;
            int empHours = 0;
            int totalWagePerDay = 0;
            int totalWagePerMonth = 0;
            while (totalEmpHours < companyEmpWage.maxHoursPerMonth && workingDays < companyEmpWage.numOfWorkingDays)
            {
                EmpWageBuilder empWageBuilder = new EmpWageBuilder();
                empHours = empWageBuilder.GetWorkingHours();

                if (totalEmpHours == 96)
                {
                    empHours = 4;
                }
                if (empHours != 0)
                {
                    workingDays++;
                    totalEmpHours = empHours + totalEmpHours;
                    totalWagePerDay = empHours * companyEmpWage.ratePerHours;
                    totalWagePerMonth += totalWagePerDay;
                    Console.WriteLine("Total Wage per Day.." + totalWagePerDay);
                }
            }
            return totalWagePerMonth;

        }

        // Gets the working hours.
        public int GetWorkingHours()
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            int empHours = 0;
            Random random = new Random();

            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case FULL_TIME:
                    empHours = 8;
                    break;
                case PART_TIME:
                    empHours = 4;
                    break;
                default:
                    empHours = 0;
                    break;
            }
            return empHours;
        }
        // Gets the total wage.
        public int GetTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
        }
    }
}