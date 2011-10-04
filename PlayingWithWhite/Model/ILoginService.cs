using System;

namespace PlayingWithWhite.Model
{
    public interface ILoginService
    {
        bool PerformLogin(string username, string password);
        event EventHandler ChuckIsHere;
    }
}