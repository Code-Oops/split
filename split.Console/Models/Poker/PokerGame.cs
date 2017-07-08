﻿using System;
namespace split.Console.Models.Poker
{
    public class PokerGame : IGame
    {
        private int _pot;
		protected internal Deck _deck;
		private int numDecks = 1;

        public PokerGame()
        {
            _deck = new Deck(numDecks);
            _pot = 0;
        }

        public VictoryType HaveIWon(Card[] hand)
        {
            throw new NotImplementedException();
        }

		/// <summary>
		/// Gets the pot.
		/// </summary>
		/// <returns>The pot.</returns>
		public int GetThePot()
		{
			return _pot;
		}
		/// <summary>
		/// Adds to the pot.
		/// </summary>
		/// <param name="sum">Sum.</param>
		public void AddToThePot(int sum)
		{
			_pot = _pot + sum;
		}
		/// <summary>
		/// Resets the pot.
		/// </summary>
		public void ResetThePot()
		{
			_pot = 0;
		}

        Card IGame.DealCard()
        {
            return _deck.DealCard();
        }

      
    }
}
