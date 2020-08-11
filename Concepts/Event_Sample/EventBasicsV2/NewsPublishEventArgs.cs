using System;

namespace EventBasicsV2
{
    internal class NewsPublishEventArgs : EventArgs
    {
        public NewsPublishEventArgs(string publisherName, DateTime publishDateTime, string title, string details)
        {
            PublisherName = publisherName;
            PublishDateTime = publishDateTime;
            Title = title;
            Details = details;
        }

        public string PublisherName { get; }

        public DateTime PublishDateTime { get; }

        public string Title { get; }

        public string Details { get; }
    }
}
