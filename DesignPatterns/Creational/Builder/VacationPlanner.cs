using System.Collections.Generic;

namespace DesignPatterns.Creational.Builder
{
    internal class VacationPlanner
    {
        //################################################################################
        #region Fields

        private readonly List<VacationDay> m_VacationDays = new List<VacationDay>();

        #endregion

        //################################################################################
        #region Internal Implementation

        internal void AddVacationDay(VacationDay day)
        {
            this.m_VacationDays.Add(day);
        }

        internal IBuilder GetVacationBuilder()
        {
            return new VacationBuilder();
        }

        //add new concrete builders

        #endregion
    }
}
