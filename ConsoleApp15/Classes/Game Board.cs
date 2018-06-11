using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Classes
{
	public class Game_Board
	{
		public List<BoardSpace> Spaces { get; set; }
		public Game_Board()
		{
			Spaces = new List<BoardSpace>();

			//add standard colored game spaces

			for (int i = 1; i <= 21; i++)
			{
				Spaces.Add(new BoardSpace() { Color = CandyColor.Red });
				Spaces.Add(new BoardSpace() { Color = CandyColor.Purple });
				Spaces.Add(new BoardSpace() { Color = CandyColor.Yellow });
				Spaces.Add(new BoardSpace() { Color = CandyColor.Blue });
				Spaces.Add(new BoardSpace() { Color = CandyColor.Orange });
				Spaces.Add(new BoardSpace() { Color = CandyColor.Green });
			}

			//add in the special spaces

			Spaces.Insert(8, new BoardSpace() { Color = CandyColor.CupCake });
			Spaces.Insert(19, new BoardSpace() { Color = CandyColor.IceCream });
			Spaces.Insert(41, new BoardSpace { Color = CandyColor.Star });
			Spaces.Insert(68, new BoardSpace() { Color = CandyColor.Gingerbread });
			Spaces.Insert(91, new BoardSpace() { Color = CandyColor.Lollipop });
			Spaces.Insert(101, new BoardSpace() { Color = CandyColor.IcePop });
			Spaces.Insert(116, new BoardSpace() { Color = CandyColor.Chocolate });
			Spaces.Insert(132, new BoardSpace() { Color = CandyColor.Rainbow });

			//Licorice spaces
			Spaces.RemoveAt(44);
			Spaces.Insert(44, new BoardSpace() { Color = CandyColor.Green, IsLicorice = true });

			Spaces.RemoveAt(75);
			Spaces.Insert(75, new BoardSpace() { Color = CandyColor.Green, IsLicorice = true });

			//shortcut passages
			Spaces.RemoveAt(3);
			Spaces.Insert(3, new BoardSpace() { Color = CandyColor.Blue, ShortcutDesination = 59 });

			Spaces.RemoveAt(28);
			Spaces.Insert(28, new BoardSpace() { Color = CandyColor.Yellow, ShortcutDesination = 40 });

			//location

			int location = 0;
			foreach (var space in Spaces)
			{
				space.Position = location;
				location++;
			}
			
		}
	}
}
