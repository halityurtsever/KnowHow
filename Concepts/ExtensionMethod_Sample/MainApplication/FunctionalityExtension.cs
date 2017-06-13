using System;

using ExtensionLibrary;

namespace MainApplication
{
    internal static class FunctionalityExtension
    {
        internal static void PromoteManager(this Manager manager)
        {
            Console.WriteLine(manager.Factor > 5 ? $"Manager {manager.Name} promoted." : $"Manager {manager.Name} cannot be promoted.");
        }

        internal static void RaiseEmployeeSalary(this Employee employee)
        {
            Console.WriteLine(employee.Factor > 3 ? $"Salary raised for {employee.Name}." : $"Salary cannot be raised for {employee.Name}.");
        }
    }
}
