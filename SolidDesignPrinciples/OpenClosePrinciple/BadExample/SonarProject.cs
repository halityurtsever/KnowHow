
namespace SolidDesignPrinciples.OpenClosePrinciple.BadExample
{
    internal class SonarProject
    {
        private string m_ProjectName = string.Empty;

        public SonarProject(string projectName)
        {
            m_ProjectName = projectName;
        }

        internal string ProjectName => m_ProjectName;
    }
}
