using System;
using System.ComponentModel;
using split.Console.Interfaces;
using split.Console.Models;
using split.Console.Models.Blackjack;
using split.Console.Models.Poker;
using split.Console.Services;

namespace split.Console.Models
{ 
    public class GameCreator : Creator
    {
        public override IGame CreateGame(GameType type)
        {
            switch (type)
            {
                case GameType.Blackjack:
                    {
                        return new BlackjackGame();
                    }
                case GameType.Poker:
                    {
                        return new PokerGame();
                    }

                default:
                    {
                        throw new Exception();
                    }

            }
        }
    }
}
