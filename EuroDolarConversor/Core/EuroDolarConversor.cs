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
using EuroDolarConversor.Core.Interface;

namespace EuroDolarConversor.Core
{
	class EuroDolarConversor : IEuroDolarConversor
	{

		const double CONVERSION_RATE = 1.34;

		public double toEuro ( double dolar_value ){

			return Math.Round ( dolar_value / CONVERSION_RATE, 2 );

		}

		public double toDolar( double euro_value ){

			return Math.Round ( euro_value * CONVERSION_RATE, 2 );

		}



	}
}

