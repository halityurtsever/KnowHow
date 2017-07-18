using System.Linq;

using DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Enums;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Evaluators
{
    internal class FullHouseEvaluator : RankEvaluator
    {
        //################################################################################
        #region Fields

        private static readonly Rank Rank = Rank.FullHouse;

        #endregion

        //################################################################################
        #region Override Implementation

        public override bool EvaluateRank(Hand hand)
        {
            var valueGroups = hand.CardList.GroupBy(x => x.Value).ToList();

            if (valueGroups.Count != 2) return false;

            var firstGroup = valueGroups[0].ToList();
            var secondGroup = valueGroups[1].ToList();

            if (firstGroup.Count == 2 && secondGroup.Count == 3 || firstGroup.Count == 3 && secondGroup.Count == 2)
            {
                hand.HandRank = Rank;
                return true;
            }

            return false;
        }

        #endregion
    }
}