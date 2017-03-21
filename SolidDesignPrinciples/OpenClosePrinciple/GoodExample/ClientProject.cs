using System;

namespace SolidDesignPrinciples.OpenClosePrinciple.GoodExample
{
    internal class ClientProject : SonarProject
    {
        public ClientProject(string projectName) : base(projectName)
        {

        }

        public override void AnalyzeProject()
        {
            Console.WriteLine($"{ProjectName} is analyzed.");
        }
    }
}
