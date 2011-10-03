using PlayingWithWhite.Model;

namespace PlayingWithWhite
{
    public class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly ILoginService _loginService;

        public LoginPresenter(ILoginView view, ILoginService loginService)
        {
            _view = view;
            _loginService = loginService;
        }

        public void LoginClicked()
        {
            _loginService.PerformLogin(_view.Login, _view.Password);
            _view.ClearInput();
        }
    }
}