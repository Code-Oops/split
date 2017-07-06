using System;
namespace split.Console.Models
{
    abstract class Creator
    {
        public abstract IGame CreateGame(GameType type);
    }
}
