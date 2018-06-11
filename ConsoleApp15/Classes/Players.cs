using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp15.Classes;



namespace ConsoleApp15.Classes
{
	public class Players
	{
		//Propertie of Player class

		public string Name { get; set; }
		public int CurrentLocation { get; set;}
		public int Order { get; set; }
		public bool IsSkipped { get; set; }
		public bool IsWinner { get; set; }


		/// <summary>
		/// players turn METHOD
		/// </summary>
		/// <param name="board"></param>
		/// <param name="deck"></param>
		/// <returns></returns>
		public string TakeTurn(Game_Board board, CardDeck deck)
		{
			//skip with licoris
			if (IsSkipped)
			{
				IsSkipped = false;
				return Name + "was skipped";
			}
			var card = deck.Draw();
			int matchingIndex = CurrentLocation;
			var space = board.Spaces.GetMatchingSpace(CurrentLocation, card);
			CurrentLocation = space.Position; //move to the space defined by the card drawn
			string message = Name + " moved to Space " + CurrentLocation.ToString() + " which is a " + space.Color.ToString() + " space";

			//Player is stuck

			if (space.IsLicorice)
			{
				IsSkipped = true;
				message += Name + " is stuck in Licorice";
			}

			if (space.ShortcutDesination.HasValue) // Player Landed on shortcut
			{
				CurrentLocation = space.ShortcutDesination.Value;
				message += Name + " took a shortcut to space " + CurrentLocation.ToString() + "!";
			}

			//palyer won the game

			if (CurrentLocation == 133)
			{
				IsWinner = true;
				message += Name + " has won the game";
			}
			return message;
		}
	}
	

	

}
