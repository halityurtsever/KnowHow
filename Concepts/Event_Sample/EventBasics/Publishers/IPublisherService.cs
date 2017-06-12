using System;

namespace Concepts.Event_Sample.EventBasics.Publishers
{
    public interface IPublisherService
    {
        //################################################################################
        #region Properties

        string Name { get; }

        #endregion

        //################################################################################
        #region Events

        event EventHandler<PublisherEventArgs> OnBreakingNewsReleased;

        event EventHandler<PublisherEventArgs> OnWorldNewsReleased;

        event EventHandler<PublisherEventArgs> OnEconomyNewsReleased;

        event EventHandler<PublisherEventArgs> OnSportsNewsReleased;

        event EventHandler<PublisherEventArgs> OnMagazineNewsReleased;

        #endregion
    }
}
