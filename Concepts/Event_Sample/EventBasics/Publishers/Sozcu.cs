using System;
using System.Collections.Generic;

namespace Concepts.Event_Sample.EventBasics.Publishers
{
    internal class Sozcu : PublisherBase, IPublisherService
    {
        //################################################################################
        #region Fields

        private readonly IDictionary<string, int> m_SubscriberCounts;

        #endregion

        //################################################################################
        #region Constructor

        public Sozcu(string name) : base(name)
        {
            m_SubscriberCounts = new Dictionary<string, int>
                                     {
                                         { "BreakingNews", 0 },
                                         { "World", 0 },
                                         { "Economy", 0 },
                                         { "Sports", 0 },
                                         { "Magazine", 0 },
                                         { "Total", 0 }
                                     };
        }

        #endregion

        //################################################################################
        #region Properties

        internal int TotalSubscriberCount => m_SubscriberCounts["Total"];

        #endregion

        //################################################################################
        #region Overridden Implementation

        internal override void NewPublishOnBreakingNews(string headline, string details)
        {
            var publisherHeadline = $"SOZCU: {headline}";
            OnBreakingNewsReleased(this, publisherHeadline, details);
        }

        internal override void NewPublishOnWorldNews(string headline, string details)
        {
            var publisherHeadline = $"SOZCU: {headline}";
            OnWorldNewsReleased(this, publisherHeadline, details);
        }

        internal override void NewPublishOnEconomyNews(string headline, string details)
        {
            var publisherHeadline = $"SOZCU: {headline}";
            OnEconomyNewsReleased(this, publisherHeadline, details);
        }

        internal override void NewPublishOnSportsNews(string headline, string details)
        {
            var publisherHeadline = $"SOZCU: {headline}";
            OnSportsNewsReleased(this, publisherHeadline, details);
        }

        internal override void NewPublishOnMagazineNews(string headline, string details)
        {
            var publisherHeadline = $"SOZCU: {headline}";
            OnMagazineNewsReleased(this, publisherHeadline, details);
        }

        #endregion

        //################################################################################
        #region IPublisherService Implementation

        string IPublisherService.Name => Name;

        event EventHandler<PublisherEventArgs> IPublisherService.OnBreakingNewsReleased
        {
            add
            {
                lock (LockObject)
                {
                    BreakingNewsEvent += value;
                    IncreaseSubscriberCount("BreakingNews");
                }
            }
            remove
            {
                lock (LockObject)
                {
                    BreakingNewsEvent -= value;
                    DecreaseSubscriberCount("BreakingNews");
                }
            }
        }

        event EventHandler<PublisherEventArgs> IPublisherService.OnWorldNewsReleased
        {
            add
            {
                lock (LockObject)
                {
                    WorldNewsEvent += value;
                    IncreaseSubscriberCount("World");
                }
            }
            remove
            {
                lock (LockObject)
                {
                    WorldNewsEvent -= value;
                    DecreaseSubscriberCount("World");
                }
            }
        }

        event EventHandler<PublisherEventArgs> IPublisherService.OnEconomyNewsReleased
        {
            add
            {
                lock (LockObject)
                {
                    EconomyNewsEvent += value;
                    IncreaseSubscriberCount("Economy");
                }
            }
            remove
            {
                lock (LockObject)
                {
                    EconomyNewsEvent -= value;
                    DecreaseSubscriberCount("Economy");
                }
            }
        }

        event EventHandler<PublisherEventArgs> IPublisherService.OnSportsNewsReleased
        {
            add
            {
                lock (LockObject)
                {
                    SportsNewsEvent += value;
                    IncreaseSubscriberCount("Sports");
                }
            }
            remove
            {
                lock (LockObject)
                {
                    SportsNewsEvent -= value;
                    DecreaseSubscriberCount("Sports");
                }
            }
        }

        event EventHandler<PublisherEventArgs> IPublisherService.OnMagazineNewsReleased
        {
            add
            {
                lock (LockObject)
                {
                    MagazineNewsEvent += value;
                    IncreaseSubscriberCount("Magazine");
                }
            }
            remove
            {
                lock (LockObject)
                {
                    MagazineNewsEvent -= value;
                    DecreaseSubscriberCount("Magazine");
                }
            }
        }

        #endregion

        //################################################################################
        #region Private Implementation

        private void IncreaseSubscriberCount(string key)
        {
            m_SubscriberCounts[key]++;
            m_SubscriberCounts["Total"]++;
        }

        private void DecreaseSubscriberCount(string key)
        {
            m_SubscriberCounts[key]--;
            m_SubscriberCounts["Total"]--;
        }

        #endregion
    }
}
