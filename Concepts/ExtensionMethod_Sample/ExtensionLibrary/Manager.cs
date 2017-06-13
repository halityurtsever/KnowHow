using System;

namespace ExtensionLibrary
{
    /// <summary>
    /// This is a public class and must not be changed
    /// </summary>
    public class Manager
    {
        //################################################################################
        #region Fields

        private readonly string m_Name;
        private readonly double m_Salary;
        private readonly double m_Factor;

        #endregion

        //################################################################################
        #region Constructor

        public Manager(string name, double salary, double factor)
        {
            m_Name = name;
            m_Salary = salary;
            m_Factor = factor;
        }

        #endregion

        //################################################################################
        #region Properties

        public string Name => m_Name;

        public double Salary => m_Salary;

        public double Factor => m_Factor;

        #endregion

        //################################################################################
        #region Public Implementation

        public void PrintManager()
        {
            Console.WriteLine("Title: Manager");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Factor: {Factor}");
            Console.WriteLine("-----");
            Console.WriteLine();
        }

        #endregion
    }
}
