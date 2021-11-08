﻿
namespace Project2
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
            this.S17CheckBox = new System.Windows.Forms.CheckBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.SeedTextBox = new System.Windows.Forms.TextBox();
            this.SeedLabel = new System.Windows.Forms.Label();
            this.NumDecksLabel = new System.Windows.Forms.Label();
            this.NumDecksTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // S17CheckBox
            // 
            this.S17CheckBox.AutoSize = true;
            this.S17CheckBox.Location = new System.Drawing.Point(168, 184);
            this.S17CheckBox.Name = "S17CheckBox";
            this.S17CheckBox.Size = new System.Drawing.Size(51, 19);
            this.S17CheckBox.TabIndex = 14;
            this.S17CheckBox.Text = "S17";
            this.S17CheckBox.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(159, 281);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(118, 71);
            this.StartButton.TabIndex = 13;
            this.StartButton.Text = "New Player";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Location = new System.Drawing.Point(123, 184);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(42, 15);
            this.ModeLabel.TabIndex = 12;
            this.ModeLabel.Text = "Mode:";
            // 
            // SeedTextBox
            // 
            this.SeedTextBox.Location = new System.Drawing.Point(168, 116);
            this.SeedTextBox.Name = "SeedTextBox";
            this.SeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.SeedTextBox.TabIndex = 11;
            // 
            // SeedLabel
            // 
            this.SeedLabel.AutoSize = true;
            this.SeedLabel.Location = new System.Drawing.Point(123, 121);
            this.SeedLabel.Name = "SeedLabel";
            this.SeedLabel.Size = new System.Drawing.Size(39, 15);
            this.SeedLabel.TabIndex = 10;
            this.SeedLabel.Text = "Seed:";
            // 
            // NumDecksLabel
            // 
            this.NumDecksLabel.AutoSize = true;
            this.NumDecksLabel.Location = new System.Drawing.Point(57, 65);
            this.NumDecksLabel.Name = "NumDecksLabel";
            this.NumDecksLabel.Size = new System.Drawing.Size(105, 15);
            this.NumDecksLabel.TabIndex = 8;
            this.NumDecksLabel.Text = "Number of Decks:";
            // 
            // NumDecksTextBox
            // 
            this.NumDecksTextBox.Location = new System.Drawing.Point(168, 62);
            this.NumDecksTextBox.Name = "NumDecksTextBox";
            this.NumDecksTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumDecksTextBox.TabIndex = 15;
            this.NumDecksTextBox.Text = "1";
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 421);
            this.Controls.Add(this.NumDecksTextBox);
            this.Controls.Add(this.S17CheckBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ModeLabel);
            this.Controls.Add(this.SeedTextBox);
            this.Controls.Add(this.SeedLabel);
            this.Controls.Add(this.NumDecksLabel);
            this.Name = "StartingForm";
            this.Text = "StartingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox S17CheckBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.TextBox SeedTextBox;
        private System.Windows.Forms.Label SeedLabel;
        private System.Windows.Forms.Label NumDecksLabel;
        private System.Windows.Forms.TextBox NumDecksTextBox;
    }
}