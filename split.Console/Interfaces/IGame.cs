using System;
using split.Console.Models;

namespace split.Console
{
	public interface IGame
	{
        Card DealCard();
        int GetThePot();
        void AddToThePot(int sum);
        void ResetThePot();
        VictoryType HaveIWon(Card[] hand);
	} 
}