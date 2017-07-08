using System;

namespace split.Console.Models
{
    public class Deck
    {
        Card[] Cards;
        int CardsIndex;
        const int CARDSINDECK = 52;

        public Deck(int numberDecks)
        {
            Cards = new Card[numberDecks * CARDSINDECK];
            CardsIndex = 0;

            for (int i = 0; i < numberDecks; i++)
            {
                foreach (SuitType suit in Enum.GetValues(typeof(SuitType)))
                {
					foreach (RankType rank in Enum.GetValues(typeof(RankType)))
					{
                        if (!rank.Equals(RankType.None))
                        {
                            Cards[CardsIndex++] = new Card(suit, rank);
                        }
						
					}

                }
            }
        }

        /// <summary>
        /// Shuffles Cards and sets index to top of deck
        /// </summary>
        public void Shuffle()
        {
            Random rand = new Random();
            for (int n = Cards.Length - 1; n > 0; --n)
            {
                int k = rand.Next(n + 1);
                var temp = Cards[n];
                Cards[n] = Cards[k];
                Cards[k] = temp;
            }
            CardsIndex = Cards.Length - 1;
        }

        /// <summary>
        /// Gets single Card off of top of deck
        /// </summary>
        /// <returns>Card representing top of Deck</returns>
        public Card DealCard()
        {
            return Cards[CardsIndex--];
        }
        /// <summary>
        /// Gets the size of the Deck
        /// </summary>
        /// <returns>The size.</returns>

        public int GetSize()
        {
            return Cards.Length;
        }


    }
}
