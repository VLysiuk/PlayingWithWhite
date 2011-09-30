using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NUnit.Framework;
using White.Core;
using White.Core.InputDevices;
using White.Core.UIItems;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Finders;
using White.Core.UIItems.WindowItems;

namespace PlayingWithWhite.Test
{
    [TestFixture]
    public class MainAcceptanceTests
    {
        private const string AppExecPath = @"..\..\..\PlayingWithWhite\bin\Debug\PlayingWithWhite.exe";
        private Application _application;
        private Window _mainWindow;
        private const int DemonstrationDelay = 1000;
        
        [SetUp]
        public void SetUp()
        {
            _application = Application.Launch(AppExecPath);
            _mainWindow = _application.GetWindow("Testhing White");
        }

        [TearDown]
        public void TearDown()
        {
            _application.Kill();
        }

        [Test]
        public void CheckIfMainFormNameIsCorrect()
        {
            Assert.IsNotNull(_mainWindow);
            Assert.AreEqual("Testhing White", _mainWindow.Title);
        }

        [Test]
        public void CloseApplicationWhenExitButtonPressed()
        {
            var exitButton = _mainWindow.Get<Button>("_exitButton");
            exitButton.RaiseClickEvent();//Click();

            Thread.Sleep(1000);
            Assert.IsTrue(_mainWindow.IsClosed);
            Assert.IsTrue(_application.HasExited);
        }

        [Test]
        public void ShowMessageBoxWithErrorMessageWhenUnsuccessfulLogin()
        {
            LogIn("My Cool Login", "wrong, tricky password is entered here!");

            var messageBox = _mainWindow.MessageBox("Login Error");
            
            Assert.IsNotNull(messageBox);
        }

        //Chack Norris test!
        [Test]
        public void ShowGodWindowWhenChackIsLogedIn()
        {
            LogIn("Chack Norris","I'm Chuck Norris, babe!");

            var chackPage = _mainWindow.ModalWindow("God Window");

        }

        private void LogIn(string login,string password)
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
