
namespace Project2
{
    partial class gameSetting
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
            this.label3 = new System.Windows.Forms.Label();
            this.seedTxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.seedReset_bttn = new System.Windows.Forms.Button();
            this.gameMode_cbBox = new System.Windows.Forms.ComboBox();
            this.playBttn = new System.Windows.Forms.Button();
            this.gameSetting_img = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameSetting_img)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Black Jack";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seed";
            // 
            // seedTxtbox
            // 
            this.seedTxtbox.Location = new System.Drawing.Point(16, 63);
            this.seedTxtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.seedTxtbox.Name = "seedTxtbox";
            this.seedTxtbox.Size = new System.Drawing.Size(52, 20);
            this.seedTxtbox.TabIndex = 3;
            this.seedTxtbox.TextChanged += new System.EventHandler(this.seedTxtbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Game mode";
            // 
            // seedReset_bttn
            // 
            this.seedReset_bttn.Location = new System.Drawing.Point(16, 102);
            this.seedReset_bttn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.seedReset_bttn.Name = "seedReset_bttn";
            this.seedReset_bttn.Size = new System.Drawing.Size(82, 31);
            this.seedReset_bttn.TabIndex = 5;
            this.seedReset_bttn.Text = "Reset Seed";
            this.seedReset_bttn.UseVisualStyleBackColor = true;
            // 
            // gameMode_cbBox
            // 
            this.gameMode_cbBox.FormattingEnabled = true;
            this.gameMode_cbBox.Items.AddRange(new object[] {
            "H17",
            "S17"});
            this.gameMode_cbBox.Location = new System.Drawing.Point(184, 55);
            this.gameMode_cbBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gameMode_cbBox.Name = "gameMode_cbBox";
            this.gameMode_cbBox.Size = new System.Drawing.Size(62, 21);
            this.gameMode_cbBox.TabIndex = 6;
            // 
            // playBttn
            // 
            this.playBttn.Location = new System.Drawing.Point(362, 102);
            this.playBttn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playBttn.Name = "playBttn";
            this.playBttn.Size = new System.Drawing.Size(60, 36);
            this.playBttn.TabIndex = 7;
            this.playBttn.Text = "PLAY";
            this.playBttn.UseVisualStyleBackColor = true;
            this.playBttn.Click += new System.EventHandler(this.playBttn_Click);
            // 
            // gameSetting_img
            // 
            this.gameSetting_img.BackgroundImage = global::Project2.Properties.Resources.cta;
            this.gameSetting_img.Location = new System.Drawing.Point(1, 159);
            this.gameSetting_img.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gameSetting_img.Name = "gameSetting_img";
            this.gameSetting_img.Size = new System.Drawing.Size(435, 131);
            this.gameSetting_img.TabIndex = 8;
            this.gameSetting_img.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "S17";
            // 
            // gameSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(180)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(436, 291);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gameSetting_img);
            this.Controls.Add(this.playBttn);
            this.Controls.Add(this.gameMode_cbBox);
            this.Controls.Add(this.seedReset_bttn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.seedTxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "gameSetting";
            this.Text = "gameSetting";
            ((System.ComponentModel.ISupportInitialize)(this.gameSetting_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox seedTxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button seedReset_bttn;
        private System.Windows.Forms.ComboBox gameMode_cbBox;
        private System.Windows.Forms.Button playBttn;
        private System.Windows.Forms.PictureBox gameSetting_img;
        private System.Windows.Forms.Label label2;
    }
}