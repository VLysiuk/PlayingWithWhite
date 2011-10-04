using System.Threading;
using White.Core;
using White.Core.UIItems;
using White.Core.UIItems.Finders;
using White.Core.UIItems.WindowItems;

namespace PlayingWithWhite.Test.Acceptance
{
    public class ApplicationRunner
    {
        private const string AppExecPath = @"..\..\..\PlayingWithWhite\bin\Debug\PlayingWithWhite.exe";
        private Application _application;
        private Window _mainWindow;
        private const int DemonstrationDelay = 1000;

        public void Launch()
        {
            _application = Application.Launch(AppExecPath);
            _mainWindow = _application.GetWindow("Testhing White");
        }

        public void StopApplication()
        {
            _application.Kill();
        }

        public Window MainWindow
        {
            get { return _mainWindow; }
        }

        public bool ApplicationClosed
        {
            get { return _application.HasExited; }
        }

        public void LogIn(string login, string password)
        {
            var loginTextBox = _mainWindow.Get<TextBox>("_loginTextBox");

            var passwdTextBox = (WinFormTextBox)_mainWindow.Get(SearchCriteria.ByAutomationId("_passwdTextBox").AndControlType(typeof(WinFormTextBox)));

            var logInButton = _mainWindow.Get<Button>(SearchCriteria.ByText("Log me in!"));

            loginTextBox.ClickAtCenter();
            loginTextBox.BulkText = login;
            #region demonstration delay
            Thread.Sleep(DemonstrationDelay);
            #endregion

            passwdTextBox.ClickAtCenter();
            passwdTextBox.BulkText = password;

            #region demonstration delay
            Thread.Sleep(DemonstrationDelay);
            #endregion
            logInButton.RaiseClickEvent();
        }
    }
}