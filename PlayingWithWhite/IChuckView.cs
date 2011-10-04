using System;

namespace PlayingWithWhite
{
    public interface IChuckView
    {
        string Victim { get; }
        string KickType { get; }
        DateTime KickTime { get; }
        void ShowKickResult(string message);
    }
}