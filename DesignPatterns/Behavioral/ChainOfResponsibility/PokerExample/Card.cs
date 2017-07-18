using DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Enums;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample
{
    public class Card
    {
        //################################################################################
        #region Fields

        private readonly Suit m_Suit;
        private readonly Value m_Value;

        #endregion

        //################################################################################
        #region Constructor

        public Card(Suit suit, Value value)
        {
            m_Suit = suit;
            m_Value = value;
        }

        #endregion

        //################################################################################
        #region Properties

        internal Suit Suit => m_Suit;

        internal Value Value => m_Value;

        #endregion

        //################################################################################
        #region Public Implementation

        public override string ToString()
        {
            return $"[{m_Suit} {m_Value}]";
        }

        #endregion
    }
}
