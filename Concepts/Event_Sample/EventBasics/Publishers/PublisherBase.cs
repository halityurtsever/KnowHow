using System;

namespace Concepts.Event_Sample.EventBasics.Publishers
{
    public abstract class PublisherBase
    {
        //################################################################################
        #region Fields

        private readonly string m_Name;
        private readonly object m_LockObject = new object();

        #endregion

        //################################################################################
        #region Events

        protected event EventHandler<PublisherEventArgs> BreakingNewsEvent;
        protected event EventHandler<PublisherEventArgs> WorldNewsEvent;
        protected event EventHandler<PublisherEventArgs> EconomyNewsEvent;
        protected event EventHandler<PublisherEventArgs> SportsNewsEvent;
        protected event EventHandler<PublisherEventArgs> MagazineNewsEvent;

        #endregion

        //################################################################################
        #region Constructor

        protected PublisherBase(string name)
        {
            m_Name = name;
        }

        #endregion

        //################################################################################
        #region Abstract Implementation

        internal abstract void NewPublishOnBreakingNews(string headline, string details);

        internal abstract void NewPublishOnWorldNews(string headline, string details);

        internal abstract void NewPublishOnEconomyNews(string headline, string details);

        internal abstract void NewPublishOnSportsNews(string headline, string details);

        internal abstract void NewPublishOnMagazineNews(string headline, string details);

        #endregion

        //################################################################################
        #region Protected Implementation

        protected string Name => m_Name;

        protected object LockObject => m_LockObject;

        protected void OnBreakingNewsReleased(IPublisherService sender, string headline, string details)
        {
            if (BreakingNewsEvent != null)
            {
                PublisherEventArgs eventArgs = new PublisherEventArgs(sender, NewsCategory.BreakingNews)
                {
                    Headline = headline,
                    Details = details
                };

                BreakingNewsEvent(sender, eventArgs);
            }
        }

        protected void OnWorldNewsReleased(IPublisherService sender, string headline, string details)
        {
            if (WorldNewsEvent != null)
            {
                PublisherEventArgs eventArgs = new PublisherEventArgs(sender, NewsCategory.World)
                {
                    Headline = headline,
                    Details = details
                };

                WorldNewsEvent(sender, eventArgs);
            }
        }

        protected void OnEconomyNewsReleased(IPublisherService sender, string headline, string details)
        {
            if (EconomyNewsEvent != null)
            {
                PublisherEventArgs eventArgs = new PublisherEventArgs(sender, NewsCategory.Economy)
                {
                    Headline = headline,
                    Details = details
                };

                EconomyNewsEvent(sender, eventArgs);
            }
        }

        protected void OnSportsNewsReleased(IPublisherService sender, string headline, string details)
        {
            if (SportsNewsEvent != null)
            {
                PublisherEventArgs eventArgs = new PublisherEventArgs(sender, NewsCategory.Sports)
                {
                    Headline = headline,
                    Details = details
                };

                SportsNewsEvent(sender, eventArgs);
            }
        }

        protected void OnMagazineNewsReleased(IPublisherService sender, string headline, string details)
        {
            if (MagazineNewsEvent != null)
            {
                PublisherEventArgs eventArgs = new PublisherEventArgs(sender, NewsCategory.Magazine)
                {
                    Headline = headline,
                    Details = details
                };

                MagazineNewsEvent(sender, eventArgs);
            }
        }

        #endregion
    }
}
