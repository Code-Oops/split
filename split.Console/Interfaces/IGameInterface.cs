﻿using System;
using System.Collections.Generic;

namespace split.Console.Interfaces
{
    /// <summary>
    /// This interface is a very rough draft. It will eventually be implemented by a Game
    /// controller. This interface encapsulates game-centered actions. 
    /// </summary>
    public interface IGameInterface
    {
        /// <summary>
        /// This will launch the Game object containing all necessary information
        /// about the game. It takes a game name as an argument. This will initialize the game. 
        /// The API call from the front end could be /game/{name}/launch? 
        /// </summary>
        /// <returns>An object that implements IGameInterface. </returns>
        IGameInterface launch(string name);

        /// <summary>
        /// This is an alternative to the method above. It doesn't return anything. 
        /// </summary>
        void launch_alternative(string name);

        /// <summary>
        /// The API for this could be /game/pot. 
        /// </summary>
        /// <returns>Returns the amount that is in the pot. </returns>
        int GetPot();

        /// <summary>
        /// Gets the players in the game
        /// </summary>
        /// <returns>A collection of objects that implement IPlayerInterface</returns>
        List<IPlayerInterface> GetPlayers();
    }
}
