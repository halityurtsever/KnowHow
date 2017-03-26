namespace SolidDesignPrinciples.SingleResponsibilityPrinciple.GoodExample
{
    internal class MSBuildBuilder : IBuildService
    {
        void IBuildService.BuildProject()
        {
            //run msbuild builder
        }
    }
}
