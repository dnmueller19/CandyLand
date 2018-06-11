using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Classes
{
	public class CardDeck
	{

		private List<Card> Cards { get; set; }

		public CardDeck()
		{
			CreateDeck();
			Shuffle();
		}
		
		private void CreateDeck()
		{ //add to my lsit of cards
			Cards = new List<Card>();
			for (int i = 1; i < +6; i++)
			{
				//speciality cards
				if (i <= 1)
				{
					Cards.Add(new Card() { Color = CandyColor.CupCake, Amount = 1 });
					Cards.Add(new Card() { Color = CandyColor.IceCream, Amount = 1 });
					Cards.Add(new Card() { Color = CandyColor.Chocolate, Amount = 1 });
					Cards.Add(new Card() { Color = CandyColor.Lollipop, Amount = 1 });
					Cards.Add(new Card() { Color = CandyColor.IcePop, Amount = 1 });
					Cards.Add(new Card() { Color = CandyColor.Star, Amount = 1 });
					Cards.Add(new Card() { Color = CandyColor.Gingerbread, Amount = 1 });
				}

				if (i <= 3)
				{
					Cards.Add(new Card() { Color = CandyColor.Green, Amount = 2 });
					Cards.Add(new Card() { Color = CandyColor.Blue, Amount = 2 });
				}

				if (i <= 4)
				{
					Cards.Add(new Card() { Color = CandyColor.Red, Amount = 2 });
					Cards.Add(new Card() { Color = CandyColor.Yellow, Amount = 2 });
					Cards.Add(new Card() { Color = CandyColor.Orange, Amount = 2 });
					Cards.Add(new Card() { Color = CandyColor.Purple, Amount = 2 });
				}

				if (i <= 5)
				{
					Cards.Add(new Card() { Color = CandyColor.Yellow, Amount = 1 });
				}

				if (i <= 6)
				{
					Cards.Add(new Card() { Color = CandyColor.Red, Amount = 1 });
					Cards.Add(new Card() { Color = CandyColor.Orange, Amount = 1 });
					Cards.Add(new Card() { Color = CandyColor.Blue, Amount = 1 });
					Cards.Add(new Card() { Color = CandyColor.Green, Amount = 1 });
					Cards.Add(new Card() { Color = CandyColor.Purple, Amount = 1 });

				}
			}

		}

		public void Shuffle()
		{
			Random shfle = new Random();
			int length = Cards.Count; //pulls from my card list

			//cycle through cards
			while (length > 1)
			{
				length--;
				int x = shfle.Next(length + 1); //assigns a random number to the cards
				Card value = Cards[x]; //remove card at the [x] index
				Cards[x] = Cards[length]; //takes card from current index [x] and places it into my random index
				Cards[length] = value;  //takes card from random index and places at current index
			}
		}

		public Card Draw()
		{
			if (!Cards.Any())
			{
				CreateDeck();
				Shuffle();
			}
			var card = Cards.First();
			Cards.RemoveAt(0);
			return card;
		}


	}
}
