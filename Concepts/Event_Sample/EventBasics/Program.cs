using Concepts.Event_Sample.EventBasics.Publishers;
using Concepts.Event_Sample.EventBasics.Subscribers;

namespace Concepts.Event_Sample.EventBasics
{
    public class Program
    {
        static void Main()
        {
            //Create publishers
            IPublisherService sozcu = new Sozcu("Sozcu");
            IPublisherService cumhuriyet = new Cumhuriyet("Cumhuriyet");

            //Create subscribers
            AnatoliaNewsAgency anatoliaNewsAgency = new AnatoliaNewsAgency("Anatolia NA");
            EuropeNewsAssociation europeNewsAssociation = new EuropeNewsAssociation("ENA");

            //Register subscribers to the publishers' events
            sozcu.OnBreakingNewsReleased += anatoliaNewsAgency.BreakingNews;
            sozcu.OnBreakingNewsReleased += europeNewsAssociation.ENA_BreakingNewsReleases;
            sozcu.OnWorldNewsReleased += anatoliaNewsAgency.WorldNews;
            sozcu.OnWorldNewsReleased += europeNewsAssociation.ENA_WorldNewsReleases;
            sozcu.OnEconomyNewsReleased += anatoliaNewsAgency.EconomyNews;
            sozcu.OnEconomyNewsReleased += europeNewsAssociation.ENA_EconomyNewsReleases;
            sozcu.OnSportsNewsReleased += anatoliaNewsAgency.SportsNews;
            sozcu.OnSportsNewsReleased += europeNewsAssociation.ENA_SportsNewsReleases;
            sozcu.OnMagazineNewsReleased += anatoliaNewsAgency.MagazineNews;
            sozcu.OnMagazineNewsReleased += europeNewsAssociation.ENA_MagazineNewsReleases;

            cumhuriyet.OnBreakingNewsReleased += anatoliaNewsAgency.BreakingNews;
            cumhuriyet.OnBreakingNewsReleased += europeNewsAssociation.ENA_BreakingNewsReleases;
            cumhuriyet.OnWorldNewsReleased += anatoliaNewsAgency.WorldNews;
            cumhuriyet.OnWorldNewsReleased += europeNewsAssociation.ENA_WorldNewsReleases;
            cumhuriyet.OnEconomyNewsReleased += anatoliaNewsAgency.EconomyNews;
            cumhuriyet.OnEconomyNewsReleased += europeNewsAssociation.ENA_EconomyNewsReleases;
            cumhuriyet.OnSportsNewsReleased += anatoliaNewsAgency.SportsNews;
            cumhuriyet.OnSportsNewsReleased += europeNewsAssociation.ENA_SportsNewsReleases;
            cumhuriyet.OnMagazineNewsReleased += anatoliaNewsAgency.MagazineNews;
            cumhuriyet.OnMagazineNewsReleased += europeNewsAssociation.ENA_MagazineNewsReleases;

            ((PublisherBase)sozcu).NewPublishOnBreakingNews("TIA Portal 15 Released.","CEO announced new release.");
        }
    }
}
