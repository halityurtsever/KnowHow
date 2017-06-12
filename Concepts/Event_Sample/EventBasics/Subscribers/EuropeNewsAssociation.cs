using System;

namespace Concepts.Event_Sample.EventBasics.Subscribers
{
    internal class EuropeNewsAssociation
    {
        //################################################################################
        #region Fields

        private readonly string m_Name;

        #endregion

        //################################################################################
        #region Constructor

        public EuropeNewsAssociation(string name)
        {
            m_Name = name;
        }

        #endregion

        //################################################################################
        #region Internal Implementation

        internal void ENA_BreakingNewsReleases(object sender, PublisherEventArgs args)
        {
            Console.WriteLine($"{m_Name} Presents: {args.Category}");
            Console.WriteLine($"SOURCE: {args.Publisher.Name}");
            Console.WriteLine($"HEADER: {args.Headline}");
            Console.WriteLine($"DETAIL: {args.Details}");
            Console.WriteLine(Environment.NewLine);
        }

        internal void ENA_WorldNewsReleases(object sender, PublisherEventArgs args)
        {
            Console.WriteLine($"ENA Presents: {args.Category}");
            Console.WriteLine($"SOURCE: {args.Publisher.Name}");
            Console.WriteLine($"HEADER: {args.Headline}");
            Console.WriteLine($"DETAIL: {args.Details}");
            Console.WriteLine(Environment.NewLine);
        }

        internal void ENA_EconomyNewsReleases(object sender, PublisherEventArgs args)
        {
            Console.WriteLine($"ENA Presents: {args.Category}");
            Console.WriteLine($"SOURCE: {args.Publisher.Name}");
            Console.WriteLine($"HEADER: {args.Headline}");
            Console.WriteLine($"DETAIL: {args.Details}");
            Console.WriteLine(Environment.NewLine);
        }

        internal void ENA_SportsNewsReleases(object sender, PublisherEventArgs args)
        {
            Console.WriteLine($"ENA Presents: {args.Category}");
            Console.WriteLine($"SOURCE: {args.Publisher.Name}");
            Console.WriteLine($"HEADER: {args.Headline}");
            Console.WriteLine($"DETAIL: {args.Details}");
            Console.WriteLine(Environment.NewLine);
        }

        internal void ENA_MagazineNewsReleases(object sender, PublisherEventArgs args)
        {
            Console.WriteLine($"ENA Presents: {args.Category}");
            Console.WriteLine($"SOURCE: {args.Publisher.Name}");
            Console.WriteLine($"HEADER: {args.Headline}");
            Console.WriteLine($"DETAIL: {args.Details}");
            Console.WriteLine(Environment.NewLine);
        }

        #endregion
    }
}
