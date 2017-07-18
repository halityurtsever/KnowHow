using System.Linq;

using DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Enums;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Evaluators
{
    internal class TwoPairsEvaluator : RankEvaluator
    {
        //################################################################################
        #region Fields

        private static readonly Rank Rank = Rank.TwoPairs;

        #endregion

        //################################################################################
        #region Override Implementation

        public override bool EvaluateRank(Hand hand)
        {
            var valueGroups = hand.CardList.GroupBy(x => x.Value).OrderByDescending(y => y.Count()).ToList();

            if (valueGroups.Count != 3) return false;

            var firstPair = valueGroups[0].ToList();
            var secondPair = valueGroups[1].ToList();

            if (firstPair.Count != 2 && secondPair.Count != 2) return false;

            hand.HandRank = Rank;
            return true;
        }

        #endregion
    }
}