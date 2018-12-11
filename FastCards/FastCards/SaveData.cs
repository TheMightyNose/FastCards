﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FastCards
{
    static class SaveData
    {
		public static void SaveDeckUserPeformance(List<Card> deck, int learnedItems, string deckName)
		{
			string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), deckName);

			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(fileName, FileMode.Create)))
			{
				binaryWriter.Write(learnedItems);

				foreach (Card card in deck)
				{
					foreach (float time in card.timeUsed)
					{
						binaryWriter.Write(time);
					}
				}
			}
		}

		public static void ReadDeckUserPerformance( List<Card> oldDeck, string deckName, out int learnedItems, out List<Card> newDeck)
		{
			newDeck = new List<Card>(oldDeck);

			string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), deckName);

			using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(fileName)))
			{
				learnedItems = binaryReader.ReadInt32();

				for (int i = 0; i < learnedItems; i++)
				{
					newDeck[i].timeUsed.Clear();
					for (int j = 0; j < Card.timesMeasured; j++)
					{
						newDeck[i].timeUsed.Enqueue(binaryReader.ReadSingle());
					}
				}
			}
		}
    }
}