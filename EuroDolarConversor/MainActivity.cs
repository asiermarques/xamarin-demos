using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace EuroDolarConversor
{
	[Activity (Label = "EuroDolarConversor", MainLauncher = true)]
	public class MainActivity : MvxActivity
	{

		public new Core.ViewModel.EuroDolarConversor ViewModel
		{
			get { return (Core.ViewModel.EuroDolarConversor) base.ViewModel; }
			set { base.ViewModel = value; }
		}

		protected override void OnViewModelSet()
		{
			base.OnViewModelSet();
			SetContentView(Resource.Layout.Main);

		}

	}
}


