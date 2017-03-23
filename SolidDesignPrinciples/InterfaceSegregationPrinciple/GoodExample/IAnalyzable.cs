
namespace SolidDesignPrinciples.InterfaceSegregationPrinciple.GoodExample
{
    internal interface IAnalyzable : IAnalyzerService
    {
        void AnalyzeProject();
    }
}
