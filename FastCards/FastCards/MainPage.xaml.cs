using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;

namespace FastCards
{
	public partial class MainPage : ContentPage
	{
		Stopwatch stopwatch = new Stopwatch();
		bool meaning;
		int currentCard = 0;
		List<Card> deck = new List<Card>();
		public MainPage()
		{
			InitializeComponent();

			deck = TestDeck.Load();
			
			Question.Text = deck[currentCard].front;
			stopwatch.Start();
		}

		void Button_Clicked(object sender, System.EventArgs e)
		{
			if (Input.Text == (meaning ? deck[currentCard].meaning : deck[currentCard].reading))
			{
				deck[currentCard].SaveScore(true, stopwatch.ElapsedMilliseconds / 1000.0f);
				Answer.Text = "correct!" + deck[currentCard].timeUsed.Average();
			}
			else
			{
				deck[currentCard].SaveScore(false, stopwatch.ElapsedMilliseconds / 1000.0f);
				Answer.Text = "Wrong! " + (meaning ? deck[currentCard].meaning : deck[currentCard].reading) + deck[currentCard].timeUsed.Average() ;
			}

			if (deck[currentCard].meaning != "" && !meaning)
			{
				meaning = true;
			}
			else
			{
				meaning = false;
				currentCard++;
			}

			if (currentCard >= deck.Count)
			{
				currentCard = 0;
			}

			Question.Text = deck[currentCard].front;

			stopwatch.Restart();
		}
	}
}
