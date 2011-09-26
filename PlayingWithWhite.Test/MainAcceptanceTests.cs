using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using White.Core;
using White.Core.InputDevices;
using White.Core.UIItems;
using White.Core.UIItems.Finders;
using White.Core.UIItems.WindowItems;

namespace PlayingWithWhite.Test
{
    [TestFixture]
    public class MainAcceptanceTests
    {
        private const string AppExecPath = @"..\..\..\PlayingWithWhite\bin\Debug\PlayingWithWhite.exe";
        private Application _application;
        
        [SetUp]
        public void SetUp()
        {
            _application = Application.Launch(AppExecPath);
        }

        [TearDown]
        public void TearDown()
        {
            _application.Kill();
        }

        [Test]
        public void CheckIfMainFormNameIsCorrect()
        {
            var mainForm = _application.GetWindow("Testhing White");

            Assert.IsNotNull(mainForm);
            Assert.AreEqual("Testhing White", mainForm.Title);
        }

        [Test]
        public void CloseApplicationWhenExitButtonPressed()
        {
            var mainForm = _application.GetWindow("Testhing White");

            var exitButton = mainForm.Get<Button>("_exitButton");
            exitButton.RaiseClickEvent();//Click();

            Assert.IsTrue(_application.HasExited);
        }

        [Test]
        public void ShowMessageBoxWithErrorMessageWhenUnsuccessfulLogin()
        {
            var mainForm = _application.GetWindow("Testhing White");

            var loginTextBox = mainForm.Get<TextBox>("_loginTextBox");

            var passwdTextBox = mainForm.Get(SearchCriteria.ByAutomationId("_passwdTextBox").AndControlType(typeof(WinFormTextBox)));

            var logInButton = mainForm.Get(SearchCriteria.ByText("Log me in!"));

            loginTextBox.ClickAtCenter();
            loginTextBox.BulkText = "My Cool Login";

            passwdTextBox.Focus();
            passwdTextBox.Enter("tricky password is entered here!");

            logInButton.Click();
            
        }
    }
}
