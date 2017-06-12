using System;

namespace Concepts.Event_Sample.EventBasics.Publishers
{
    internal class Cumhuriyet : PublisherBase, IPublisherService
    {
        //################################################################################
        #region Constructor

        public Cumhuriyet(string name) : base(name)
        {

        }

        #endregion

        //################################################################################
        #region Overridden Implementation

        internal override void NewPublishOnBreakingNews(string headline, string details)
        {
            var publisherHeadline = $"CUMHURIYET >> {headline}";
            OnBreakingNewsReleased(this, publisherHeadline, details);
        }

        internal override void NewPublishOnWorldNews(string headline, string details)
        {
            var publisherHeadline = $"CUMHURIYET >> {headline}";
            OnWorldNewsReleased(this, publisherHeadline, details);
        }

        internal override void NewPublishOnEconomyNews(string headline, string details)
        {
            var publisherHeadline = $"CUMHURIYET >> {headline}";
            OnEconomyNewsReleased(this, publisherHeadline, details);
        }

        internal override void NewPublishOnSportsNews(string headline, string details)
        {
            var publisherHeadline = $"CUMHURIYET >> {headline}";
            OnSportsNewsReleased(this, publisherHeadline, details);
        }

        internal override void NewPublishOnMagazineNews(string headline, string details)
        {
            var publisherHeadline = $"CUMHURIYET >> {headline}";
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
                }
            }
            remove
            {
                lock (LockObject)
                {
                    BreakingNewsEvent -= value;
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
                }
            }
            remove
            {
                lock (LockObject)
                {
                    WorldNewsEvent -= value;
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
                }
            }
            remove
            {
                lock (LockObject)
                {
                    EconomyNewsEvent -= value;
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
                }
            }
            remove
            {
                lock (LockObject)
                {
                    SportsNewsEvent -= value;
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
                }
            }
            remove
            {
                lock (LockObject)
                {
                    MagazineNewsEvent -= value;
                }
            }
        }

        #endregion
    }
}
