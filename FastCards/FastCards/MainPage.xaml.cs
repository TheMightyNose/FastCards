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
		Card[] cards = new Card[5];
		int currentCard = 0;
		public MainPage()
		{
			InitializeComponent();
			cards[0] = new Card("front", "back");
			cards[1] = new Card("monkey", "gorilla");
			cards[2] = new Card("test", "debug");
			cards[3] = new Card("reee", "REEE");
			cards[4] = new Card("hiragana", "katakana");
			Question.Text = cards[currentCard].front;
		}

		void Button_Clicked(object sender, System.EventArgs e)
		{
			if (Input.Text == cards[currentCard].back)
			{
				Answer.Text = "correct!";
			}
			else
			{
				Answer.Text = "Wrong! " + cards[currentCard].back;
			}

			currentCard++;

			if (currentCard >= 5)
			{
				currentCard = 0;
			}

			Question.Text = cards[currentCard].front;
		}
	}
}
