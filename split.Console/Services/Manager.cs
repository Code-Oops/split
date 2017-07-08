using System;
using split.Console.Interfaces;

namespace split.Console.Services
{
    public class Manager : IManager
    {
        private IGame _game;
        private Guid _id;

        public Guid RegisterGame(IGame game)
        {
            _game = game;
			//Code = GenerateRoomCode();
            _id = new Guid();

            return _id;
            //return _game.StartGame();
        }

        public bool RegisterPlayer (Guid id)
        {
            // get game
            // register player
            // updates the repository
            // return playerid

            return true;
        }


        public void AccessGame(Guid id)
        {
            
        }


    }
}
