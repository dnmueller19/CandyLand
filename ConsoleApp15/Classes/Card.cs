using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Classes
{
	public class Card
	{
		public CandyColor Color { get; set; }
		public int Amount { get; set; }

		public bool IsSpecialty()
		{
			return Color == CandyColor.Chocolate
				|| Color == CandyColor.CupCake
				|| Color == CandyColor.Gingerbread
				|| Color == CandyColor.IceCream
				|| Color == CandyColor.IcePop
				|| Color == CandyColor.Lollipop
				|| Color == CandyColor.Star;
		}

		public bool IsStandard()
		{
			return Color == CandyColor.Yellow
				|| Color == CandyColor.Red
				|| Color == CandyColor.Purple
				|| Color == CandyColor.Orange
				|| Color == CandyColor.Green
				|| Color == CandyColor.Blue;

		}

	}
}
