using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MvvmTest.Android
{
    [Activity(Label = "MvvmTest.Android", MainLauncher = true)]
    public class MainActivity : Activity
	{
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

			var idriven = FindViewById<Button>(Resource.Id.idriven);
			var viewModel = FindViewById<Button>(Resource.Id.viewModel);

			idriven.Click += (sender, e) => StartActivity(typeof(IDrivenActivity));
			viewModel.Click += (sender, e) => StartActivity(typeof(VMDrivenActivity));
        }
    }
}


