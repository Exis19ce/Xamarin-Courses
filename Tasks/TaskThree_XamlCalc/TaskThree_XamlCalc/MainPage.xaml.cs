using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace TaskThree_XamlCalc
{
	public partial class MainPage : ContentPage, INotifyPropertyChanged
	{
		public MainPage ()
		{
			InitializeComponent ();
			this.Padding = new Thickness (0, Device.OnPlatform (20, 0, 0), 0, 0);
		}
	
	}
}

