using System;
using System.Collections.Generic;

namespace split.Console.Interfaces
{
    public interface IHaveHand
    {
		/// <summary>
		/// This method will contain Cards that Player has. 
		/// </summary>
		/// <returns>A list of objects that implement ICardInterface </returns>
		List<ICardInterface> MyHand();
    }
}
