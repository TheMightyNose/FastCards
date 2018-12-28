using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;
using System.IO;

namespace FastCards
{
	public partial class ReviewPage : ContentPage
	{
		public static bool learningMode = false;

		public Stopwatch stopwatch = new Stopwatch();
		public bool meaning = true;
		public int currentCard = 0;
		public Deck deck = new Deck();
		bool newQuestion = true;
		App handle;
		//const string file = "test.dat";

		public ReviewPage(App handle)
		{
			this.handle = handle;
			InitializeComponent();

			deck = JapaneseVerbs.Load();

			deck.learnedCards = 0;
 
			string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), deck.name + ".dat");

			if (File.Exists(fileName))
			{
				deck = IO.ReadDeckUserPerformance(deck, deck.name);
			}			

			NextCard.Pick(deck);

			Review.ShowAnswer(this);
			newQuestion = true;
			Answer.Text = "";

		}

		void Button_Clicked(object sender, System.EventArgs e)
		{
			if (NextCard.allLearned)
			{
				NextCard.allLearned = false;
				deck.learnedCards += 5;
				if (deck.learnedCards > deck.cards.Count) deck.learnedCards = deck.cards.Count;

				IO.SaveDeckUserPerformance(deck);

				handle.MainPage = new MenuPage(handle);
			}
			else
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

			IO.SaveDeckUserPerformance(deck);
		}

		protected override bool OnBackButtonPressed()
		{
			handle.MainPage = new MenuPage(handle);

			return true;
		}
	}
}
