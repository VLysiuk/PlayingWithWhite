using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using PlayingWithWhite.Model;
using Rhino.Mocks;

namespace PlayingWithWhite.Test.View
{
    [TestFixture]
    public class ChuckPresenterTest
    {
        private IChuckView _view;
        private ChuckPresenter _presenter;
        private IMessageFormatter _messageFormatter;

        [SetUp]
        public void SetUp()
        {
            _view = MockRepository.GenerateMock<IChuckView>();
            _messageFormatter = MockRepository.GenerateMock<IMessageFormatter>();

            _presenter = new ChuckPresenter(_view,_messageFormatter);
        }

        [Test]
        public void ShouldFormatMessageBeforeSending()
        {
            var victim = "Victim";
            var kickType = "Front Kick";
            var kickTime = DateTime.Now;

            _view.Stub(_ => _.Victim).Return(victim);
            _view.Stub(_ => _.KickType).Return(kickType);
            _view.Stub(_ => _.KickTime).Return(kickTime);

            _presenter.KickClicked();

            _messageFormatter.AssertWasCalled(_=>_.KickFormat(victim,kickType,kickTime));
        }

        [Test]
        public void ShowKickResultWhenKickWasClicked()
        {
            _messageFormatter.Stub(_ => _.KickFormat(String.Empty, String.Empty, DateTime.Now)).Return(String.Empty).
                IgnoreArguments();

            _presenter.KickClicked();

            _view.AssertWasCalled(_=>_.ShowKickResult(String.Empty));
        }
    }
}
