using System;
namespace split.Console.Models
{
    public struct Card
    {
        private SuitType Suit;
        private RankType Rank;

        public Card(SuitType suit, RankType rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public SuitType GetSuit()
        {
            return Suit;
        }

        public RankType GetRank()
        {
            return Rank;
        }
    }
}
