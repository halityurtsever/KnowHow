using System.Linq;

using DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Enums;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Evaluators
{
    internal class FourOfAKindEvaluator : RankEvaluator
    {
        //################################################################################
        #region Fields

        private static readonly Rank Rank = Rank.FourOfAKind;

        #endregion

        //################################################################################
        #region Override Implementation

        public override bool EvaluateRank(Hand hand)
        {
            var valueGroups = hand.CardList.GroupBy(x => x.Value).ToList();

            if (valueGroups.Count != 2) return false;

            var firstGroup = valueGroups[0].ToList();
            var secondGroup = valueGroups[1].ToList();

            if (firstGroup.Count == 4 || secondGroup.Count == 4)
            {
                hand.HandRank = Rank;
                return true;
            }

            return false;
        }

        #endregion
    }
}