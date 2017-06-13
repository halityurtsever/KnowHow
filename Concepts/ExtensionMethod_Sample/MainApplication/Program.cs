using System;

using ExtensionLibrary;

namespace MainApplication
{
    class Program
    {
        static void Main()
        {
            //Create object instances from ExtensionLibrary.dll
            Employee employee = new Employee("Halit", 5000, 3.14);
            Manager manager = new Manager("Aysun", 8000, 5.15);

            //In here, we can access all public members of above classes
            employee.PrintEmployee();
            manager.PrintManager();

            //What if we need to add new functionalities to those classes that we are not allowed to change
            Console.WriteLine("Invocation from object instance.");
            manager.PromoteManager();
            employee.RaiseEmployeeSalary();

            //Another option to invoke extension methods
            Console.WriteLine("Invocation from static class method.");
            FunctionalityExtension.PromoteManager(manager);
            FunctionalityExtension.RaiseEmployeeSalary(employee);
        }
    }
}
