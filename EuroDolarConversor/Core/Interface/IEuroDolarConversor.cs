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

namespace EuroDolarConversor.Core.Interface
{
	public interface IEuroDolarConversor
	{

		double toEuro ( double dolar_value );

		double toDolar( double euro_value );

	}
}

