using System;
using Xamarin.Forms;

namespace TaskTwo_AppOnXamarinForms
{
	public class MainView : StackLayout
	{
		private Entry TopEntry;
		private Button TopBtn;
		private Grid GridForLbl;
		private ICounterService counterService;

		public MainView ()
		{
			counterService = DependencyService.Get<ICounterService> ();

			Orientation = StackOrientation.Vertical;
			HorizontalOptions = LayoutOptions.Center;
			CreateControls ();

			Children.Add (TopEntry);
			Children.Add (TopBtn);
			Children.Add (GridForLbl);
		}

		private void CreateControls ()
		{

			TopEntry = new Entry {
				WidthRequest = 220,
				Keyboard = Keyboard.Numeric,
			};

			TopBtn = new Button {
				BackgroundColor = Color.FromHex ("B9B7B7"),
				TextColor = Color.Black,
				BorderRadius = 0,
				Text = "Calculate Tip"
			};

			TopBtn.Clicked += (object sender, EventArgs e) => {
				var res = TopEntry.Text;
				if (res != null && res.Length == 0)
					res = "0";
				
				counterService.Amount = Convert.ToDouble (res);
			};

			GridForLbl = new Grid {
				HorizontalOptions = LayoutOptions.Fill,
				RowDefinitions = {
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = GridLength.Auto },
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = GridLength.Auto },
					new ColumnDefinition { Width = GridLength.Auto },
				}
			};

			CreateLblForGrid (0, 0, text: "Tip Percentage");
			CreateLblForGrid (0, 1, text: "Tip Amount");
			CreateLblForGrid (0, 2, text: "Total Amount");
			CreateLblForGrid (1, 0, text: "17%");
			CreateLblForGrid (1, 1, binding: "TipAmount");
			CreateLblForGrid (1, 2, binding: "TotalAmount");
		}

		private void CreateLblForGrid (int column, int row, string text = null, string binding = null)
		{
			var localLabel = new Label ();

			if (text != null)
				localLabel.Text = text;

			if (binding != null)
				counterService.PropertyChanged += (sender, e) => {
					localLabel.SetBinding (Label.TextProperty, new Binding (binding, source: counterService));
				};

			GridForLbl.Children.Add (localLabel, column, row);
		}
	}
}

