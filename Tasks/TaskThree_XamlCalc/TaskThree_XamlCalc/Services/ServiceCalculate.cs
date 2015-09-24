using System;

using Xamarin.Forms;
using System.Text.RegularExpressions;

namespace TaskThree_XamlCalc
{
	public static class ServiceCalculate
	{
		public static string  Calculate (string localTexCalc)
		{
			string stringSymbol = Regex.Replace (localTexCalc, @"([0-9])", "");
			char[] charSymbolArray = stringSymbol.ToCharArray ();

			string[] stringSeparators = new string[] { "*", "+", "-" };
			string[] stringDateArray = localTexCalc.Split (stringSeparators, StringSplitOptions.None);

			localTexCalc = "";

			double _count = Convert.ToDouble (stringDateArray [0]);
			for (int i = 0; i < stringDateArray.Length - 1; i++) {

				switch (charSymbolArray [i]) {
				case '+':
					_count = _count + Convert.ToDouble (stringDateArray [i + 1]);
					break;
				case '-':
					_count = _count - Convert.ToDouble (stringDateArray [i + 1]);
					break;
				case '*':
					_count = _count * Convert.ToDouble (stringDateArray [i + 1]);
					break;
				default:
					_count = Convert.ToDouble (stringDateArray [i]);
					break;
				}
			}
			return _count.ToString ();
		}
	}
}


