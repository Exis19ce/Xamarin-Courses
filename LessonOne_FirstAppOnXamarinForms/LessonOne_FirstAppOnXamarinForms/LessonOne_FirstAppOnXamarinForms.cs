using System;

using Xamarin.Forms;

namespace LessonOne_FirstAppOnXamarinForms
{
	public class App : Application
	{
		public App ()
		{

			Button b = new Button () {
				Text = "Hello",
				FontSize = 25,
				BackgroundColor = Color.Gray,
				BorderColor = Color.Aqua,
				BorderWidth = 5,
				BorderRadius = 25
			};

			b.Clicked += (sender, e) => {
				var a = 12312;
			};
				
			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						b
//						new Label {
//							XAlign = TextAlignment.Center,
//							Text = "Welcome to Xamarin Forms!"
//						}
					}
				}
			};
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

