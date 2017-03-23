using System.Collections.Generic;

namespace SolidDesignPrinciples.InterfaceSegregationPrinciple.BadExample
{
    internal class SonarAnalyzer
    {
        private List<IAnalyzable> m_AnalyzableProjectList = new List<IAnalyzable>();

        internal void AddProject(IAnalyzable project)
        {
            m_AnalyzableProjectList.Add(project);
        }

        internal void ExecuteAnalyzer()
        {

        }

        private void StartAnalyzer(IAnalyzable project)
        {
            project.AnalyzeProject();
        }

        private void StartTestCoverage(IAnalyzable project)
        {
            project.RunTestCoverage();
        }
    }
}
