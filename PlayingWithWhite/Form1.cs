using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PlayingWithWhite.Model;

namespace PlayingWithWhite
{
    public partial class Form1 : Form,ILoginView
    {
        private LoginPresenter _presenter;
        private ILoginService _loginService;

        public Form1()
        {
            InitializeComponent();
            _loginService = new LoginService(UsersData.LoginInfo);

            _presenter = new LoginPresenter(this,_loginService);
        }

        private static void ExitButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogInButtonClick(object sender, EventArgs e)
        {
            _presenter.LoginClicked();
        }

        public string Login
        {
            get { return _loginTextBox.Text; }
        }

        public string Password
        {
            get { return _passwdTextBox.Text; }
        }

        public void ClearInput()
        {
            _loginTextBox.Text = String.Empty;
            _passwdTextBox.Text = String.Empty;
        }

        public void ShowErrorMessage()
        {
            MessageBox.Show("Invalid login or passworrd!", "Login Error");
        }

        public void ShowSuccessMessage()
        {
            MessageBox.Show("Success!", "Successful Login");
        }

        public void ShowChuckWindow()
        {
            var chuckWindow = new ChuckForm();
            chuckWindow.ShowDialog();
        }
    }
}
