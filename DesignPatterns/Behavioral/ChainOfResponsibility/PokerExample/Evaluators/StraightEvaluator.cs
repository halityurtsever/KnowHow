using DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Enums;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Evaluators
{
    internal class StraightEvaluator : RankEvaluator
    {
        //################################################################################
        #region Fields

        private static readonly Rank Rank = Rank.Straight;

        #endregion

        //################################################################################
        #region Override Implementation

        public override bool EvaluateRank(Hand hand)
        {
            if (!IsStraight(hand)) return false;

            hand.HandRank = Rank;
            return true;
        }

        #endregion
    }
}