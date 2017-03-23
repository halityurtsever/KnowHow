
namespace SolidDesignPrinciples.InterfaceSegregationPrinciple.GoodExample
{
    internal class ServerProject : IAnalyzable, ITestable
    {
        void IAnalyzerService.BuildProject()
        {
            //build project here
        }

        void IAnalyzable.AnalyzeProject()
        {
            //analyze project here
        }

        void ITestable.RunTestCoverage()
        {
            //run test coverage here
        }
    }
}
