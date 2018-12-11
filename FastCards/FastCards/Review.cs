using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FastCards
{
    static class Review
    {
		static public void NewQuestion(MainPage mp)
		{
			if (mp.deck[mp.currentCard].meaning != "" && !mp.meaning)
			{
				mp.meaning = true;
			}
			else
			{
				mp.meaning = false;
				mp.currentCard = NextCard.Pick(mp.deck);
			}

			if (mp.meaning)
			{
				mp.Question.Text = "Meaning: " + mp.deck[mp.currentCard].front;
			}
			else
			{
				mp.Question.Text = "Reading " + mp.deck[mp.currentCard].front;
			}
			mp.Answer.Text = "";
			mp.Button.Text = "Check Answer";

			mp.stopwatch.Start();
		}

		static public void ShowAnswer(MainPage mp)
		{
			if (mp.Input.Text.ToLower() == (mp.meaning ? mp.deck[mp.currentCard].meaning : mp.deck[mp.currentCard].reading).ToLower())
			{
				mp.deck[mp.currentCard].SaveScore(true, mp.stopwatch.ElapsedMilliseconds / 1000.0f);
				mp.Answer.Text = "correct!" + " \nAvg time:" + mp.deck[mp.currentCard].timeUsed.Average();
			}
			else
			{
				mp.deck[mp.currentCard].SaveScore(false, mp.stopwatch.ElapsedMilliseconds / 1000.0f);
				mp.Answer.Text = "Wrong! " + (mp.meaning ? mp.deck[mp.currentCard].meaning : mp.deck[mp.currentCard].reading) + " \nAvg time:" + mp.deck[mp.currentCard].timeUsed.Average();
			}
			mp.Button.Text = "Next Question";
			mp.Input.Text = "";
			mp.stopwatch.Reset();
		}
    }
}
