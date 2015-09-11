using System;
using System.Globalization;

namespace TaskOne_WordCounter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var MyString = "this is my string";
			Console.WriteLine ("{0} = {1} word", MyString, MyString.WordCount ());
		}
	}
}
