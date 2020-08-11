using System.Text;
using static System.Console;

namespace EventBasicsV2.Subscriber
{
    internal class Bloomberg
    {
        public void EconomyNews(object sender, NewsPublishEventArgs args)
        {
            var newsDetails = BuildNews(args);
            WriteLine("Bloomberg Latest Economy News");
            WriteLine(newsDetails);
        }

        private string BuildNews(NewsPublishEventArgs args)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"\tPublisher: {args.PublisherName}");
            stringBuilder.AppendLine($"\tTitle: {args.Title}, Details: {args.Details}");
            stringBuilder.AppendLine($"\tDateTime: {args.PublishDateTime.ToString("dd MMM yyyy dddd - HH:mm:ss")}");
            stringBuilder.AppendLine(new string('-', 80));

            return stringBuilder.ToString();
        }
    }
}
