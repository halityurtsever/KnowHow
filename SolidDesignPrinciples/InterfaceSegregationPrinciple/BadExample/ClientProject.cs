
namespace SolidDesignPrinciples.InterfaceSegregationPrinciple.BadExample
{
    internal class ClientProject : IAnalyzable
    {
        void IAnalyzable.BuildProject()
        {
            //build project here
        }

        void IAnalyzable.AnalyzeProject()
        {
            //analyze project here
        }

        void IAnalyzable.RunTestCoverage()
        {
            //run test coverage here
        }
    }
}
