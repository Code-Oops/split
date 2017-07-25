using System;
using Xunit;
using split.Console.Models;

namespace split.Console.Tests
{
    public class DeckTests
    {
        // An empty deck should have zero objects in it.
        [Fact]
        public void CreateEmptyDeck()
        {
            Deck emptyDeck = new Deck(0);
            Assert.Equals(emptyDeck.GetSize(), 0);
        }

        // A single deck should be the size of 52 card objects. 
        [Fact]
        public void CreateASingleDeck()
        {
            Deck single = new Deck(1);
            Assert.Equals(single.GetSize(), 52);
        }

        // A double deck should be the size of 104 card objects.
        [Fact]
        public void CreateADoubleDeck()
        {
            Deck doubleDeck = new Deck(2);
            Assert.Equals(doubleDeck.GetSize(), 104)
        }

        // You shouln't be allowed to create decks with a negative number
        [Fact]
        public void UnableToCreateDeck()
        {
            Deck wrongDeck = new Deck(-100);
            Assert.Throws<ArgumentOutOfRangeException>(() => wrongDeck.GetSize());
        }
    }
}
