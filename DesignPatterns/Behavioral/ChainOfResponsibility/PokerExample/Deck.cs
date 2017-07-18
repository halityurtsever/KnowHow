using System;
using System.Collections.Generic;

using DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Enums;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample
{
    internal class Deck
    {
        //################################################################################
        #region Fields

        private readonly IList<Card> m_Cards;
        private readonly Random m_Random;

        #endregion

        //################################################################################
        #region Constructor

        public Deck()
        {
            m_Cards = new List<Card>();
            m_Random = new Random();
            InitializeDeck();
        }

        #endregion

        //################################################################################
        #region Public Implementation

        internal Card GetCard()
        {
            var cardIndex = GetRandomNumber();
            var card = m_Cards[cardIndex];

            m_Cards.RemoveAt(cardIndex);

            return card;
        }

        #endregion

        //################################################################################
        #region Private Implementation

        private void InitializeDeck()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Value value in Enum.GetValues(typeof(Value)))
                {
                    Card card = new Card(suit, value);
                    m_Cards.Add(card);
                }
            }
        }

        private int GetRandomNumber()
        {
            return m_Random.Next(0, m_Cards.Count);
        }

        #endregion
    }
}
