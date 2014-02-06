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
using MvvmTest.Core._02;
using Praeclarum.Bind;

namespace MvvmTest.Android
{
    [Activity(Label = "VMDrivenActivity")]			
    public class VMDrivenActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

			SetContentView(Resource.Layout.ViewModelBind);

			var login = FindViewById<Button>(Resource.Id.loginViewModel);
			var username = FindViewById<EditText>(Resource.Id.usernameViewModel);
			var password = FindViewById<EditText>(Resource.Id.passwordViewModel);

			var viewModel = new LoginViewModel();

			Binding.Create(() => username.Text == viewModel.UserName);
			Binding.Create(() => password.Text == viewModel.Password);

			username.TextChanged += (sender, e) => Binding.Invalidate(() => username.Text);
			password.TextChanged += (sender, e) => Binding.Invalidate(() => password.Text);

			login.Click += (sender, e) =>
			{
				viewModel.Login();
			};


        }
    }
}

