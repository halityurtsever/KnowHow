
using System;

namespace SolidDesignPrinciples.OpenClosePrinciple.BadExample
{
    internal class SonarAnalyzer
    {
        internal void AnalyzeProject(SonarProject project)
        {
            if (project is ClientProject)
            {
                RunClientAnalyzer((ClientProject)project);
            }
            else if (project is ServerProject)
            {
                RunServerAnalyzer((ServerProject)project);
            }

            //additional if blocks are needed when a new project is added
        }

        private void RunClientAnalyzer(ClientProject project)
        {
            Console.WriteLine($"{project.ProjectName} is analyzed.");
        }

        private void RunServerAnalyzer(ServerProject project)
        {
            Console.WriteLine($"{project.ProjectName} is analyzed.");
        }
    }
}
