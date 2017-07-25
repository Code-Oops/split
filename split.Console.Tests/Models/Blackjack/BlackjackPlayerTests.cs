using Xunit;
using split.Console.Models;
using split.Console.Models.Blackjack;

namespace split.Console.Tests.Models.Blackjack
{
    public class BlackjackPlayerTests
    {
        // A player should be able to be dealt a card
        [Fact]
        public void HasOneCard()
        {
            Card card = new Card(SuitType.Club, RankType.Ace);
            BlackjackPlayer player = new BlackjackPlayer("Test", "");
            player.AddCardToHand(card);

            Assert.Equal(1, player.NumberCardsInHand());
        }

        // A player should be busted if they have a sum of 23
        [Fact]
        public void PlayerBusts()
        {
            Card king = new Card(SuitType.Club, RankType.King);
            Card queen = new Card(SuitType.Club, RankType.Queen);
            Card three = new Card(SuitType.Club, RankType.Three);
            BlackjackPlayer player = new BlackjackPlayer("Test", "");

            player.AddCardToHand(king);
            player.AddCardToHand(queen);
            player.AddCardToHand(three);

            Assert.True(player.IsBusted());
        }

        // A player should have value of 20
        [Fact]
        public void HandHasCorrectValue()
        {
            Card king = new Card(SuitType.Club, RankType.King);
            Card queen = new Card(SuitType.Club, RankType.Queen);
            BlackjackPlayer player = new BlackjackPlayer("Test", "");

            player.AddCardToHand(king);
            player.AddCardToHand(queen);

            Assert.Equal(20, player.Value());
        }

        // A player's hand should be able to be cleared
        [Fact]
        public void CanClearHand()
        {
            Card king = new Card(SuitType.Club, RankType.King);
            Card queen = new Card(SuitType.Club, RankType.Queen);
            BlackjackPlayer player = new BlackjackPlayer("Test", "");

            player.AddCardToHand(king);
            player.AddCardToHand(queen);
            player.ClearHand();

            Assert.Equal(0, player.NumberCardsInHand());
        }

        // A player's cleared hand should have no value
        [Fact]
        public void ClearedHandHasNoValue()
        {
            Card king = new Card(SuitType.Club, RankType.King);
            Card queen = new Card(SuitType.Club, RankType.Queen);
            BlackjackPlayer player = new BlackjackPlayer("Test", "");

            player.AddCardToHand(king);
            player.AddCardToHand(queen);
            player.ClearHand();

            Assert.Equal(0, player.Value());
        }
    }
}
