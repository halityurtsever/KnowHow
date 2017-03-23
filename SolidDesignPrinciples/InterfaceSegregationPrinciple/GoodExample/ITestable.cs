
namespace SolidDesignPrinciples.InterfaceSegregationPrinciple.GoodExample
{
    internal interface ITestable : IAnalyzerService
    {
        void RunTestCoverage();
    }
}
