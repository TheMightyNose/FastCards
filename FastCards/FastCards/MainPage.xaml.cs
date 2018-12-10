using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FastCards
{
	public partial class MainPage : ContentPage
	{
		bool meaning;
		int currentCard = 0;
		List<Card> deck = new List<Card>();
		public MainPage()
		{
			InitializeComponent();

			deck = TestDeck.Load();
			
			Question.Text = deck[currentCard].front;
		}

		void Button_Clicked(object sender, System.EventArgs e)
		{
			if (Input.Text == (meaning ? deck[currentCard].meaning : deck[currentCard].reading))
			{
				Answer.Text = "correct!";
			}
			else
			{
				Answer.Text = "Wrong! " + (meaning ? deck[currentCard].meaning : deck[currentCard].reading);
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
		}
	}
}
