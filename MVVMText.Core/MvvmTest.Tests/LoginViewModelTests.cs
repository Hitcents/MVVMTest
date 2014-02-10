using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MvvmTest.Core;
using MvvmTest.Core._01;
using System;
using System.Threading.Tasks;

namespace MvvmTest.Tests
{
    [TestClass]
    public class LoginViewModelTests
    {
        private Mock<ILoginView> _loginView;
        private LoginViewModel _loginViewModel;

        [TestInitialize]
        public void TestInitialize()
        {
            _loginViewModel = new LoginViewModel();
            _loginView = new Mock<ILoginView>();

            _loginViewModel.View = _loginView.Object;
        }

        [TestMethod]
        public void Login()
        {
            _loginView.Setup(v => v.Username).Returns("chuck");
            _loginView.Setup(v => v.Password).Returns("chuck");
            _loginView.Raise(v => v.Login += null, EventArgs.Empty);
        }

        [TestMethod]
        public void LoginFailed()
        {
            _loginView.Raise(v => v.Login += null, EventArgs.Empty);
        }
    }
}
