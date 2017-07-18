using DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Enums;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Evaluators
{
    internal class FlushEvaluator : RankEvaluator
    {
        //################################################################################
        #region Fields

        private static readonly Rank Rank = Rank.Flush;

        #endregion

        //################################################################################
        #region Override Implementation

        public override bool EvaluateRank(Hand hand)
        {
            if (!IsAllOfSameSuit(hand)) return false;

            hand.HandRank = Rank;
            return true;
        }

        #endregion
    }
}