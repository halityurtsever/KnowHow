using DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Enums;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Evaluators
{
    internal class RoyalFlushEvaluator : RankEvaluator
    {
        //################################################################################
        #region Fields

        private static readonly Rank Rank = Rank.RoyalFlush;

        #endregion

        //################################################################################
        #region Override Implementation

        public override bool EvaluateRank(Hand hand)
        {
            if (hand[0].Value != Value.Ace) return false;

            if (!IsAllOfSameSuit(hand)) return false;

            if (!IsStraight(hand)) return false;

            hand.HandRank = Rank;
            return true;
        }

        #endregion
    }
}
