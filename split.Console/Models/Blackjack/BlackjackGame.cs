using System;
using split.Console.Interfaces;
using split.Console.Models;

namespace split.Console.Models.Blackjack
{
    public class BlackjackGame : IGame
    {
        protected internal Deck _deck;
        private Player _player;
        private int numDecks = 1;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:split.Console.Models.Blackjack.BlackjackGame"/> class.
        /// </summary>
        public BlackjackGame()
        {
            _deck = new Deck(numDecks); // todo: the number of decks should probably come from somewhere like GameSetting
            _deck.Shuffle(); 
        }

        /// <summary>
        /// Deals the card.
        /// </summary>
        /// <returns>The card.</returns>
        public Card DealCard()
        {
            return _deck.DealCard();
        }
       

        /// <summary>
        /// Determines if the Player has gotten Twenty One points. 
        /// </summary>
        /// <returns>The VictoryType Enum</returns>
        /// <param name="hand">Hand</param>
        public VictoryType HaveIWon(Card[] hand)
        {
            //todo: include the Ace, which can be either 1 point or 11 points. 
            int sum = 0;
            foreach (var card in hand)
            {
                if (IsFaceCard(card))
                {
                    sum = sum + 10;
                }
                else
                {
                    sum = sum + (int)card.GetRank();
                }
            }
            return CheckTheSum(sum);
        }

        /// <summary>
        /// Checks to see if the Card is the face card.
        /// </summary>
        /// <returns><c>true</c>, if face card is a face card, <c>false</c> otherwise.</returns>
        /// <param name="card">Card.</param>
        private bool IsFaceCard(Card card)
        {
			if ((int)card.GetRank() > 10)
			{
                return true;
			}
            return false;
        }
        /// <summary>
        /// Checks if the sum is 21.
        /// </summary>
        /// <returns>TwentyOne if the sum is 21. Under if it is less than 21. Otherwise, 
        /// Over. </returns>
        /// <param name="sum">The sum.</param>
        private VictoryType CheckTheSum(int sum)
        {
            if (sum > 21)
            {
                return VictoryType.Over;
            }
            else if (sum < 21)
            {
                return VictoryType.Under;
            }
            else 
            {
                return VictoryType.TwentyOne;
            }
        }


       /* Don't really need to implement these, but need them to use the interface. 
            Maybe these should be moved into a separate class and only used
            by games that use the Pot. 
        */
        public int GetThePot()
        {
            throw new NotImplementedException();
        }

        public void AddToThePot(int sum)
        {
            throw new NotImplementedException();
        }

        public void ResetThePot()
        {
            throw new NotImplementedException();
        }
    }
}
