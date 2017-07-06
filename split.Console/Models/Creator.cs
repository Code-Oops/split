using System;
namespace split.Console.Models
{
    abstract class Creator
    {
        public abstract ICreateGame CreateGame(GameType type);
    }
}
