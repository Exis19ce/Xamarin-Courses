using System;
using System.Globalization;

namespace TaskOne_WordCounter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var MyString = "Cuklum Xamarin Courses";
			Console.WriteLine ("{0} = {1} word", MyString, WordCounter (MyString));
		}

		private static int WordCounter (string str)
		{
			string[] strArray = str.Split (' ');
			return strArray.Length;
		}
	}
}
