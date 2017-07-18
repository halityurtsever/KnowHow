
namespace DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Evaluators
{
    public abstract class RankEvaluator
    {
        //################################################################################
        #region Abstract Members

        public abstract bool EvaluateRank(Hand hand);

        #endregion

        //################################################################################
        #region Protected Implementation

        protected bool IsStraight(Hand hand)
        {
            for (int i = 0; i < 4; i++)
            {
                if (hand[i].Value - hand[i + 1].Value != 1)
                {
                    return false;
                }
            }

            return true;
        }

        protected bool IsAllOfSameSuit(Hand hand)
        {
            var firstCardSuit = hand[0].Suit;

            foreach (var card in hand.CardList)
            {
                if (card.Suit != firstCardSuit)
                {
                    return false;
                }
            }

            return true;
        }

        #endregion
    }
}
