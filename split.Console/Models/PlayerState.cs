using System;
namespace split.Console.Models
{
    public enum PlayerState
    {
        Lobby,
        Game,
        Dropped,    //Player has left game but game is still active
        Finished    //Game has ended
    }
}
