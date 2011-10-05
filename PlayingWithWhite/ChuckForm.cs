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
    public partial class ChuckForm : Form, IChuckView
    {
        private ChuckPresenter _presenter;
        private readonly IMessageFormatter _messageFormatter;

        public ChuckForm()
        {
            InitializeComponent();
            _messageFormatter = new MessageFormatter();
            _presenter = new ChuckPresenter(this,_messageFormatter);
        }

        public string Victim
        {
            get { return _victimList.Text; }
        }

        public string KickType
        {
            get { return _kickTypeComboBox.Text; }
        }

        public DateTime KickTime
        {
            get {return _kickDateTime.Value; }
        }

        public void ShowKickResult(string message)
        {
            _kickLabel.Text = message;
        }

        private void SpareButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void KickButtonClick(object sender, EventArgs e)
        {
            _presenter.KickClicked();
        }
    }
}
