using System;

namespace Concepts.Event_Sample.EventBasics.Subscribers
{
    internal class AnatoliaNewsAgency
    {
        //################################################################################
        #region Fields

        private readonly string m_Name;

        #endregion

        //################################################################################
        #region Constructor

        public AnatoliaNewsAgency(string name)
        {
            m_Name = name;
        }

        #endregion

        //################################################################################
        #region Internal Implementation

        internal void BreakingNews(object sender, PublisherEventArgs args)
        {
            Console.WriteLine($"-> {args.Category} from {m_Name}");
            Console.WriteLine($"Source: {args.Publisher.Name}");
            Console.WriteLine($"Headline: {args.Headline}");
            Console.WriteLine($"News Details: {args.Details}");
            Console.WriteLine(Environment.NewLine);
        }

        internal void WorldNews(object sender, PublisherEventArgs args)
        {
            Console.WriteLine($"-> {args.Category} News from Anatoila News Agency");
            Console.WriteLine($"Source: {args.Publisher.Name}");
            Console.WriteLine($"Headline: {args.Headline}");
            Console.WriteLine($"News Details: {args.Details}");
            Console.WriteLine(Environment.NewLine);
        }

        internal void EconomyNews(object sender, PublisherEventArgs args)
        {
            Console.WriteLine($"-> {args.Category} News from Anatoila News Agency");
            Console.WriteLine($"Source: {args.Publisher.Name}");
            Console.WriteLine($"Headline: {args.Headline}");
            Console.WriteLine($"News Details: {args.Details}");
            Console.WriteLine(Environment.NewLine);
        }

        internal void SportsNews(object sender, PublisherEventArgs args)
        {
            Console.WriteLine($"-> {args.Category} News from Anatoila News Agency");
            Console.WriteLine($"Source: {args.Publisher.Name}");
            Console.WriteLine($"Headline: {args.Headline}");
            Console.WriteLine($"News Details: {args.Details}");
            Console.WriteLine(Environment.NewLine);
        }

        internal void MagazineNews(object sender, PublisherEventArgs args)
        {
            Console.WriteLine($"-> {args.Category} News from Anatoila News Agency");
            Console.WriteLine($"Source: {args.Publisher.Name}");
            Console.WriteLine($"Headline: {args.Headline}");
            Console.WriteLine($"News Details: {args.Details}");
            Console.WriteLine(Environment.NewLine);
        }

        #endregion
    }
}
