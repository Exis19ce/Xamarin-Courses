using System;
using Xamarin.Forms;

namespace TaskTwo_AppOnXamarinForms
{
	public class MainPage : ContentPage
	{
		public MainPage ()
		{
			Content = new MainView ();
			Padding = new Thickness (0, Device.OnPlatform (20, 0, 0), 0, 0);
		}
	}
}

