using System;
using System.ComponentModel;
using Xunit;
using split.Console.Models;
using split.Console.Models.Blackjack;
using split.Console.Models.Poker;

namespace split.Console.Tests.Models
{
    public class GameTestsShould
    {
        [Fact]
        public void CreateBlackjackGameObject()
        {
            GameCreator creator = new GameCreator();
            IGame game = creator.CreateGame(GameType.Blackjack);
            Assert.IsType<BlackjackGame>(game);
        }

        [Fact]
        public void CreatePokerGameObject()
        {
            GameCreator creator = new GameCreator();
            IGame game = creator.CreateGame(GameType.Poker);
            Assert.IsType<PokerGame>(game);
        }

        [Fact]
        public void ThrowAnExceptionOnCreationOfNoneGameType()
        {
            GameCreator creator = new GameCreator();
            var exception = Record.Exception(() => creator.CreateGame(GameType.None));
            Assert.NotNull(exception);
            Assert.IsType<Exception>(exception); 
        }
    }
}
