using System.Collections.Generic;

namespace SolidDesignPrinciples.InterfaceSegregationPrinciple.GoodExample
{
    internal class SonarAnalyzer
    {
        private List<IAnalyzerService> m_ProjectList = new List<IAnalyzerService>();

        internal void AddProject(IAnalyzerService project)
        {
            m_ProjectList.Add(project);
        }

        internal void StartAnalyzer(IAnalyzable project)
        {
            project.AnalyzeProject();
        }

        internal void StartTestCoverage(ITestable project)
        {
            project.RunTestCoverage();
        }
    }
}
