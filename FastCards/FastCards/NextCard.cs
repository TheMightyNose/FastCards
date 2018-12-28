using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FastCards
{
	static class NextCard
    {
		public static bool allLearned = false;

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

		public static void CalculateLessonSeeds(Deck deck)
		{
			totalWeight = 0;
			int learningCards = deck.learnedCards + 5;
			allLearned = true;

			if (learningCards > deck.cards.Count) learningCards = deck.cards.Count;

			for (int i = deck.learnedCards; i < learningCards; i++)
			{
				totalWeight += (int)deck.cards[i].timeUsed.Average();
				if ((int)deck.cards[i].timeUsed.Average() > Card.learnedTime)
				{
					allLearned = false;
				} 
				deck.cards[i].weight = totalWeight;
			}
		}

		public static int Pick(Deck deck)
		{
			int i;
			
			if(ReviewPage.learningMode == true)
			{
				CalculateLessonSeeds(deck);

				int learningCards = deck.learnedCards + 5;

				if (learningCards > deck.cards.Count) learningCards = deck.cards.Count;

				int selectedCard = random.Next(0, totalWeight);

				for (i = deck.learnedCards; i < learningCards; i++)
				{
					if (selectedCard < deck.cards[i].weight)
					{
						return i;
					}
				}
			}
			else
			{
				CalculateAllSeeds(deck);

				int selectedCard = random.Next(0, totalWeight);

				for (i = 0; i < deck.cards.Count; i++)
				{
					if (selectedCard < deck.cards[i].weight)
					{
						return i;
					}
				}
			}

			throw new Exception("Too high random seed");
		}
    }
}
