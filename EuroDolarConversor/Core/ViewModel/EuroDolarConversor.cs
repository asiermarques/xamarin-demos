using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Cirrious.MvvmCross.ViewModels;
using EuroDolarConversor.Core.Interface;

namespace EuroDolarConversor.Core.ViewModel
{
	class EuroDolarConversor: MvxViewModel
	{

		private IEuroDolarConversor _conversor;

		private double _euro_value  = 0;

		private double _dolar_value = 0;


		public EuroDolarConversor (IEuroDolarConversor conversor)
		{

			this._conversor = conversor;

		}

		public double EuroValue
		{
			get { return _euro_value; }
			set { 
				_euro_value = value; 
				UpdateDolar(); 
			}
		}

		public double DolarValue
		{
			get { return _dolar_value; }
			set { 
				_dolar_value = value; 
				UpdateEuro(); 
			}
		}


		public void UpdateDolar(){
			double newValue = this._conversor.toDolar (this._euro_value);
			if (newValue != this.DolarValue) {
				this.DolarValue = newValue;
				RaisePropertyChanged(() => DolarValue);
			}

		}

		public void UpdateEuro(){
			double newValue = this._conversor.toEuro (this._dolar_value);
			if (newValue != this.EuroValue) {
				this.EuroValue = newValue;
				RaisePropertyChanged(() => EuroValue);
			}
		}

	}
}

