using System;
using System.Collections.Generic;

namespace split.Console.Interfaces
{
    /// <summary>
    /// This interface is a very rough draft. It will eventually be implemented by an 
    /// object that will encapsulate all player-related behavior. 
    /// </summary>
    public interface IPlayerInterface : ICardInterface
    {
        /// <summary>
        /// This method will allow Player to join the game. The API call in the 
        /// implementation should be /player/join
        /// </summary>
        /// <returns>The GUID which will identify the player in the game.
        /// Alternatively, we can decide to identify the Game by GUID, which would 
        /// change this interface. </returns>
        Guid JoinGame(IGameInterface game);

        /// <summary>
        /// This method would determine if this is Player's turn. 
        /// </summary>
        /// <returns><c>true</c>, if this is Player's turn, <c>false</c> otherwise.</returns>
        bool MyTurn();

        /// <summary>
        /// This method will contain Cards that Player has. 
        /// </summary>
        /// <returns>A list of objects that implement ICardInterface </returns>
        List<ICardInterface> MyHand();

        /// <summary>
        /// Plays the card.
        /// </summary>
        /// <returns>The object that implements ICardInterface.</returns>
        ICardInterface PlayCard();

        /// <summary>
        /// Checks to see if Player is out of cards. 
        /// </summary>
        /// <returns><c>true</c>, if Player is out of cards, <c>false</c> otherwise.</returns>
        bool OutOfCards();

        /// <summary>
        /// Provides the balance based on the GUID of the Player. 
        /// </summary>
        /// <returns>The money balance. </returns>
        decimal MyBalance();

    }
}
