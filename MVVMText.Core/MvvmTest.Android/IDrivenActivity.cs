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
using MvvmTest.Core._01;

namespace MvvmTest.Android
{
    [Activity(Label = "IDrivenActivity")]			
	public class IDrivenActivity : Activity, ILoginView
    {
		public event EventHandler Login;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

			SetContentView(Resource.Layout.IDrivenLayout);

			var viewModel = new LoginViewModel();
			viewModel.View = this;

			var login = FindViewById<Button>(Resource.Id.interfaceLogin);
			var userName = FindViewById<EditText>(Resource.Id.interfaceUsername);
			var password = FindViewById<EditText>(Resource.Id.interfacePassword);

			userName.TextChanged += (sender, e) =>
			{
				Username = userName.Text;
			};
			password.TextChanged += (sender, e) =>
			{
				Password = password.Text;
			};

			login.Click += (sender, e) =>
			{
				Login(sender,e);
			};
        }

		public string Username
		{
			get;
			set;
		}

		public string Password
		{
			get;
			set;
		}
    }
}

