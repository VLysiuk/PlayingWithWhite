namespace PlayingWithWhite
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._loginTextBox = new System.Windows.Forms.TextBox();
            this._passwdTextBox = new System.Windows.Forms.TextBox();
            this._logInButton = new System.Windows.Forms.Button();
            this._exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(35, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // _loginTextBox
            // 
            this._loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._loginTextBox.Location = new System.Drawing.Point(234, 53);
            this._loginTextBox.Name = "_loginTextBox";
            this._loginTextBox.Size = new System.Drawing.Size(273, 26);
            this._loginTextBox.TabIndex = 2;
            // 
            // _passwdTextBox
            // 
            this._passwdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._passwdTextBox.Location = new System.Drawing.Point(234, 130);
            this._passwdTextBox.Name = "_passwdTextBox";
            this._passwdTextBox.Size = new System.Drawing.Size(273, 26);
            this._passwdTextBox.TabIndex = 3;
            // 
            // _logInButton
            // 
            this._logInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._logInButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this._logInButton.Location = new System.Drawing.Point(284, 286);
            this._logInButton.Name = "_logInButton";
            this._logInButton.Size = new System.Drawing.Size(223, 92);
            this._logInButton.TabIndex = 4;
            this._logInButton.Text = "Log me in!";
            this._logInButton.UseVisualStyleBackColor = true;
            // 
            // _exitButton
            // 
            this._exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this._exitButton.Location = new System.Drawing.Point(39, 286);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(223, 92);
            this._exitButton.TabIndex = 5;
            this._exitButton.Text = "Exit";
            this._exitButton.UseVisualStyleBackColor = true;
            this._exitButton.Click += new System.EventHandler(this._exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 432);
            this.Controls.Add(this._exitButton);
            this.Controls.Add(this._logInButton);
            this.Controls.Add(this._passwdTextBox);
            this.Controls.Add(this._loginTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Testhing White";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _loginTextBox;
        private System.Windows.Forms.TextBox _passwdTextBox;
        private System.Windows.Forms.Button _logInButton;
        private System.Windows.Forms.Button _exitButton;
    }
}

