using System;

namespace split.Console.Models.Blackjack
{
    public class BlackjackGame : Game
    {
        Deck CardDeck;
        BlackjackPlayer Dealer;

        public BlackjackGame(int decks) : base(GameType.Blackjack)
        {
            CardDeck = new Deck(decks);
            Dealer = new BlackjackPlayer("Dealer", null);
        }

        /// <summary>
        /// Adds a newly created player to the game
        /// </summary>
        /// <param name="newPlayer">Created player to be added to the game</param>
        public void AddPlayer(BlackjackPlayer newPlayer)
        {
            Players.Add(newPlayer);
        }

        /// <summary>
        /// Puts the game into an active state
        /// </summary>
        /// <returns>True is game has been started</returns>
        public new bool StartGame()
        {
            CardDeck.Shuffle();
            return base.StartGame();
        }

        /// <summary>
        /// Deals 2 Cards to each player including the dealer
        /// </summary>
        public void DealRoundOfCards()
        {
            for (int i = 0; i < 2; i++)
            {
                foreach (BlackjackPlayer player in Players)
                {
                    player.AddCardToHand(CardDeck.DealCard());
                }
                Dealer.AddCardToHand(CardDeck.DealCard());
            }
        }

        public void MakeMove(BlackjackPlayer player, BlackjackMove move, int bet = 0)
        {
            switch (move)
            {
                case BlackjackMove.Bet:
                    Bet(player, bet);
                    break;
                case BlackjackMove.Hit:
                    Hit(player);
                    break;
                case BlackjackMove.Double:
                    Double(player);
                    break;
                case BlackjackMove.Split:
                    throw new NotImplementedException("Split is not implemented");
                default:
                    throw new Exception("Invalid Blackjack move");
            }
        }

        /// <summary>
        /// Sets the bet amount for the player
        /// </summary>
        /// <param name="player">Player who is up</param>
        /// <param name="bet">Amount to be bet</param>
        public void Bet(BlackjackPlayer player, int bet)
        {
            player.Bet = bet;
        }

        /// <summary>
        /// Hits for the designated player
        /// </summary>
        /// <param name="player">Player who is up</param>
        public void Hit(BlackjackPlayer player)
        {
            Card newCard = CardDeck.DealCard();
            player.AddCardToHand(newCard);
        }

        /// <summary>
        /// Doubles the players bet and gives them one more hit
        /// </summary>
        /// <param name="player">Player who is up</param>
        public void Double(BlackjackPlayer player)
        {
            player.Bet *= 2;
            Hit(player);
        }
    }
}
