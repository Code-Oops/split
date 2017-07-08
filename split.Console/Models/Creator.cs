using System;
using split.Console.Interfaces;

namespace split.Console.Models
{
    public abstract class Creator
    {
        public abstract IGame CreateGame(GameType type);
    }
}
