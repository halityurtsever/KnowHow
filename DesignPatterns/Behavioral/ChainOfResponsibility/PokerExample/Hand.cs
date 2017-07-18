using System.Collections.Generic;

using DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Enums;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample
{
    public class Hand
    {
        //################################################################################
        #region Fields

        private readonly IList<Card> m_Cards;
        private Rank m_Rank;

        #endregion

        //################################################################################
        #region Constructor

        public Hand()
        {
            m_Cards = new List<Card>();
            m_Rank = Rank.HighCard;
        }

        #endregion

        //################################################################################
        #region Properties

        public Rank HandRank
        {
            get
            {
                return m_Rank;
            }

            set
            {
                m_Rank = value;
            }
        }

        public Card this[int index] => m_Cards[index];

        public IList<Card> CardList => m_Cards;

        #endregion

        //################################################################################
        #region Public Implementation

        public void AddCard(Card card)
        {
            if (m_Cards.Count < 5)
            {
                AddCard(card, 0);
            }
        }

        public override string ToString()
        {
            var cards = string.Join(" - ", m_Cards);
            return $"{HandRank}: {cards}";
        }

        #endregion

        //################################################################################
        #region Private Implementation

        private void AddCard(Card card, int index)
        {
            if (m_Cards.Count == index)
            {
                m_Cards.Add(card);
                return;
            }

            if (card.Value > m_Cards[index].Value)
            {
                m_Cards.Insert(index, card);
            }
            else
            {
                AddCard(card, ++index);
            }
        }

        #endregion
    }
}
