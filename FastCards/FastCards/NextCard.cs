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

		public static void CalculateAllSeeds(List<Card> deck)
		{
			totalWeight = 0;
			for(int i = 0; i < deck.Count; i++)
			{
				totalWeight += (int)deck[i].timeUsed.Average();
				deck[i].weight = totalWeight;
			}
		}

		public static int Pick(List<Card> deck)
		{
			int i;

			CalculateAllSeeds(deck);

			int bob = random.Next(0, totalWeight);

			for(i = 0; i < deck.Count; i++)
			{
				if(bob < deck[i].weight)
				{
					return i;
				}
			}

			throw new Exception("Too high random seed");
		}
    }
}
