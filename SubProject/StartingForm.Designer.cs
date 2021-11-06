
namespace SubProject
{
    partial class StartingForm
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
            this.NumDecksLabel = new System.Windows.Forms.Label();
            this.NumDecksComboBox = new System.Windows.Forms.ComboBox();
            this.SeedLabel = new System.Windows.Forms.Label();
            this.SeedTextBox = new System.Windows.Forms.TextBox();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.S17CheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // NumDecksLabel
            // 
            this.NumDecksLabel.AutoSize = true;
            this.NumDecksLabel.Location = new System.Drawing.Point(46, 70);
            this.NumDecksLabel.Name = "NumDecksLabel";
            this.NumDecksLabel.Size = new System.Drawing.Size(105, 15);
            this.NumDecksLabel.TabIndex = 0;
            this.NumDecksLabel.Text = "Number of Decks:";
            this.NumDecksLabel.Click += new System.EventHandler(this.NumDecksLabel_Click);
            // 
            // NumDecksComboBox
            // 
            this.NumDecksComboBox.FormattingEnabled = true;
            this.NumDecksComboBox.Location = new System.Drawing.Point(157, 67);
            this.NumDecksComboBox.Name = "NumDecksComboBox";
            this.NumDecksComboBox.Size = new System.Drawing.Size(121, 21);
            this.NumDecksComboBox.Sorted = true;
            this.NumDecksComboBox.TabIndex = 1;
            this.NumDecksComboBox.Text = "1";
            this.NumDecksComboBox.SelectedIndexChanged += new System.EventHandler(this.NumDecksComboBox_SelectedIndexChanged);
            // 
            // SeedLabel
            // 
            this.SeedLabel.AutoSize = true;
            this.SeedLabel.Location = new System.Drawing.Point(112, 126);
            this.SeedLabel.Name = "SeedLabel";
            this.SeedLabel.Size = new System.Drawing.Size(39, 15);
            this.SeedLabel.TabIndex = 2;
            this.SeedLabel.Text = "Seed:";
            this.SeedLabel.Click += new System.EventHandler(this.SeedLabel_Click);
            // 
            // SeedTextBox
            // 
            this.SeedTextBox.Location = new System.Drawing.Point(157, 121);
            this.SeedTextBox.Name = "SeedTextBox";
            this.SeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.SeedTextBox.TabIndex = 3;
            this.SeedTextBox.Text = "999";
            this.SeedTextBox.TextChanged += new System.EventHandler(this.SeedTextBox_TextChanged);
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Location = new System.Drawing.Point(112, 189);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(42, 15);
            this.ModeLabel.TabIndex = 5;
            this.ModeLabel.Text = "Mode:";
            this.ModeLabel.Click += new System.EventHandler(this.ModeLabel_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(148, 286);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(118, 71);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // S17CheckBox
            // 
            this.S17CheckBox.AutoSize = true;
            this.S17CheckBox.Location = new System.Drawing.Point(168, 187);
            this.S17CheckBox.Name = "S17CheckBox";
            this.S17CheckBox.Size = new System.Drawing.Size(51, 19);
            this.S17CheckBox.TabIndex = 7;
            this.S17CheckBox.Text = "S17";
            this.S17CheckBox.UseVisualStyleBackColor = true;
            this.S17CheckBox.CheckedChanged += new System.EventHandler(this.S17CheckBox_CheckedChanged);
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 439);
            this.Controls.Add(this.S17CheckBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ModeLabel);
            this.Controls.Add(this.SeedTextBox);
            this.Controls.Add(this.SeedLabel);
            this.Controls.Add(this.NumDecksComboBox);
            this.Controls.Add(this.NumDecksLabel);
            this.Name = "StartingForm";
            this.Text = "Start Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumDecksLabel;
        private System.Windows.Forms.ComboBox NumDecksComboBox;
        private System.Windows.Forms.Label SeedLabel;
        private System.Windows.Forms.TextBox SeedTextBox;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.CheckBox S17CheckBox;
    }
}

