using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingWithWhite.Model
{
    public class MessageFormatter : IMessageFormatter
    {
        public string KickFormat(string victim, string kickType, DateTime kickTime)
        {
            return String.Format("{0} is going to be kicked with {1} at {2}", victim, kickType, kickTime.ToShortDateString());
        }
    }
}
