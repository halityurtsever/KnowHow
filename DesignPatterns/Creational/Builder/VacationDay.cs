using System.Collections.Generic;

namespace DesignPatterns.Creational.Builder
{
    public class VacationDay
    {
        //################################################################################
        #region Fields

        private string m_Hotel;
        private string m_DinnerReservation;
        private string m_SpecialEvent;
        private readonly List<string> m_Tickets;

        #endregion

        //################################################################################
        #region Constructor

        public VacationDay()
        {
            this.m_Tickets = new List<string>();
        }

        #endregion

        //################################################################################
        #region Properties

        internal string Hotel
        {
            get
            {
                return this.m_Hotel;
            }

            set
            {
                this.m_Hotel = value;
            }
        }

        internal string DinnerReservation
        {
            get
            {
                return this.m_DinnerReservation;
            }

            set
            {
                this.m_DinnerReservation = value;
            }
        }

        internal string SpecialEvent
        {
            get
            {
                return this.m_SpecialEvent;
            }

            set
            {
                this.m_SpecialEvent = value;
            }
        }

        internal List<string> Tickets => this.m_Tickets;

        #endregion

        //################################################################################
        #region Internal Implementation

        internal void AddTicket(string ticket)
        {
            this.m_Tickets.Add(ticket);
        }

        #endregion
    }
}
