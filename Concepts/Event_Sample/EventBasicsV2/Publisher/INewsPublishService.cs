using System;

namespace EventBasicsV2.Publisher
{
    internal interface INewsPublishService
    {
        int SubscriberCount { get; }

        event EventHandler<NewsPublishEventArgs> OnBreakingNews;

        event EventHandler<NewsPublishEventArgs> OnSportsNews;

        event EventHandler<NewsPublishEventArgs> OnEconomyNews;
    }
}
