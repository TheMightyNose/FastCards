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
			if (mp.deck.cards[mp.currentCard].meaning != "" && !mp.meaning)
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
			if (mp.Input.Text.ToLower() == (mp.meaning ? mp.deck.cards[mp.currentCard].meaning : mp.deck.cards[mp.currentCard].reading).ToLower())
			{
				mp.deck.cards[mp.currentCard].SaveScore(true, mp.stopwatch.ElapsedMilliseconds / 1000.0f);
				mp.Answer.Text = "correct!" + " \nAvg time:" + mp.deck.cards[mp.currentCard].timeUsed.Average();
				mp.Input.BackgroundColor = Color.DarkGreen;
			}
			else
			{
				mp.deck.cards[mp.currentCard].SaveScore(false, mp.stopwatch.ElapsedMilliseconds / 1000.0f);
				mp.Answer.Text = "Wrong! " + (mp.meaning ? mp.deck.cards[mp.currentCard].meaning : mp.deck.cards[mp.currentCard].reading) + " \nAvg time:" + mp.deck.cards[mp.currentCard].timeUsed.Average();
				mp.Input.BackgroundColor = Color.DarkRed;
			}
			mp.Button.Text = "Next Question";
			
			mp.stopwatch.Reset();
		}
    }
}
