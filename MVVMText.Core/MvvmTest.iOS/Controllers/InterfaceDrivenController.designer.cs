// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace MvvmTest.iOS
{
	[Register ("InterfaceDrivenController")]
	partial class InterfaceDrivenController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton _login { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _password { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _username { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (_password != null) {
				_password.Dispose ();
				_password = null;
			}

			if (_login != null) {
				_login.Dispose ();
				_login = null;
			}

			if (_username != null) {
				_username.Dispose ();
				_username = null;
			}
		}
	}
}
