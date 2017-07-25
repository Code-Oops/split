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

        public int GetValue()
        {
            switch (Rank)
            {
                case RankType.Ace:
                    return 1;
                case RankType.Two:
                    return 2;
                case RankType.Three:
                    return 3;
                case RankType.Four:
                    return 4;
                case RankType.Five:
                    return 5;
                case RankType.Six:
                    return 6;
                case RankType.Seven:
                    return 7;
                case RankType.Eight:
                    return 8;
                case RankType.Nine:
                    return 9;
                case RankType.Ten:
                    return 10;
                case RankType.Jack:
                    return 10;
                case RankType.Queen:
                    return 10;
                case RankType.King:
                    return 10;
                default:
                    return -1;
            }
        }
    }
}
