using System;

namespace SolidDesignPrinciples.OpenClosePrinciple.GoodExample
{
    internal class ServerProject : SonarProject
    {
        public ServerProject(string projectName) : base(projectName)
        {

        }

        public override void AnalyzeProject()
        {
            Console.WriteLine($"{ProjectName} is analyzed.");
        }
    }
}
