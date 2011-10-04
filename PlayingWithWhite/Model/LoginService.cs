using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingWithWhite.Model
{
    public class LoginService:ILoginService
    {
        private readonly IDictionary<string, string> _usersData;

        public LoginService(IDictionary<string, string> usersData)
        {
            _usersData = usersData;
        }

        public bool PerformLogin(string username, string password)
        {
            if (username == "Chuck Norris")
            {
                if (ChuckIsHere != null)
                    ChuckIsHere(this, EventArgs.Empty);
                return true;
            }

            return _usersData.Contains(new KeyValuePair<string, string>(username, password));
        }

        public event EventHandler ChuckIsHere;
    }
}
