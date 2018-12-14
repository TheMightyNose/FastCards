using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FastCards
{
    static class IO
    {
		public static void SaveDeckUserPerformance(Deck deck)
		{
			string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), deck.name + ".dat");

			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(fileName, FileMode.Create)))
			{
				binaryWriter.Write(deck.learnedCards);

				foreach (Card card in deck.cards)
				{
					foreach (float time in card.timeUsed)
					{
						binaryWriter.Write(time);
					}
				}
			}
		}

		public static Deck ReadDeckUserPerformance(Deck deck, string deckName)
		{
			string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), deckName + ".dat");

			using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(fileName)))
			{
				deck.learnedCards = binaryReader.ReadInt32();

				for (int i = 0; i < deck.learnedCards; i++)
				{
					deck.cards[i].timeUsed.Clear();

					for (int j = 0; j < deck.cards[i].timesMeasured; j++)
					{
						deck.cards[i].timeUsed.Enqueue(binaryReader.ReadSingle());
					}
				}
			}

			return deck;
		}
    }
}
