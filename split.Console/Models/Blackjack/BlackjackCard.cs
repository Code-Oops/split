using System;
namespace split.Console.Models.Blackjack
{
    public class BlackjackCard
    {
        public SuitType Suit;
        public int Rank;        //TODO Decide if this would be better as an enum

        public BlackjackCard(SuitType suit, int rank)
        {
            Suit = suit;
            Rank = rank;
        }
    }
}
