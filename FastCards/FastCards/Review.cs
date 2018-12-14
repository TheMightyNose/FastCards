using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xamarin.Forms;

namespace FastCards
{
    static class Review
    {
		static public void NewQuestion(MainPage mp)
		{
			mp.Input.BackgroundColor = Color.Black;
			if (mp.deck.cards[mp.currentCard].meaning[0] != "" && !mp.meaning)
			{//reading
				mp.Question.TextColor = Color.Pink;
				mp.meaning = true;
			}
			else
			{
				mp.Question.TextColor = Color.LightCyan;
				mp.meaning = false;
				mp.currentCard = NextCard.Pick(mp.deck);
			}

			if (mp.meaning)
			{
				mp.Question.Text = "Meaning: " + mp.deck.cards[mp.currentCard].front;
			}
			else
			{
				mp.Question.Text = "Pronunciation: " + mp.deck.cards[mp.currentCard].front;
			}
			mp.Input.Text = "";
			mp.Answer.Text = "";
			mp.Button.Text = "Check Answer";

			mp.stopwatch.Start();
		}

		static public void ShowAnswer(MainPage mp)
		{
			bool correctAnswer()
			{
				if (mp.meaning)
				{
					foreach (string meaning in mp.deck.cards[mp.currentCard].meaning)
					{
						if (mp.Input.Text.ToLower() == meaning.ToLower()) return true;
					}

					return false;
				}
				else
				{
					return mp.Input.Text.ToLower() == mp.deck.cards[mp.currentCard].reading.ToLower();
				}
			}

			if (correctAnswer())
			{
				mp.deck.cards[mp.currentCard].SaveScore(true, mp.stopwatch.ElapsedMilliseconds / 1000.0f);
				mp.Answer.Text = "correct!" + " \nAvg time:" + mp.deck.cards[mp.currentCard].timeUsed.Average();
				mp.Input.BackgroundColor = Color.DarkGreen;
			}
			else
			{
				mp.deck.cards[mp.currentCard].SaveScore(false, mp.stopwatch.ElapsedMilliseconds / 1000.0f);
				string meanings = "";
				foreach (string meaning in mp.deck.cards[mp.currentCard].meaning) meanings += meaning + ", ";
				meanings = meanings.Substring(0, meanings.Length - 2);
				mp.Answer.Text = "Wrong! " + (mp.meaning ? meanings : mp.deck.cards[mp.currentCard].reading) + " \nAvg time:" + mp.deck.cards[mp.currentCard].timeUsed.Average();
				mp.Input.BackgroundColor = Color.DarkRed;
			}
			mp.Button.Text = "Next Question";
			
			mp.stopwatch.Reset();
		}
    }
}
