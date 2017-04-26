namespace DesignPatterns.Creational.Builder
{
    internal class VacationBuilder : IBuilder
    {
        #region  Fields

        private readonly VacationDay m_VacationDay = new VacationDay();

        #endregion

        // ################################################################################
        #region IBuilder Implementation

        VacationDay IBuilder.BuildDay()
        {
            return m_VacationDay;
        }

        IBuilder IBuilder.AddHotel(string hotel)
        {
            m_VacationDay.Hotel = hotel;
            return this;
        }

        IBuilder IBuilder.AddDinnerReservation(string reservation)
        {
            m_VacationDay.DinnerReservation = reservation;
            return this;
        }

        IBuilder IBuilder.AddSpecialEvent(string specialEvent)
        {
            m_VacationDay.SpecialEvent = specialEvent;
            return this;
        }

        IBuilder IBuilder.AddTicket(string ticket)
        {
            m_VacationDay.AddTicket(ticket);
            return this;
        }

        #endregion

        // ################################################################################
    }
}