using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FastCards
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
		private App handle;
		public MenuPage (App handle)
		{
			this.handle = handle;
			InitializeComponent ();
		}

		void GoToReviews(object sender, System.EventArgs e)
		{
			handle.MainPage = new ReviewPage(handle);
			ReviewPage.learningMode = false;
		}

		void GoToLearning(object sender, System.EventArgs e)
		{
			handle.MainPage = new ReviewPage(handle);
			ReviewPage.learningMode = true;
		}
	}
}