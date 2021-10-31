
namespace Project2
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
            this.dealerCardsLabel = new System.Windows.Forms.Label();
            this.playerCardsLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.betLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.betTextBox = new System.Windows.Forms.TextBox();
            this.seedLabel = new System.Windows.Forms.Label();
            this.seedTextbox = new System.Windows.Forms.TextBox();
            this.dealerValueLabel = new System.Windows.Forms.Label();
            this.playerValueLabel = new System.Windows.Forms.Label();
            this.winOrLoseLabel = new System.Windows.Forms.Label();
            this.deckLabel = new System.Windows.Forms.Label();
            this.gameModeLabel = new System.Windows.Forms.Label();
            this.gameModeComboBox = new System.Windows.Forms.ComboBox();
            this.playButton = new System.Windows.Forms.Button();
            this.computerPicturebox = new System.Windows.Forms.PictureBox();
            this.playerPicturebox = new System.Windows.Forms.PictureBox();
            this.numberOfDeckComboBox = new System.Windows.Forms.ComboBox();
            this.dealerValueRichTextBox = new System.Windows.Forms.RichTextBox();
            this.playerValueRichTextBox = new System.Windows.Forms.RichTextBox();
            this.winOrLoseRichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.computerPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // dealerCardsLabel
            // 
            this.dealerCardsLabel.AutoSize = true;
            this.dealerCardsLabel.Location = new System.Drawing.Point(376, 10);
            this.dealerCardsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dealerCardsLabel.Name = "dealerCardsLabel";
            this.dealerCardsLabel.Size = new System.Drawing.Size(68, 13);
            this.dealerCardsLabel.TabIndex = 0;
            this.dealerCardsLabel.Text = "Dealer Cards";
            this.dealerCardsLabel.Click += new System.EventHandler(this.dealerCards_Click);
            // 
            // playerCardsLabel
            // 
            this.playerCardsLabel.AutoSize = true;
            this.playerCardsLabel.Location = new System.Drawing.Point(376, 248);
            this.playerCardsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerCardsLabel.Name = "playerCardsLabel";
            this.playerCardsLabel.Size = new System.Drawing.Size(66, 13);
            this.playerCardsLabel.TabIndex = 1;
            this.playerCardsLabel.Text = "Player Cards";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(24, 133);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(49, 13);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.Text = "Total ($):";
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Location = new System.Drawing.Point(24, 193);
            this.betLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(41, 13);
            this.betLabel.TabIndex = 3;
            this.betLabel.Text = "Bet ($):";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(939, 107);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(58, 39);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // standButton
            // 
            this.standButton.Location = new System.Drawing.Point(465, 499);
            this.standButton.Margin = new System.Windows.Forms.Padding(2);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(60, 35);
            this.standButton.TabIndex = 5;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // hitButton
            // 
            this.hitButton.Location = new System.Drawing.Point(279, 499);
            this.hitButton.Margin = new System.Windows.Forms.Padding(2);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(70, 34);
            this.hitButton.TabIndex = 6;
            this.hitButton.Text = "HIT";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(26, 159);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(52, 20);
            this.totalTextBox.TabIndex = 7;
            // 
            // betTextBox
            // 
            this.betTextBox.Location = new System.Drawing.Point(26, 219);
            this.betTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.betTextBox.Name = "betTextBox";
            this.betTextBox.Size = new System.Drawing.Size(52, 20);
            this.betTextBox.TabIndex = 8;
            // 
            // seedLabel
            // 
            this.seedLabel.AutoSize = true;
            this.seedLabel.Location = new System.Drawing.Point(954, 162);
            this.seedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.seedLabel.Name = "seedLabel";
            this.seedLabel.Size = new System.Drawing.Size(32, 13);
            this.seedLabel.TabIndex = 9;
            this.seedLabel.Text = "Seed";
            // 
            // seedTextbox
            // 
            this.seedTextbox.Location = new System.Drawing.Point(945, 186);
            this.seedTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.seedTextbox.Name = "seedTextbox";
            this.seedTextbox.Size = new System.Drawing.Size(52, 20);
            this.seedTextbox.TabIndex = 10;
            // 
            // dealerValueLabel
            // 
            this.dealerValueLabel.AutoSize = true;
            this.dealerValueLabel.Location = new System.Drawing.Point(761, 10);
            this.dealerValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dealerValueLabel.Name = "dealerValueLabel";
            this.dealerValueLabel.Size = new System.Drawing.Size(34, 13);
            this.dealerValueLabel.TabIndex = 12;
            this.dealerValueLabel.Text = "Value";
            // 
            // playerValueLabel
            // 
            this.playerValueLabel.AutoSize = true;
            this.playerValueLabel.Location = new System.Drawing.Point(771, 248);
            this.playerValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerValueLabel.Name = "playerValueLabel";
            this.playerValueLabel.Size = new System.Drawing.Size(34, 13);
            this.playerValueLabel.TabIndex = 13;
            this.playerValueLabel.Text = "Value";
            // 
            // winOrLoseLabel
            // 
            this.winOrLoseLabel.AutoSize = true;
            this.winOrLoseLabel.Location = new System.Drawing.Point(748, 417);
            this.winOrLoseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.winOrLoseLabel.Name = "winOrLoseLabel";
            this.winOrLoseLabel.Size = new System.Drawing.Size(78, 13);
            this.winOrLoseLabel.TabIndex = 14;
            this.winOrLoseLabel.Text = "win/lose status";
            // 
            // deckLabel
            // 
            this.deckLabel.AutoSize = true;
            this.deckLabel.Location = new System.Drawing.Point(20, 53);
            this.deckLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deckLabel.Name = "deckLabel";
            this.deckLabel.Size = new System.Drawing.Size(88, 13);
            this.deckLabel.TabIndex = 15;
            this.deckLabel.Text = "Number of decks";
            // 
            // gameModeLabel
            // 
            this.gameModeLabel.AutoSize = true;
            this.gameModeLabel.Location = new System.Drawing.Point(25, 10);
            this.gameModeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gameModeLabel.Name = "gameModeLabel";
            this.gameModeLabel.Size = new System.Drawing.Size(64, 13);
            this.gameModeLabel.TabIndex = 17;
            this.gameModeLabel.Text = "Game mode";
            // 
            // gameModeComboBox
            // 
            this.gameModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameModeComboBox.FormattingEnabled = true;
            this.gameModeComboBox.Items.AddRange(new object[] {
            "H17",
            "S17"});
            this.gameModeComboBox.Location = new System.Drawing.Point(26, 25);
            this.gameModeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.gameModeComboBox.Name = "gameModeComboBox";
            this.gameModeComboBox.Size = new System.Drawing.Size(62, 21);
            this.gameModeComboBox.TabIndex = 18;
            this.gameModeComboBox.SelectedIndexChanged += new System.EventHandler(this.gameModeComboBox_SelectedIndexChanged);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(939, 40);
            this.playButton.Margin = new System.Windows.Forms.Padding(2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(58, 39);
            this.playButton.TabIndex = 19;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // computerPicturebox
            // 
            this.computerPicturebox.Location = new System.Drawing.Point(162, 33);
            this.computerPicturebox.Margin = new System.Windows.Forms.Padding(2);
            this.computerPicturebox.Name = "computerPicturebox";
            this.computerPicturebox.Size = new System.Drawing.Size(500, 208);
            this.computerPicturebox.TabIndex = 20;
            this.computerPicturebox.TabStop = false;
            this.computerPicturebox.Click += new System.EventHandler(this.computerPicturebox_Click);
            // 
            // playerPicturebox
            // 
            this.playerPicturebox.Location = new System.Drawing.Point(162, 271);
            this.playerPicturebox.Margin = new System.Windows.Forms.Padding(2);
            this.playerPicturebox.Name = "playerPicturebox";
            this.playerPicturebox.Size = new System.Drawing.Size(500, 208);
            this.playerPicturebox.TabIndex = 21;
            this.playerPicturebox.TabStop = false;
            this.playerPicturebox.Click += new System.EventHandler(this.playerPicturebox_Click);
            // 
            // numberOfDeckComboBox
            // 
            this.numberOfDeckComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberOfDeckComboBox.FormattingEnabled = true;
            this.numberOfDeckComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.numberOfDeckComboBox.Location = new System.Drawing.Point(26, 87);
            this.numberOfDeckComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.numberOfDeckComboBox.Name = "numberOfDeckComboBox";
            this.numberOfDeckComboBox.Size = new System.Drawing.Size(62, 21);
            this.numberOfDeckComboBox.TabIndex = 22;
            // 
            // dealerValueRichTextBox
            // 
            this.dealerValueRichTextBox.Location = new System.Drawing.Point(716, 33);
            this.dealerValueRichTextBox.Name = "dealerValueRichTextBox";
            this.dealerValueRichTextBox.Size = new System.Drawing.Size(145, 96);
            this.dealerValueRichTextBox.TabIndex = 24;
            this.dealerValueRichTextBox.Text = "Some Value or Bust";
            // 
            // playerValueRichTextBox
            // 
            this.playerValueRichTextBox.Location = new System.Drawing.Point(716, 271);
            this.playerValueRichTextBox.Name = "playerValueRichTextBox";
            this.playerValueRichTextBox.Size = new System.Drawing.Size(145, 91);
            this.playerValueRichTextBox.TabIndex = 25;
            this.playerValueRichTextBox.Text = "Some Value or Bust";
            // 
            // winOrLoseRichTextBox
            // 
            this.winOrLoseRichTextBox.Location = new System.Drawing.Point(716, 450);
            this.winOrLoseRichTextBox.Name = "winOrLoseRichTextBox";
            this.winOrLoseRichTextBox.Size = new System.Drawing.Size(145, 55);
            this.winOrLoseRichTextBox.TabIndex = 26;
            this.winOrLoseRichTextBox.Text = "Win or Lose or Tie status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1074, 673);
            this.Controls.Add(this.winOrLoseRichTextBox);
            this.Controls.Add(this.playerValueRichTextBox);
            this.Controls.Add(this.dealerValueRichTextBox);
            this.Controls.Add(this.numberOfDeckComboBox);
            this.Controls.Add(this.playerPicturebox);
            this.Controls.Add(this.computerPicturebox);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.gameModeComboBox);
            this.Controls.Add(this.gameModeLabel);
            this.Controls.Add(this.deckLabel);
            this.Controls.Add(this.winOrLoseLabel);
            this.Controls.Add(this.playerValueLabel);
            this.Controls.Add(this.dealerValueLabel);
            this.Controls.Add(this.seedTextbox);
            this.Controls.Add(this.seedLabel);
            this.Controls.Add(this.betTextBox);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.betLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.playerCardsLabel);
            this.Controls.Add(this.dealerCardsLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "JasonTruong_and_MuhammedAdemola";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dealerCardsLabel;
        private System.Windows.Forms.Label playerCardsLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox betTextBox;
        private System.Windows.Forms.Label seedLabel;
        private System.Windows.Forms.TextBox seedTextbox;
        private System.Windows.Forms.Label dealerValueLabel;
        private System.Windows.Forms.Label playerValueLabel;
        private System.Windows.Forms.Label winOrLoseLabel;
        private System.Windows.Forms.Label deckLabel;
        private System.Windows.Forms.Label gameModeLabel;
        private System.Windows.Forms.ComboBox gameModeComboBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.PictureBox computerPicturebox;
        private System.Windows.Forms.PictureBox playerPicturebox;
        private System.Windows.Forms.ComboBox numberOfDeckComboBox;
        private System.Windows.Forms.RichTextBox dealerValueRichTextBox;
        private System.Windows.Forms.RichTextBox playerValueRichTextBox;
        private System.Windows.Forms.RichTextBox winOrLoseRichTextBox;
    }
}

