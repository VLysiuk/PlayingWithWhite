using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlayingWithWhite
{
    public partial class ChuckForm : Form, IChuckView
    {

        public ChuckForm()
        {
            InitializeComponent();

        }

        public string Victim
        {
            get { return _victimList.Text; }
        }

        public string KickType
        {
            get { return _kickTypeComboBox.SelectedText; }
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
    }
}
