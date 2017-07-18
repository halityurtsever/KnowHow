using DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Enums;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Evaluators
{
    internal class StraightFlushEvaluator : RankEvaluator
    {
        //################################################################################
        #region Fields

        private static readonly Rank Rank = Rank.StraightFlush;

        #endregion

        //################################################################################
        #region IRankEvaluator Implementation

        public override bool EvaluateRank(Hand hand)
        {
            if (!IsAllOfSameSuit(hand)) return false;

            if (!IsStraight(hand)) return false;

            hand.HandRank = Rank;
            return true;
        }

        #endregion
    }
}