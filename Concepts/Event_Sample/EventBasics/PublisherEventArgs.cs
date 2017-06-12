using System;

using Concepts.Event_Sample.EventBasics.Publishers;

namespace Concepts.Event_Sample.EventBasics
{
    public class PublisherEventArgs : EventArgs
    {
        //################################################################################
        #region Fields

        private readonly IPublisherService m_Publisher;
        private readonly NewsCategory m_Category;
        private string m_Headline;
        private string m_Details;

        #endregion

        //################################################################################
        #region Constructor

        public PublisherEventArgs(IPublisherService publisher, NewsCategory category)
        {
            m_Publisher = publisher;
            m_Category = category;
        }

        #endregion

        //################################################################################
        #region Properties

        internal IPublisherService Publisher => m_Publisher;

        internal NewsCategory Category => m_Category;

        internal string Headline
        {
            get
            {
                return m_Headline;
            }

            set
            {
                m_Headline = value;
            }
        }

        internal string Details
        {
            get
            {
                return m_Details;
            }

            set
            {
                m_Details = value;
            }
        }

        #endregion
    }
}
