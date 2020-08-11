using EventBasicsV2.Publisher;
using EventBasicsV2.Subscriber;

namespace EventBasicsV2
{
    class Program
    {
        static void Main()
        {
            INewsPublishService publisher = new EuroNewsAgency();
            var subscriber1 = new Cumhuriyet();
            var subscriber2 = new Bloomberg();

            publisher.OnBreakingNews += subscriber1.BreakingNewsSubscription;
            publisher.OnEconomyNews += subscriber1.EconomyNewsSubscription;
            publisher.OnSportsNews += subscriber1.SportsNewsSubscription;

            publisher.OnEconomyNews += subscriber2.EconomyNews;

            ((EuroNewsAgency)publisher).BreakingNewsRelease("New laws in EU", "Germany releases new laws for refugees.");
            ((EuroNewsAgency)publisher).EconomyNewsRelease("EUR/TRY currency rate", "Currency rate difference increased to 6,27 TL");
        }
    }
}
