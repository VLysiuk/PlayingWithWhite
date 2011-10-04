using System;
using PlayingWithWhite.Model;

namespace PlayingWithWhite
{
    public class ChuckPresenter
    {
        private readonly IChuckView _view;
        private readonly IMessageFormatter _messageFormatter;

        public ChuckPresenter(IChuckView view, IMessageFormatter messageFormatter)
        {
            _view = view;
            _messageFormatter = messageFormatter;
        }

        public void KickClicked()
        {
            string message = _messageFormatter.KickFormat(_view.Victim, _view.KickType, _view.KickTime);
            _view.ShowKickResult(message);
        }
    }
}