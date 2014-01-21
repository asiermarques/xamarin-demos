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
using Cirrious.CrossCore;
using EuroDolarConversor.Core.Interface;

namespace EuroDolarConversor.Core
{
	public class App : MvxApplication
	{
		public App ()
		{

			Mvx.RegisterType<IEuroDolarConversor, EuroDolarConversor>();
			Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<ViewModel.EuroDolarConversor>());

		}
	}
}

