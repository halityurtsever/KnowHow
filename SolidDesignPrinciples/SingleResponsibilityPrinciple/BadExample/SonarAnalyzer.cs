namespace SolidDesignPrinciples.SingleResponsibilityPrinciple.BadExample
{
    internal class SonarAnalyzer : IAnalyzerService
    {
        void IAnalyzerService.AnalyzeProject()
        {
            //analyze project
        }

        void IAnalyzerService.BuildProject()
        {
            //build project
        }

        void IAnalyzerService.RunTestCoverage()
        {
            //run test coverage on project
        }
    }
}
