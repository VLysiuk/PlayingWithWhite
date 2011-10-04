namespace PlayingWithWhite
{
    public interface ILoginView
    {
        string Login { get; }
        string Password { get; }
        void ClearInput();
        void ShowErrorMessage();
        void ShowSuccessMessage();
        void ShowChuckWindow();
    }
}