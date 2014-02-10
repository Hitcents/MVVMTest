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
        private readonly LoginViewModel _viewModel = new LoginViewModel();
        private EditText _username, _password;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

			SetContentView(Resource.Layout.ViewModelBind);

			var login = FindViewById<Button>(Resource.Id.loginViewModel);
			_username = FindViewById<EditText>(Resource.Id.usernameViewModel);
			_password = FindViewById<EditText>(Resource.Id.passwordViewModel);

			Binding.Create(() => _username.Text == _viewModel.UserName);
			Binding.Create(() => _password.Text == _viewModel.Password);

            //_username.TextChanged += (sender, e) => Binding.Invalidate(() => _username.Text);
            //_password.TextChanged += (sender, e) => Binding.Invalidate(() => _password.Text);

			login.Click += async (sender, e) =>
			{
				await _viewModel.Login();
			};
        }
    }
}

