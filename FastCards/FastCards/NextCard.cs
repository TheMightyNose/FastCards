using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FastCards
{
    static class NextCard
    {
		public static int totalWeight;

		static Random random = new Random(); 

		public static void CalculateAllSeeds(Deck deck)
		{
			totalWeight = 0;
			for(int i = 0; i < deck.learnedCards; i++)
			{
				totalWeight += (int)deck.cards[i].timeUsed.Average();
				deck.cards[i].weight = totalWeight;
			}
		}

		public static int Pick(Deck deck)
		{
			int i;

			CalculateAllSeeds(deck);

			int bob = random.Next(0, totalWeight);

			for(i = 0; i < deck.cards.Count; i++)
			{
				if(bob < deck.cards[i].weight)
				{
					return i;
				}
			}

			throw new Exception("Too high random seed");
		}
    }
}
