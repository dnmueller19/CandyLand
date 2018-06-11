using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Classes
{
	public static class Extensions
	{
		public static BoardSpace GetMatchingSpace(this List<BoardSpace> spaces, int currentIndex, Card card)
		{
			if (card.IsSpecialty()) //special cards can move y9ou back and forth
			{
				var allMatches = spaces.Where(x => x.Color == card.Color);
				return allMatches.First();
			}
			else //regualr color cards only move you forward
			{
				var index = spaces.FindIndex(currentIndex + 1, x => x.Color == card.Color);
				if (index == -1)
				{
					return new BoardSpace()
					{
						Color = CandyColor.Rainbow,
						Position = 133
					};
				}
				return spaces[index];
			} 

		}

	}
}
