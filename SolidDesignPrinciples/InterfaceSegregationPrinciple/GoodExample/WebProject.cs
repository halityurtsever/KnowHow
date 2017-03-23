
namespace SolidDesignPrinciples.InterfaceSegregationPrinciple.GoodExample
{
    internal class WebProject : IAnalyzable
    {
        void IAnalyzerService.BuildProject()
        {
            //build project here
        }

        void IAnalyzable.AnalyzeProject()
        {
            //analyze project here
        }
    }
}
