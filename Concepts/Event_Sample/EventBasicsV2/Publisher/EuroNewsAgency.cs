using System;
using System.Threading;

namespace EventBasicsV2.Publisher
{
    internal class EuroNewsAgency : INewsPublishService
    {
        //################################################################################
        #region Fields

        private int m_SubscriberCount;

        #endregion

        //################################################################################
        #region Events

        private event EventHandler<NewsPublishEventArgs> BreakingNews;
        private event EventHandler<NewsPublishEventArgs> SportsNews;
        private event EventHandler<NewsPublishEventArgs> EconomyNews;

        #endregion

        //################################################################################
        #region Constructor

        public EuroNewsAgency()
        {
            m_SubscriberCount = 0;
        }

        #endregion

        //################################################################################
        #region Internal Implementation

        public void BreakingNewsRelease(string title, string details)
        {
            var dateTime = DateTime.Now;
            var args = new NewsPublishEventArgs("EuroNews", dateTime, title, details);

            Volatile.Read(ref BreakingNews)?.Invoke(this, args);
        }

        public void SportsNewsRelease(string title, string details)
        {
            var dateTime = DateTime.Now;
            var args = new NewsPublishEventArgs("EuroNews", dateTime, title, details);

            Volatile.Read(ref SportsNews)?.Invoke(this, args);
        }

        public void EconomyNewsRelease(string title, string details)
        {
            var dateTime = DateTime.Now;
            var args = new NewsPublishEventArgs("EuroNews", dateTime, title, details);

            Volatile.Read(ref EconomyNews)?.Invoke(this, args);
        }

        #endregion

        //################################################################################
        #region INewsPublishService Implementation

        int INewsPublishService.SubscriberCount => m_SubscriberCount;

        event EventHandler<NewsPublishEventArgs> INewsPublishService.OnBreakingNews
        {
            add
            {
                BreakingNews += value;
                m_SubscriberCount++;
            }

            remove
            {
                BreakingNews -= value;
                m_SubscriberCount--;
            }
        }

        event EventHandler<NewsPublishEventArgs> INewsPublishService.OnSportsNews
        {
            add
            {
                SportsNews += value;
                m_SubscriberCount++;
            }

            remove
            {
                SportsNews -= value;
                m_SubscriberCount--;
            }
        }

        event EventHandler<NewsPublishEventArgs> INewsPublishService.OnEconomyNews
        {
            add
            {
                EconomyNews += value;
                m_SubscriberCount++;
            }

            remove
            {
                EconomyNews -= value;
                m_SubscriberCount--;
            }
        }

        #endregion
    }
}
