using System.Linq;

using DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Enums;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Evaluators
{
    internal class OnePairEvaluator : RankEvaluator
    {
        //################################################################################
        #region Fields

        private static readonly Rank Rank = Rank.OnePair;

        #endregion

        //################################################################################
        #region Override Implementation

        public override bool EvaluateRank(Hand hand)
        {
            var valueGroups = hand.CardList.GroupBy(x => x.Value).OrderByDescending(y => y.Count()).ToList();

            if (valueGroups.Count != 4) return false;

            var pair = valueGroups[0].ToList();

            if (pair.Count != 2) return false;

            hand.HandRank = Rank;
            return true;
        }

        #endregion
    }
}