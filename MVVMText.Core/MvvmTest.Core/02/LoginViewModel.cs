using System;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Linq.Expressions;

namespace MvvmTest.Core._02
{
	public class LoginViewModel : INotifyPropertyChanged
    {
		private readonly IService _service;
		public event PropertyChangedEventHandler PropertyChanged;
		private string _userName, _password;

        public LoginViewModel()
        {
			_service = new FakeService();
        }

		public string UserName
		{
			get{ return _userName; }
			set
			{
				_userName = value;
				OnPropertyChanged(() => UserName);
			}
		}

		public string Password
		{
			get{ return _password; }
			set
			{
				_password = value;
				OnPropertyChanged(() => Password);
			}
		}

		public async Task Login()
		{
			await _service.Login(UserName, Password);		
		}

		protected void OnPropertyChanged<T>(Expression<Func<T>> expression)
		{
			var body = expression.Body as MemberExpression;
			this.PropertyChanged(this, new PropertyChangedEventArgs(body.Member.Name));
		}
    }
}

