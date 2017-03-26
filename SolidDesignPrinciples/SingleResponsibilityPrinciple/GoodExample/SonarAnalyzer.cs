namespace SolidDesignPrinciples.SingleResponsibilityPrinciple.GoodExample
{
    internal class SonarAnalyzer : IAnalyzerService
    {
        private IBuildService m_Builder;
        private ITestCoverageService m_TestRunner;

        public SonarAnalyzer()
        {

        }

        void IAnalyzerService.AnalyzeProject()
        {
            //analyze project
        }

        internal void BuildProject()
        {
            m_Builder.BuildProject();
        }

        internal void RunTestCoverage()
        {
            m_TestRunner.RunTestCoverage();
        }
    }
}
