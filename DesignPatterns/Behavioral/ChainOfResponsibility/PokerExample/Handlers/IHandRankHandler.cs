using DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Enums;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Handlers
{
    public interface IHandRankHandler
    {
        Rank EvaluateHandRank(Hand hand);

        void RegisterNext(IHandRankHandler nextHandler);
    }
}
