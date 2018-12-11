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
		public Stopwatch stopwatch = new Stopwatch();
		public bool meaning;
		public int currentCard = 0;
		public List<Card> deck = new List<Card>();
		bool newQuestion = true;

		public MainPage()
		{
			InitializeComponent();

			deck = TestDeck.Load();

			Review.ShowAnswer(this);
			newQuestion = true;
			Answer.Text = "";
		}

		void Button_Clicked(object sender, System.EventArgs e)
		{
			if (newQuestion == true)
			{
				Review.NewQuestion(this);
				newQuestion = false;
			}
			else
			{ 
				Review.ShowAnswer(this);
				newQuestion = true;
			}
		}
	}
}
