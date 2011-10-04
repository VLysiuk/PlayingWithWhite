using System;
using NUnit.Framework;
using PlayingWithWhite.Model;
using Rhino.Mocks;

namespace PlayingWithWhite.Test.View
{
    [TestFixture]
    public class LogInPresenterTest
    {
        private ILoginView _view;
        private ILoginService _loginService;
        private LoginPresenter _presenter;

        private const string Login = "TestLogin";
        private const string Password = "TestPasswd";

        [SetUp]
        public void SetUp()
        {
            _view = MockRepository.GenerateMock<ILoginView>();
            _loginService = MockRepository.GenerateMock<ILoginService>();
            _presenter = new LoginPresenter(_view,_loginService);
        }

        [Test]
        public void ShouldClearInputAfterLogin()
        {
            _presenter.LoginClicked();

            _view.AssertWasCalled(_=>_.ClearInput());
        }

        [Test]
        public void ShouldPerformLoginWhenLoginClicked()
        {
            _view.Stub(_ => _.Login).Return(Login);
            _view.Stub(_ => _.Password).Return(Password);

            _presenter.LoginClicked();

            _loginService.AssertWasCalled(_=>_.PerformLogin(Login,Password));
        }

        [Test]
        public void ShouldShowErrorMessageIfLoginInvalid()
        {
            _view.Stub(_ => _.Login).Return("");
            _view.Stub(_ => _.Password).Return("");

            _loginService.Stub(_ => _.PerformLogin("", "")).Return(false);

            _presenter.LoginClicked();

            _view.AssertWasCalled(_=>_.ShowErrorMessage());
            _view.AssertWasNotCalled(_=>_.ShowSuccessMessage());
        }

        [Test]
        public void ShouldShowSuccessMessageIfLoginValid()
        {
            _view.Stub(_ => _.Login).Return("");
            _view.Stub(_ => _.Password).Return("");

            _loginService.Stub(_ => _.PerformLogin("", "")).Return(true);

            _presenter.LoginClicked();

            _view.AssertWasCalled(_ => _.ShowSuccessMessage());
            _view.AssertWasNotCalled(_=>_.ShowErrorMessage());
        }

        [Test]
        public void ShowChuckWindowWhenChuckLoggedIn()
        {
            _loginService.Raise(_=>_.ChuckIsHere+=null,this,EventArgs.Empty);

            _view.AssertWasCalled(_=>_.ShowChuckWindow());
        }
    }
}
