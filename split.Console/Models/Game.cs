﻿using System;
using System.Collections.Generic;
using System.Linq;
using split.Console.Interfaces;

namespace split.Console.Models
{
    public class Game : IGame
    {
        public Guid Id;
        public string Code;
        public GameType Type;
        public List<Player> Players;
        public GameState State;

        private IGame _game;

        public Game(GameType type)
        {
            GameCreator creator = new GameCreator();
            _game = creator.CreateGame(type);
          

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

        public Card DealCard(Player player)
        {
            throw new NotImplementedException();
        }

        public int PlaceBet(Player player)
        {
            throw new NotImplementedException();
        }

        public bool HasLost(Player player)
        {
            throw new NotImplementedException();
        }

        public Card PlayCard(Player player)
        {
            throw new NotImplementedException();
        }

        public Card DealCard()
        {
            throw new NotImplementedException();
        }

        public int GetThePot()
        {
            throw new NotImplementedException();
        }

        public void AddToThePot(int sum)
        {
            throw new NotImplementedException();
        }

        public VictoryType HaveIWon(Card[] hand)
        {
            throw new NotImplementedException();
        }

        public void ResetThePot()
        {
            throw new NotImplementedException();
        }
    }
}
