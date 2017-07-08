using System;
namespace split.Console.Models.Poker
{
    public class PokerGame : IGame
    {
        public PokerGame()
        {
        }

        public VictoryType HaveIWon(Card[] hand)
        {
            throw new NotImplementedException();
        }

        public void ResetThePot()
        {
            throw new NotImplementedException();
        }

        void IGame.AddToThePot(int sum)
        {
            throw new NotImplementedException();
        }

        Card IGame.DealCard()
        {
            throw new NotImplementedException();
        }

        int IGame.GetThePot()
        {
            throw new NotImplementedException();
        }
    }
}
