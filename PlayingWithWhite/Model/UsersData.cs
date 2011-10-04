using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingWithWhite.Model
{
    public static class UsersData
    {
        private static readonly IDictionary<string, string> _loginInfo = new Dictionary<string, string>()
                                                                             {{"test", "test"}, {"ciklum", "ciklum"}};

        public static IDictionary<string,string> LoginInfo
        {
            get { return _loginInfo; }
        }
    }
}
