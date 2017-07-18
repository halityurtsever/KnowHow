using System.Collections.Generic;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample
{
    internal class Game
    {
        //################################################################################
        #region Fields

        private readonly Deck m_Deck;
        private readonly IList<Hand> m_Hands;

        #endregion

        //################################################################################
        #region Constructor

        public Game()
        {
            m_Deck = new Deck();
            m_Hands = new List<Hand>();
        }

        #endregion

        //################################################################################
        #region Properties

        internal IList<Hand> Hands => m_Hands;

        #endregion

        //################################################################################
        #region Internal Implementation

        internal void CreateNewTable()
        {
            for (int i = 0; i < 4; i++)
            {
                AddNewHand();
            }
        }

        internal void AddNewHand()
        {
            m_Hands.Add(CreateNewHand());
        }

        #endregion

        //################################################################################
        #region Private Implementation

        private Hand CreateNewHand()
        {
            Hand hand = new Hand();

            for (int j = 0; j < 5; j++)
            {
                hand.AddCard(m_Deck.GetCard());
            }

            return hand;
        }

        #endregion
    }
}
