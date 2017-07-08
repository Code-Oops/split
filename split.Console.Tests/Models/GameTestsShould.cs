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
        private GameCreator _creator;

        public GameTestsShould()
        {
            _creator = new GameCreator();
        }

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

        [Fact]
        public void HaveEmptyPot()
        {
            IGame bj = _creator.CreateGame(GameType.Poker);
            Assert.Equal(0, bj.GetThePot());
        }

		[Fact]
		public void HaveAddedToTheEmptyPot()
		{
			IGame bj = _creator.CreateGame(GameType.Poker);
            bj.AddToThePot(100);
			Assert.Equal(100, bj.GetThePot());
		}

		[Fact]
		public void HaveAddedToTheFullPot()
		{
			IGame bj = _creator.CreateGame(GameType.Poker);
			bj.AddToThePot(100);
            bj.AddToThePot(1000);
			Assert.Equal(1100, bj.GetThePot());
		}

		[Fact]
		public void HaveResetThePot()
		{
            IGame bj = _creator.CreateGame(GameType.Poker);
			bj.AddToThePot(100);
            int pot = bj.GetThePot();
            bj.ResetThePot();
            Assert.Equal(100, pot);
			Assert.Equal(0, bj.GetThePot());
		}
    }
}
