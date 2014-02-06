using System;

namespace MvvmTest.Core._01
{
    public interface ILoginView
    {
		string Username { get; set; }
		string Password { get; set; }
		event EventHandler Login;
	}
}

