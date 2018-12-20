using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FastCards
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			MainPage = new MenuPage(this);
		}

		protected override void OnStart()
		{
		
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			//MainPage = currentPage;
			// Handle when your app resumes
		}
	}
}
