
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resetBttn = new System.Windows.Forms.Button();
            this.standBttn = new System.Windows.Forms.Button();
            this.hitBttn = new System.Windows.Forms.Button();
            this.totalTxtbox = new System.Windows.Forms.TextBox();
            this.betTxtbox = new System.Windows.Forms.TextBox();
            this.seedLabel = new System.Windows.Forms.Label();
            this.seedTxtbox = new System.Windows.Forms.TextBox();
            this.dealer_status_label = new System.Windows.Forms.Label();
            this.player_status_label = new System.Windows.Forms.Label();
            this.win_loseLabel = new System.Windows.Forms.Label();
            this.deckLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gameModeComboBox = new System.Windows.Forms.ComboBox();
            this.playBttn = new System.Windows.Forms.Button();
            this.computerPicturebox = new System.Windows.Forms.PictureBox();
            this.playerPicturebox = new System.Windows.Forms.PictureBox();
            this.nDeckCombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.computerPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dealer Cards";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player Cards";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total ($):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bet ($):";
            // 
            // resetBttn
            // 
            this.resetBttn.Location = new System.Drawing.Point(16, 590);
            this.resetBttn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resetBttn.Name = "resetBttn";
            this.resetBttn.Size = new System.Drawing.Size(58, 39);
            this.resetBttn.TabIndex = 4;
            this.resetBttn.Text = "Reset";
            this.resetBttn.UseVisualStyleBackColor = true;
            this.resetBttn.Click += new System.EventHandler(this.resetBttn_Click);
            // 
            // standBttn
            // 
            this.standBttn.Location = new System.Drawing.Point(465, 499);
            this.standBttn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.standBttn.Name = "standBttn";
            this.standBttn.Size = new System.Drawing.Size(60, 35);
            this.standBttn.TabIndex = 5;
            this.standBttn.Text = "Stand";
            this.standBttn.UseVisualStyleBackColor = true;
            this.standBttn.Click += new System.EventHandler(this.standBttn_Click);
            // 
            // hitBttn
            // 
            this.hitBttn.Location = new System.Drawing.Point(279, 499);
            this.hitBttn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hitBttn.Name = "hitBttn";
            this.hitBttn.Size = new System.Drawing.Size(70, 34);
            this.hitBttn.TabIndex = 6;
            this.hitBttn.Text = "HIT";
            this.hitBttn.UseVisualStyleBackColor = true;
            this.hitBttn.Click += new System.EventHandler(this.hitBttn_Click);
            // 
            // totalTxtbox
            // 
            this.totalTxtbox.Location = new System.Drawing.Point(26, 159);
            this.totalTxtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.totalTxtbox.Name = "totalTxtbox";
            this.totalTxtbox.Size = new System.Drawing.Size(52, 20);
            this.totalTxtbox.TabIndex = 7;
            // 
            // betTxtbox
            // 
            this.betTxtbox.Location = new System.Drawing.Point(26, 219);
            this.betTxtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.betTxtbox.Name = "betTxtbox";
            this.betTxtbox.Size = new System.Drawing.Size(52, 20);
            this.betTxtbox.TabIndex = 8;
            // 
            // seedLabel
            // 
            this.seedLabel.AutoSize = true;
            this.seedLabel.Location = new System.Drawing.Point(170, 590);
            this.seedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.seedLabel.Name = "seedLabel";
            this.seedLabel.Size = new System.Drawing.Size(32, 13);
            this.seedLabel.TabIndex = 9;
            this.seedLabel.Text = "Seed";
            // 
            // seedTxtbox
            // 
            this.seedTxtbox.Location = new System.Drawing.Point(168, 613);
            this.seedTxtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.seedTxtbox.Name = "seedTxtbox";
            this.seedTxtbox.Size = new System.Drawing.Size(52, 20);
            this.seedTxtbox.TabIndex = 10;
            // 
            // dealer_status_label
            // 
            this.dealer_status_label.AutoSize = true;
            this.dealer_status_label.Location = new System.Drawing.Point(728, 47);
            this.dealer_status_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dealer_status_label.Name = "dealer_status_label";
            this.dealer_status_label.Size = new System.Drawing.Size(35, 13);
            this.dealer_status_label.TabIndex = 12;
            this.dealer_status_label.Text = "label5";
            // 
            // player_status_label
            // 
            this.player_status_label.AutoSize = true;
            this.player_status_label.Location = new System.Drawing.Point(728, 167);
            this.player_status_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player_status_label.Name = "player_status_label";
            this.player_status_label.Size = new System.Drawing.Size(35, 13);
            this.player_status_label.TabIndex = 13;
            this.player_status_label.Text = "label6";
            // 
            // win_loseLabel
            // 
            this.win_loseLabel.AutoSize = true;
            this.win_loseLabel.Location = new System.Drawing.Point(728, 414);
            this.win_loseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.win_loseLabel.Name = "win_loseLabel";
            this.win_loseLabel.Size = new System.Drawing.Size(78, 13);
            this.win_loseLabel.TabIndex = 14;
            this.win_loseLabel.Text = "win/lose status";
            // 
            // deckLabel
            // 
            this.deckLabel.AutoSize = true;
            this.deckLabel.Location = new System.Drawing.Point(20, 53);
            this.deckLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deckLabel.Name = "deckLabel";
            this.deckLabel.Size = new System.Drawing.Size(94, 13);
            this.deckLabel.TabIndex = 15;
            this.deckLabel.Text = "Number of deck(s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Game mode";
            // 
            // gameModeComboBox
            // 
            this.gameModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameModeComboBox.FormattingEnabled = true;
            this.gameModeComboBox.Items.AddRange(new object[] {
            "S17",
            "H17"});
            this.gameModeComboBox.Location = new System.Drawing.Point(26, 25);
            this.gameModeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gameModeComboBox.Name = "gameModeComboBox";
            this.gameModeComboBox.Size = new System.Drawing.Size(62, 21);
            this.gameModeComboBox.TabIndex = 18;
            // 
            // playBttn
            // 
            this.playBttn.Location = new System.Drawing.Point(86, 590);
            this.playBttn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playBttn.Name = "playBttn";
            this.playBttn.Size = new System.Drawing.Size(58, 39);
            this.playBttn.TabIndex = 19;
            this.playBttn.Text = "Play";
            this.playBttn.UseVisualStyleBackColor = true;
            this.playBttn.Click += new System.EventHandler(this.playBttn_Click);
            // 
            // computerPicturebox
            // 
            this.computerPicturebox.Location = new System.Drawing.Point(162, 33);
            this.computerPicturebox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.computerPicturebox.Name = "computerPicturebox";
            this.computerPicturebox.Size = new System.Drawing.Size(500, 208);
            this.computerPicturebox.TabIndex = 20;
            this.computerPicturebox.TabStop = false;
            this.computerPicturebox.Click += new System.EventHandler(this.computerPicturebox_Click);
            // 
            // playerPicturebox
            // 
            this.playerPicturebox.Location = new System.Drawing.Point(162, 271);
            this.playerPicturebox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playerPicturebox.Name = "playerPicturebox";
            this.playerPicturebox.Size = new System.Drawing.Size(500, 208);
            this.playerPicturebox.TabIndex = 21;
            this.playerPicturebox.TabStop = false;
            this.playerPicturebox.Click += new System.EventHandler(this.playerPicturebox_Click);
            // 
            // nDeckCombobox
            // 
            this.nDeckCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nDeckCombobox.FormattingEnabled = true;
            this.nDeckCombobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.nDeckCombobox.Location = new System.Drawing.Point(26, 87);
            this.nDeckCombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nDeckCombobox.Name = "nDeckCombobox";
            this.nDeckCombobox.Size = new System.Drawing.Size(62, 21);
            this.nDeckCombobox.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(180)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(766, 552);
            this.Controls.Add(this.nDeckCombobox);
            this.Controls.Add(this.playerPicturebox);
            this.Controls.Add(this.computerPicturebox);
            this.Controls.Add(this.playBttn);
            this.Controls.Add(this.gameModeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deckLabel);
            this.Controls.Add(this.win_loseLabel);
            this.Controls.Add(this.player_status_label);
            this.Controls.Add(this.dealer_status_label);
            this.Controls.Add(this.seedTxtbox);
            this.Controls.Add(this.seedLabel);
            this.Controls.Add(this.betTxtbox);
            this.Controls.Add(this.totalTxtbox);
            this.Controls.Add(this.hitBttn);
            this.Controls.Add(this.standBttn);
            this.Controls.Add(this.resetBttn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button resetBttn;
        private System.Windows.Forms.Button standBttn;
        private System.Windows.Forms.Button hitBttn;
        private System.Windows.Forms.TextBox totalTxtbox;
        private System.Windows.Forms.TextBox betTxtbox;
        private System.Windows.Forms.Label seedLabel;
        private System.Windows.Forms.TextBox seedTxtbox;
        private System.Windows.Forms.Label dealer_status_label;
        private System.Windows.Forms.Label player_status_label;
        private System.Windows.Forms.Label win_loseLabel;
        private System.Windows.Forms.Label deckLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox gameModeComboBox;
        private System.Windows.Forms.Button playBttn;
        private System.Windows.Forms.PictureBox computerPicturebox;
        private System.Windows.Forms.PictureBox playerPicturebox;
        private System.Windows.Forms.ComboBox nDeckCombobox;
    }
}

