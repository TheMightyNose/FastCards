using System;
using System.Collections.Generic;
using System.Text;

namespace FastCards
{
	class TestDeck
	{
		public static List<Card> Load()
		{
			List<Card> deck = new List<Card>
			{
				new Card("神様", "kamisama", "god"),
				new Card("front", "back"),
				new Card("monkey", "gorilla"),
				new Card("test", "debug"),
				new Card("reee", "REEE"),
				new Card("hiragana", "katakana")
			};

			return deck;
		}
    }
}
