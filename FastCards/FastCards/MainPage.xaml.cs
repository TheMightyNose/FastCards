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
	public partial class MainPage : ContentPage
	{
		public Stopwatch stopwatch = new Stopwatch();
		public bool meaning = true;
		public int currentCard = 0;
		public Deck deck = new Deck();
		bool newQuestion = true;
		//const string file = "test.dat";
		//string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), file);

		public MainPage()
		{
			InitializeComponent();

			deck = JapaneseVerbs.Load();

			string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), deck.name + ".dat");

			if (File.Exists(fileName))
			{
				deck = IO.ReadDeckUserPerformance(deck, deck.name);
			}
			deck.learnedCards = 5;
			NextCard.Pick(deck);
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

			IO.SaveDeckUserPerformance(deck);
		}
	}
}
