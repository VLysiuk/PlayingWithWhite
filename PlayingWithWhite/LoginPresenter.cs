using PlayingWithWhite.Model;

namespace PlayingWithWhite
{
    public class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly ILoginService _loginService;
        private bool _chuckIsHere;

        public LoginPresenter(ILoginView view, ILoginService loginService)
        {
            _view = view;
            _loginService = loginService;
            _loginService.ChuckIsHere += LoginServiceChuckIsHere;
        }

        void LoginServiceChuckIsHere(object sender, System.EventArgs e)
        {
            //_chuckIsHere = true;
            _view.ShowChuckWindow();
        }

        public void LoginClicked()
        {
            var loginIsValid = _loginService.PerformLogin(_view.Login, _view.Password);
         
            ShowResultMessage(loginIsValid);    
            
            _view.ClearInput();
            
        }

        private void ShowResultMessage(bool loginIsValid)
        {
            if(loginIsValid)
                _view.ShowSuccessMessage();
            else
                _view.ShowErrorMessage();
        }
    }
}