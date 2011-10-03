using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NUnit.Framework;
using White.Core.InputDevices;
using White.Core.UIItems;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Finders;
using White.Core.UIItems.WindowItems;

namespace PlayingWithWhite.Test
{
    [TestFixture]
    public class MainAcceptanceTest
    {
        private readonly ApplicationRunner _appRunner = new ApplicationRunner();
        private Window _mainWindow;
        
        [SetUp]
        public void SetUp()
        {
            _appRunner.Launch();
            _mainWindow = _appRunner.MainWindow;
        }

        [TearDown]
        public void TearDown()
        {
            _appRunner.StopApplication();
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
            Assert.IsTrue(_appRunner.ApplicationClosed);
        }

        [Test]
        public void ShowMessageBoxWithErrorMessageWhenUnsuccessfulLogin()
        {
            _appRunner.LogIn("My Cool Login", "wrong, tricky password is entered here!");

            var messageBox = _mainWindow.MessageBox("Login Error");
            Assert.IsNotNull(messageBox);
        }

        //NOTE: Be careful, it is Chuck Norris test!
        [Test]
        public void ShowGodWindowWhenChuckIsLogedIn()
        {
            _appRunner.LogIn("Chuck Norris", "I'm Chuck Norris, babe!");

            var chackPage = _mainWindow.ModalWindow("God Window");

            Assert.IsNotNull(chackPage);
        }

        [Test]
        public void ShowSuccesMessageWhenLoginIsCorrect()
        {
            _appRunner.LogIn("test", "test");

            var messageBox = _mainWindow.MessageBox("Successful Login");
            var msg = messageBox.Get(SearchCriteria.ByControlType(typeof(Label)));

            Assert.IsNotNull(messageBox);
            Assert.AreEqual("Success!",msg.Name);
        }
    }
}
