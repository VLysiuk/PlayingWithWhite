using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using PlayingWithWhite.Model;

namespace PlayingWithWhite.Test.Model
{
    [TestFixture]
    public class LoginServiceTest
    {
        private LoginService _loginService;
        private IDictionary<string, string> _usersData;

        [SetUp]
        public void SetUp()
        {
            _usersData = new Dictionary<string, string> {{"test", "test"}};
            _loginService = new LoginService(_usersData);
        }

        [Test]
        public void ShouldReturnFalseWhenLoginIsIncorrect()
        {
            var loginIsValid = _loginService.PerformLogin("test", "something else");

            Assert.IsFalse(loginIsValid);
        }

        [Test]
        public void ShouldReturnTrueWhenLoginIsCorrect()
        {
            var loginIsValid = _loginService.PerformLogin("test", "test");

            Assert.IsTrue(loginIsValid);
        }

        [Test]
        public void ShouldAlwaysAllowAccessWhenChuckWantsToLogin()
        {
            var loginIsValid = _loginService.PerformLogin("Chuck Norris", "It is really doesn't matter");

            Assert.IsTrue(loginIsValid);
        }
    }
}
