using System;

using Xamarin.Forms;

namespace StackLayoutTester
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			var page = new TabbedPage ();
			page.Children.Add (new NavigationPage (new MappedAddressPage ()) { Title = "Address" });
			page.Children.Add (new NavigationPage (new ButtonsPage ()) { Title = "Buttons" });

			MainPage = page;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

