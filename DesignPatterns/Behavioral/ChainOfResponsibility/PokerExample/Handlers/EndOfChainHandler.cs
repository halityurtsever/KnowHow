using System;

using DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Enums;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Handlers
{
    internal class EndOfChainHandler : IHandRankHandler
    {
        //################################################################################
        #region Fields

        private static readonly EndOfChainHandler s_Instance = new EndOfChainHandler();
        private static Rank Rank = Rank.HighCard;

        #endregion

        //################################################################################
        #region Constructor

        private EndOfChainHandler()
        {

        }

        #endregion

        //################################################################################
        #region Properties

        public static EndOfChainHandler Instance => s_Instance;

        #endregion

        //################################################################################
        #region IHandRankHandler Implementation

        Rank IHandRankHandler.EvaluateHandRank(Hand hand)
        {
            return Rank;
        }

        void IHandRankHandler.RegisterNext(IHandRankHandler nextHandler)
        {
            throw new InvalidOperationException("End of the chain must be end of the chain.");
        }

        #endregion
    }
}
