
namespace SolidDesignPrinciples.OpenClosePrinciple.GoodExample
{
    internal abstract class SonarProject
    {
        private string m_ProjectName = string.Empty;

        public SonarProject(string projectName)
        {
            m_ProjectName = projectName;
        }

        public string ProjectName => m_ProjectName;

        public abstract void AnalyzeProject();
    }
}
