namespace SolidDesignPrinciples.SingleResponsibilityPrinciple.BadExample
{
    /// <summary>
    /// In this example, IAnalyzerService is responsible for analyzing, building and running test coverage.
    /// All those responsibilities should be moved to seperate layers.
    /// </summary>
    internal interface IAnalyzerService
    {
        void BuildProject();

        void AnalyzeProject();

        void RunTestCoverage();
    }
}
