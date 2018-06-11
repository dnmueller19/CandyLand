using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Classes
{
	public class BoardSpace
	{
		//Properties of Board Spaces

		public CandyColor Color { get; set; }
		public int Position { get; set; }
		public bool IsLicorice { get; set; }
		public int? ShortcutDesination { get; set; }

	}
}
