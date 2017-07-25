using System.Collections.Generic;

namespace split.Console.Models.Blackjack
{
    public class BlackjackPlayer : Player
    {
        public int Bet;
        List<Card> Cards;
        bool _hasAce;

        public BlackjackPlayer(string name, string code) : base(name, code)
        {
            Bet = 0;
            Cards = new List<Card>();
        }

        //Temporary to suppress warning message
        public bool GetHasAce()
        {
            return _hasAce & true;
        }

        /// <summary>
        /// Adds a card to the player's hand
        /// </summary>
        /// <param name="newCard">Card to be added to hand</param>
        public void AddCardToHand(Card newCard)
        {
            Cards.Add(newCard);
            if (newCard.GetRank() == RankType.Ace)
            {
                _hasAce = true;
            }
        }

        /// <summary>
        /// Clears all cards from players hand and resets having ace value
        /// </summary>
        public void ClearHand()
        {
            Cards.Clear();
            _hasAce = false;
        }

        /// <summary>
        /// Calculates and returns the value of the player's hand
        /// </summary>
        /// <returns>Maximum value of the players hand</returns>
        public int Value()
        {
            int val = 0;
            foreach (Card card in Cards)
            {
                //If we can take ace as value 11, do it. We will show the
                //two possible values of it in the UI using _hasAce
                if (card.GetRank() == RankType.Ace && ((val + 11) <= 21))
                {
                    val += 11;
                }
                else
                {
                    val += card.GetValue();
                }
            }
            return val;
        }

        /// <summary>
        /// Calculates number of cards in players hand
        /// </summary>
        /// <returns>Number of cards in hand</returns>
        public int NumberCardsInHand()
        {
            return Cards.Count;
        }


        /// <summary>
        /// Returns whether the player has busted
        /// </summary>
        /// <returns>True if the player has busted</returns>
        public bool IsBusted()
        {
            return Value() > 21;
        }
    }
}
