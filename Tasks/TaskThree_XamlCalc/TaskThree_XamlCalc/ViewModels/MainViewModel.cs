using System;
using System.Windows.Input;
using Xamarin.Forms;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TaskThree_XamlCalc
{
	public class MainViewModel :INotifyPropertyChanged
	{
		string tempTextCalc = "";

		public MainViewModel ()
		{
			NumberComamnd = new Command<string> (NumberClicked);
			DotComamnd = new Command (DotClicked);
			DelCommand = new Command (DeleteClicked);
			OperatorCommand = new Command<string> (OperatorClicked);
			CalculationCommand = new Command (ButtonCalculateClicked);
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged ([CallerMemberName] string propertyName = "")
		{
			PropertyChanged (this, new PropertyChangedEventArgs (propertyName));
		}

		public string TempTextCalc {
			get {
				return tempTextCalc;
			}
			set {
				if (tempTextCalc != value) {
					tempTextCalc = value;
					OnPropertyChanged ();
				}
			}
		}

		public ICommand NumberComamnd { get; private set; }

		public ICommand OperatorCommand { get; private set; }

		public ICommand DotComamnd { get; private set; }

		public ICommand DelCommand { get; private set; }

		public ICommand CalculationCommand { get; private set; }


		public void NumberClicked (string number)
		{
			TempTextCalc += number;
		}

		public void DotClicked ()
		{
			if (!tempTextCalc.Contains ("."))
				TempTextCalc += ".";
		}

		public void DeleteClicked ()
		{
			if (TempTextCalc.Length > 0)
				TempTextCalc = TempTextCalc.Remove (TempTextCalc.Length - 1);
		}

		public void OperatorClicked (string operat)
		{
			CheckLastSymbol (operat);
		}

		private void CheckLastSymbol (String symb)
		{
			if (TempTextCalc.LastIndexOf (symb) != TempTextCalc.Length - 1)
				TempTextCalc += symb;
		}

		private void ButtonCalculateClicked ()
		{
			TempTextCalc = ServiceCalculate.Calculate (TempTextCalc);
		}
	}


}

