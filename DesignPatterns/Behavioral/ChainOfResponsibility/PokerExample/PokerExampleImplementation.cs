using System;

using DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Evaluators;
using DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample.Handlers;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.PokerExample
{
    public static class PokerExampleImplementation
    {
        public static void Execute()
        {
            Game game = new Game();
            game.CreateNewTable();
            game.AddNewHand();
            game.AddNewHand();
            game.AddNewHand();
            game.AddNewHand();

            IHandRankHandler royalFlushHandler = new HandRankHandler(new RoyalFlushEvaluator());
            IHandRankHandler straightFlushHandler = new HandRankHandler(new StraightFlushEvaluator());
            IHandRankHandler fourOfAKindHandler = new HandRankHandler(new FourOfAKindEvaluator());
            IHandRankHandler fullHouseHandler = new HandRankHandler(new FullHouseEvaluator());
            IHandRankHandler flushHandler = new HandRankHandler(new FlushEvaluator());
            IHandRankHandler straightHandler = new HandRankHandler(new StraightEvaluator());
            IHandRankHandler threeOfAKindHandler = new HandRankHandler(new ThreeOfAKindEvaluator());
            IHandRankHandler twoPairsHandler = new HandRankHandler(new TwoPairsEvaluator());
            IHandRankHandler onePairHandler = new HandRankHandler(new OnePairEvaluator());

            royalFlushHandler.RegisterNext(straightFlushHandler);
            straightFlushHandler.RegisterNext(fourOfAKindHandler);
            fourOfAKindHandler.RegisterNext(fullHouseHandler);
            fullHouseHandler.RegisterNext(flushHandler);
            flushHandler.RegisterNext(straightHandler);
            straightHandler.RegisterNext(threeOfAKindHandler);
            threeOfAKindHandler.RegisterNext(twoPairsHandler);
            twoPairsHandler.RegisterNext(onePairHandler);
            onePairHandler.RegisterNext(EndOfChainHandler.Instance);

            foreach (var gameHand in game.Hands)
            {
                gameHand.HandRank = royalFlushHandler.EvaluateHandRank(gameHand);
            }

            foreach (var gameHand in game.Hands)
            {
                Console.WriteLine(gameHand);
            }
        }
    }
}
