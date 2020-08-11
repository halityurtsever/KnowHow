using System.Text;
using static System.Console;

namespace EventBasicsV2.Subscriber
{
    internal class Cumhuriyet
    {
        public void BreakingNewsSubscription(object sender, NewsPublishEventArgs args)
        {
            var newsDetails = BuildNews(args);
            WriteLine("Cumhuriyet Breaking News");
            WriteLine(newsDetails);
        }

        public void SportsNewsSubscription(object sender, NewsPublishEventArgs args)
        {
            var newsDetails = BuildNews(args);
            WriteLine("Cumhuriyet Sports News");
            WriteLine(newsDetails);
        }

        public void EconomyNewsSubscription(object sender, NewsPublishEventArgs args)
        {
            var newsDetails = BuildNews(args);
            WriteLine("Cumhuriyet Economy News");
            WriteLine(newsDetails);
        }

        private string BuildNews(NewsPublishEventArgs args)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"\tPublisher: {args.PublisherName}");
            stringBuilder.AppendLine($"\tDateTime: {args.PublishDateTime.ToString("dd MMM yyyy dddd - HH:mm:ss")}");
            stringBuilder.AppendLine($"\tTitle: {args.Title}");
            stringBuilder.AppendLine($"\tDetails: {args.Details}");
            stringBuilder.AppendLine(new string('-', 80));

            return stringBuilder.ToString();
        }
    }
}
