using System;
using System.Collections.Generic;
using System.Linq;
using split.Console.Models;

namespace split.Console.Models
{
    public class Game : ICreateGame
    {
        public Guid Id;
        public string Code;
        public GameType Type;
        public List<Player> Players;
        public GameState State;

        public Game(GameType type)
        {
            GameCreator creator = new GameCreator();
            creator.CreateGame(type);

            Code = GenerateRoomCode();
            Id = new Guid(Code);
            Type = type;
            Players = new List<Player>();
            State = GameState.Lobby;
        }

        /// <summary> 
        /// Add a player to the game lobby 
        /// </summary>
        /// <param name="player"> 
        /// Player to be added to the game 
        /// </param>
        /// <returns> 
        /// 4 character random room code 
        /// </returns>
        public bool AddPlayer(Player player)
        {
            //TODO Add player to "database"

            Players.Add(player);
            return true;
        }

        public bool StartGame()
        {
            State = GameState.Active;
            return true;
        }


        /// <summary> 
        /// Generates a random 4 alpha-numeric character code to join game with 
        /// </summary>
        /// <returns> 
        /// 4 character random room code 
        /// </returns>
        static string GenerateRoomCode()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 4)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
