using System;

namespace DesignPatterns.Structural.Composite
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Company Annual Bonus: ");
            int annualCompanyBonus = 12345;

            //Create Sales Department
            ICompanyUnit Recep = new Employee("Recep");
            ICompanyUnit Saban = new Employee("Saban");
            ICompanyUnit Ramazan = new Employee("Ramazan");
            ICompanyUnit salesDepartment = new Department("Sales") { Employees = { Recep, Saban, Ramazan } };

            //Create Finance Department
            ICompanyUnit Fatma = new Employee("Fatma");
            ICompanyUnit Hasan = new Employee("Hasan");
            ICompanyUnit Huseyin = new Employee("Huseyin");
            ICompanyUnit financeDepartment = new Department("Finance") { Employees = { Fatma, Hasan, Huseyin, salesDepartment } };

            //Create Human Resources Department
            ICompanyUnit Emine = new Employee("Emine");
            ICompanyUnit Ahmet = new Employee("Ahmet");
            ICompanyUnit Ayse = new Employee("Ayse");
            ICompanyUnit humanResourcesDepartment = new Department("Human Resources") { Employees = { Emine, Ahmet, Ayse } };

            //Create Yurtsever Company
            ICompanyUnit Halit = new Employee("Halit");
            ICompanyUnit Aysun = new Employee("Aysun");
            ICompanyUnit Yigit = new Employee("Yigit");
            ICompanyUnit Ali = new Employee("Ali");

            ICompanyUnit YurtseverCompany = new Department("Yurtsever Company") { Employees = { Halit, Aysun, Yigit, Ali, humanResourcesDepartment, financeDepartment } };

            YurtseverCompany.Bonus = annualCompanyBonus;
            YurtseverCompany.Stats();
        }
    }
}
