
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingForm));
            this.S17CheckBox = new System.Windows.Forms.CheckBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.SeedTextBox = new System.Windows.Forms.TextBox();
            this.SeedLabel = new System.Windows.Forms.Label();
            this.NumDecksLabel = new System.Windows.Forms.Label();
            this.NumDecksTextBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // S17CheckBox
            // 
            this.S17CheckBox.AutoSize = true;
            this.S17CheckBox.BackColor = System.Drawing.Color.Transparent;
            this.S17CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S17CheckBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.S17CheckBox.Location = new System.Drawing.Point(168, 180);
            this.S17CheckBox.Name = "S17CheckBox";
            this.S17CheckBox.Size = new System.Drawing.Size(73, 29);
            this.S17CheckBox.TabIndex = 14;
            this.S17CheckBox.Text = "S17";
            this.S17CheckBox.UseVisualStyleBackColor = false;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StartButton.Image = global::Project2.Properties.Resources.online_casino2_generated;
            this.StartButton.Location = new System.Drawing.Point(99, 286);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(167, 76);
            this.StartButton.TabIndex = 13;
            this.StartButton.Text = "New Player";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ModeLabel.Location = new System.Drawing.Point(95, 180);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(68, 25);
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
            this.SeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.SeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeedLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SeedLabel.Location = new System.Drawing.Point(97, 114);
            this.SeedLabel.Name = "SeedLabel";
            this.SeedLabel.Size = new System.Drawing.Size(65, 25);
            this.SeedLabel.TabIndex = 10;
            this.SeedLabel.Text = "Seed:";
            // 
            // NumDecksLabel
            // 
            this.NumDecksLabel.AutoSize = true;
            this.NumDecksLabel.BackColor = System.Drawing.Color.Transparent;
            this.NumDecksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumDecksLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.NumDecksLabel.Location = new System.Drawing.Point(12, 63);
            this.NumDecksLabel.Name = "NumDecksLabel";
            this.NumDecksLabel.Size = new System.Drawing.Size(168, 25);
            this.NumDecksLabel.TabIndex = 8;
            this.NumDecksLabel.Text = "Number of Decks:";
            // 
            // NumDecksTextBox
            // 
            this.NumDecksTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NumDecksTextBox.FormattingEnabled = true;
            this.NumDecksTextBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.NumDecksTextBox.Location = new System.Drawing.Point(168, 62);
            this.NumDecksTextBox.Name = "NumDecksTextBox";
            this.NumDecksTextBox.Size = new System.Drawing.Size(100, 21);
            this.NumDecksTextBox.TabIndex = 16;
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::Project2.Properties.Resources.online_casino2_generated;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(374, 444);
            this.Controls.Add(this.NumDecksTextBox);
            this.Controls.Add(this.S17CheckBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ModeLabel);
            this.Controls.Add(this.SeedTextBox);
            this.Controls.Add(this.SeedLabel);
            this.Controls.Add(this.NumDecksLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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
        private System.Windows.Forms.ComboBox NumDecksTextBox;
    }
}