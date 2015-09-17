using System;
using System.ComponentModel;

namespace TaskTwo_AppOnXamarinForms
{
	public interface ICounterService
	{
		double Amount{ get; set; }

		string TipPrecentage{ get; }

		double TipAmount{ get; set; }

		double TotalAmount{ get; set; }

		event PropertyChangedEventHandler PropertyChanged;

	}
}

