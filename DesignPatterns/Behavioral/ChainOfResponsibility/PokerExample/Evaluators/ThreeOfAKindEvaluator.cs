using System.Linq;

using DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Enums;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Evaluators
{
    internal class ThreeOfAKindEvaluator : RankEvaluator
    {
        //################################################################################
        #region Fields

        private static readonly Rank Rank = Rank.ThreeOfAKind;

        #endregion

        //################################################################################
        #region Override Implementation

        public override bool EvaluateRank(Hand hand)
        {
            var valueGroups = hand.CardList.GroupBy(x => x.Value).OrderByDescending(y => y.Count()).ToList();

            if (valueGroups.Count != 3) return false;

            if (valueGroups[0].ToList().Count != 3) return false;

            hand.HandRank = Rank;
            return true;
        }

        #endregion
    }
}