using System;

namespace MvvmTest.Core._01
{
	public class LoginViewModel
    {
		private readonly IService _service;

		public LoginViewModel()
		{
			_service = new FakeService();
		}

		private ILoginView _view;

		public ILoginView View
		{
			get { return _view; }
			set
			{
				if (_view != null)
				{
					_view.Login -= OnLogin;
				}

				_view = value;
				_view.Login += OnLogin;
			}
		}

		private async void OnLogin (object sender, EventArgs e)
		{
			await _service.Login(_view.Username, _view.Password);
		}
    }
}

