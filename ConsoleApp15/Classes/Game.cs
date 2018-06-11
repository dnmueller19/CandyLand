using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp15.Classes;

namespace ConsoleApp15.Classes
{
	public class Game
	{
		public Game_Board Board { get; set; }
		public CardDeck Deck { get; set; }
		public List<Players> Players { get; set; }
		public int CurrentPlayer { get; set; }
		public bool IsStarted { get; set; }


		public Game()
		{
			Board = new Game_Board();
			Deck = new CardDeck();
			Players = new List<Players>();
		}

		public void AddPlayer(string name)
		{
			if (!IsStarted && Players.Count < 4)
			{
				Players.Add(new Players() { Name = name });
			}
		}

		public void StartGame()
		{
			if (Players.Count >= 2 && Players.Count <= 4)
			{
				IsStarted = true;
			}
		}

		public string NextMove()
		{
			if (IsStarted)
			{
				var player = Players[CurrentPlayer];
				var message = player.TakeTurn(Board, Deck);
				CurrentPlayer++;

				if (CurrentPlayer > Players.Count - 1)
				{
					CurrentPlayer = 0;
				}

				return message;
			}
			return "game has not started";
		}
	}
}
