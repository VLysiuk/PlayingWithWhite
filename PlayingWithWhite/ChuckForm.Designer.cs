namespace PlayingWithWhite
{
    partial class ChuckForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._spareButton = new System.Windows.Forms.Button();
            this._kickButton = new System.Windows.Forms.Button();
            this._victimList = new System.Windows.Forms.ListBox();
            this._kickTypeComboBox = new System.Windows.Forms.ComboBox();
            this._kickDateTime = new System.Windows.Forms.DateTimePicker();
            this._kickLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(289, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "\"Chuck Norris does not sleep. He waits.\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlayingWithWhite.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._kickDateTime);
            this.groupBox1.Controls.Add(this._kickTypeComboBox);
            this.groupBox1.Controls.Add(this._victimList);
            this.groupBox1.Location = new System.Drawing.Point(14, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 194);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // _spareButton
            // 
            this._spareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._spareButton.Location = new System.Drawing.Point(453, 464);
            this._spareButton.Name = "_spareButton";
            this._spareButton.Size = new System.Drawing.Size(191, 86);
            this._spareButton.TabIndex = 3;
            this._spareButton.Text = "Spare";
            this._spareButton.UseVisualStyleBackColor = true;
            // 
            // _kickButton
            // 
            this._kickButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._kickButton.Location = new System.Drawing.Point(669, 464);
            this._kickButton.Name = "_kickButton";
            this._kickButton.Size = new System.Drawing.Size(191, 86);
            this._kickButton.TabIndex = 4;
            this._kickButton.Text = "Kick!";
            this._kickButton.UseVisualStyleBackColor = true;
            // 
            // _victimList
            // 
            this._victimList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._victimList.FormattingEnabled = true;
            this._victimList.ItemHeight = 25;
            this._victimList.Items.AddRange(new object[] {
            "Terminator",
            "Rocky",
            "Superman",
            "Anatoly Wasserman",
            "Chewbacca"});
            this._victimList.Location = new System.Drawing.Point(6, 19);
            this._victimList.Name = "_victimList";
            this._victimList.Size = new System.Drawing.Size(272, 154);
            this._victimList.TabIndex = 0;
            // 
            // _kickTypeComboBox
            // 
            this._kickTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._kickTypeComboBox.FormattingEnabled = true;
            this._kickTypeComboBox.Items.AddRange(new object[] {
            "Front Kick",
            "Low Kick",
            "Side Kick"});
            this._kickTypeComboBox.Location = new System.Drawing.Point(307, 70);
            this._kickTypeComboBox.Name = "_kickTypeComboBox";
            this._kickTypeComboBox.Size = new System.Drawing.Size(208, 21);
            this._kickTypeComboBox.TabIndex = 1;
            // 
            // _kickDateTime
            // 
            this._kickDateTime.Location = new System.Drawing.Point(574, 71);
            this._kickDateTime.Name = "_kickDateTime";
            this._kickDateTime.Size = new System.Drawing.Size(252, 20);
            this._kickDateTime.TabIndex = 2;
            // 
            // _kickLabel
            // 
            this._kickLabel.AutoSize = true;
            this._kickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._kickLabel.ForeColor = System.Drawing.Color.DarkRed;
            this._kickLabel.Location = new System.Drawing.Point(20, 217);
            this._kickLabel.Name = "_kickLabel";
            this._kickLabel.Size = new System.Drawing.Size(0, 24);
            this._kickLabel.TabIndex = 5;
            // 
            // ChuckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 578);
            this.Controls.Add(this._kickLabel);
            this.Controls.Add(this._kickButton);
            this.Controls.Add(this._spareButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChuckForm";
            this.Text = "God Window";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _spareButton;
        private System.Windows.Forms.Button _kickButton;
        private System.Windows.Forms.ListBox _victimList;
        private System.Windows.Forms.ComboBox _kickTypeComboBox;
        private System.Windows.Forms.DateTimePicker _kickDateTime;
        private System.Windows.Forms.Label _kickLabel;
    }
}