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
        public event EventHandler Login
        {
            add { _login += value; }
            remove { _login -= value; }
        }

        private EventHandler _login;
        private EditText _username, _password;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

			SetContentView(Resource.Layout.IDrivenLayout);

			var viewModel = new LoginViewModel();
			//viewModel.View = this;

			var login = FindViewById<Button>(Resource.Id.interfaceLogin);
			_username = FindViewById<EditText>(Resource.Id.interfaceUsername);
            _password = FindViewById<EditText>(Resource.Id.interfacePassword);

			login.Click += _login;
        }

		public string Username
		{
            get { return _username.Text; }
            set { _username.Text = value; }
		}

		public string Password
		{
            get { return _password.Text; }
            set { _password.Text = value; }
		}
    }
}

