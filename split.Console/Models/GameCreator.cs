using System;
using System.ComponentModel;
using split.Console.Models;
using split.Console.Models.Blackjack;

namespace split.Console.Models
{
    class GameCreator : Creator
    {
        public override ICreateGame CreateGame(GameType type)
        {
            switch (type)
            {
                case GameType.Blackjack:
                    {
                        return new BlackjackGame();
                    }

                default:
                    {
                        throw new Exception();
                    }

            }
        }
    }
}
