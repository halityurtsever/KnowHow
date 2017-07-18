using DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Enums;
using DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Evaluators;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Handlers
{
    internal class HandRankHandler : IHandRankHandler
    {
        //################################################################################
        #region Fields

        private IHandRankHandler m_NextHandler;
        private readonly RankEvaluator m_RankEvaluator;

        #endregion

        //################################################################################
        #region Constructor

        public HandRankHandler(RankEvaluator rankEvaluator)
        {
            m_RankEvaluator = rankEvaluator;
        }

        #endregion

        //################################################################################
        #region IHandRankHandler Implementation

        Rank IHandRankHandler.EvaluateHandRank(Hand hand)
        {
            bool isEvaluated = m_RankEvaluator.EvaluateRank(hand);

            if (!isEvaluated)
            {
                return m_NextHandler.EvaluateHandRank(hand);
            }

            return hand.HandRank;
        }

        void IHandRankHandler.RegisterNext(IHandRankHandler nextHandler)
        {
            m_NextHandler = nextHandler;
        }

        #endregion
    }
}
