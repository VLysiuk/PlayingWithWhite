using System;

namespace PlayingWithWhite.Model
{
    public interface IMessageFormatter
    {
        string KickFormat(string victim,string kickType,DateTime kickTime);
    }
}