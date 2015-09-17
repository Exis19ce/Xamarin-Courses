using System;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TaskTwo_AppOnXamarinForms;

[assembly: Xamarin.Forms.Dependency (typeof(CounterService))]
namespace TaskTwo_AppOnXamarinForms
{
	public class CounterService: INotifyPropertyChanged, ICounterService
	{
		private double _Amount;
		private double _TipPrecentage = 17;


		public CounterService ()
		{
		}

		public double Amount {
			get { return _Amount; }
			set {
				_Amount = value;
				CountingTip ();
				NotifyPropertyChanged ();

			}
		}

		public string TipPrecentage { 
			get {
				return _TipPrecentage.ToString ();
			}
		}

		public double TipAmount { get; set; }

		public double TotalAmount { get; set; }

		private void CountingTip ()
		{
			TipAmount = (Amount / 100) * 17;
			TotalAmount = Amount + TipAmount;
		}



		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void NotifyPropertyChanged ([CallerMemberName]string propertyName = null)
		{
			if (PropertyChanged != null) {
				PropertyChanged (this, new PropertyChangedEventArgs (propertyName));
			}
		}


	}
}

