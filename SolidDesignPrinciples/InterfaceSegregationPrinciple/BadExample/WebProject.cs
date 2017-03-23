using System;

namespace SolidDesignPrinciples.InterfaceSegregationPrinciple.BadExample
{
    internal class WebProject : IAnalyzable
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
            //Due to web projects don't support test coverage,
            //we implement here a method that we won't use
            //To fix it we need to segregate IAnalyzable interface
            throw new NotImplementedException();
        }
    }
}
