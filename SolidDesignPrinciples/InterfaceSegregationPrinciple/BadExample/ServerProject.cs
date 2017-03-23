
namespace SolidDesignPrinciples.InterfaceSegregationPrinciple.BadExample
{
    internal class ServerProject : IAnalyzable
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
