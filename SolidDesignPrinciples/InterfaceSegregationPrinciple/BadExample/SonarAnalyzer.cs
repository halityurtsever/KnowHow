using System.Collections.Generic;

namespace SolidDesignPrinciples.InterfaceSegregationPrinciple.BadExample
{
    internal class SonarAnalyzer
    {
        private List<IAnalyzable> m_ProjectList = new List<IAnalyzable>();

        internal void AddProject(IAnalyzable project)
        {
            m_ProjectList.Add(project);
        }

        internal void StartAnalyzer(IAnalyzable project)
        {
            project.AnalyzeProject();
        }

        internal void StartTestCoverage(IAnalyzable project)
        {
            project.RunTestCoverage();
        }
    }
}
