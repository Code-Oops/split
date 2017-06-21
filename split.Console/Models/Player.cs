using System;
namespace split.Console.Models
{
    public class Player
    {
        public Guid Id;
        public Guid GameId;
        public string GameCode;
        public string DisplayName;
        public int Balance;
        public PlayerState State;

        public Player(string name, string code)
        {
            Id = new Guid(name);
            GameCode = code;
            DisplayName = name;
           
            // TODO Create GameSettings where this value would be specified and can be changed in start menu
            Balance = 1000;

            // TODO add player to game specified by game code
            GameId = Guid.Empty;
            GameCode = null;

            State = PlayerState.Lobby;
        }
    }
}
