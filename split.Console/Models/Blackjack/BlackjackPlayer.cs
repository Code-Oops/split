using System;
using split.Console.Interfaces;
using System.Collections.Generic;

namespace split.Console.Models.Blackjack
{
    public class BlackjackPlayer : Player
    {
        public int Bet;
        public List<BlackjackCard> Cards;


        public BlackjackPlayer(string name, string code) : base(name, code)
        {
            Bet = 0;
            Cards = new List<BlackjackCard>();
        }
    }
}
