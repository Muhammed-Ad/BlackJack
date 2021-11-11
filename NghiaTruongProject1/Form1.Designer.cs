
namespace Project1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbBox_num_rolls = new System.Windows.Forms.ComboBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.pbDiceShow1 = new System.Windows.Forms.PictureBox();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.textBox_seednum = new System.Windows.Forms.TextBox();
            this.label_seed_num = new System.Windows.Forms.Label();
            this.label_num_rolls = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pbDiceShow2 = new System.Windows.Forms.PictureBox();
            this.btnSumOf2Dice = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox_mean_die1 = new System.Windows.Forms.TextBox();
            this.label_mean1 = new System.Windows.Forms.Label();
            this.label_max1 = new System.Windows.Forms.Label();
            this.label_min1 = new System.Windows.Forms.Label();
            this.textBox_max1 = new System.Windows.Forms.TextBox();
            this.textBox_min1 = new System.Windows.Forms.TextBox();
            this.label_mean2 = new System.Windows.Forms.Label();
            this.textBox_mean_die2 = new System.Windows.Forms.TextBox();
            this.label_die1 = new System.Windows.Forms.Label();
            this.label_die2 = new System.Windows.Forms.Label();
            this.label_max2 = new System.Windows.Forms.Label();
            this.label_min2 = new System.Windows.Forms.Label();
            this.textBox_max2 = new System.Windows.Forms.TextBox();
            this.textBox_min2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceShow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceShow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBox_num_rolls
            // 
            this.cbBox_num_rolls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_num_rolls.FormattingEnabled = true;
            this.cbBox_num_rolls.Items.AddRange(new object[] {
            "60",
            "600",
            "6000",
            "60000"});
            this.cbBox_num_rolls.Location = new System.Drawing.Point(238, 164);
            this.cbBox_num_rolls.Name = "cbBox_num_rolls";
            this.cbBox_num_rolls.Size = new System.Drawing.Size(82, 21);
            this.cbBox_num_rolls.TabIndex = 9;
            this.cbBox_num_rolls.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.AccessibleName = "";
            this.btnRoll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRoll.BackColor = System.Drawing.Color.Transparent;
            this.btnRoll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRoll.Location = new System.Drawing.Point(53, 52);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(117, 46);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = false;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // pbDiceShow1
            // 
            this.pbDiceShow1.BackColor = System.Drawing.Color.Transparent;
            this.pbDiceShow1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDiceShow1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDiceShow1.Location = new System.Drawing.Point(238, 24);
            this.pbDiceShow1.Name = "pbDiceShow1";
            this.pbDiceShow1.Size = new System.Drawing.Size(94, 91);
            this.pbDiceShow1.TabIndex = 1;
            this.pbDiceShow1.TabStop = false;
            this.pbDiceShow1.Visible = false;
            // 
            // btnStatistic
            // 
            this.btnStatistic.Location = new System.Drawing.Point(571, 40);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(117, 46);
            this.btnStatistic.TabIndex = 3;
            this.btnStatistic.Text = "Statistic";
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(571, 118);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 46);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // textBox_seednum
            // 
            this.textBox_seednum.Location = new System.Drawing.Point(238, 213);
            this.textBox_seednum.Name = "textBox_seednum";
            this.textBox_seednum.Size = new System.Drawing.Size(82, 20);
            this.textBox_seednum.TabIndex = 6;
            this.textBox_seednum.Text = "999";
            this.textBox_seednum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_seed_num
            // 
            this.label_seed_num.AutoSize = true;
            this.label_seed_num.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_seed_num.Image = global::Project1.Properties.Resources.wibu1;
            this.label_seed_num.Location = new System.Drawing.Point(57, 216);
            this.label_seed_num.Name = "label_seed_num";
            this.label_seed_num.Size = new System.Drawing.Size(137, 13);
            this.label_seed_num.TabIndex = 7;
            this.label_seed_num.Text = "Seed Number (999 default):";
            // 
            // label_num_rolls
            // 
            this.label_num_rolls.AutoSize = true;
            this.label_num_rolls.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_num_rolls.Image = global::Project1.Properties.Resources.wibu1;
            this.label_num_rolls.Location = new System.Drawing.Point(57, 167);
            this.label_num_rolls.Name = "label_num_rolls";
            this.label_num_rolls.Size = new System.Drawing.Size(85, 13);
            this.label_num_rolls.TabIndex = 8;
            this.label_num_rolls.Text = "Number of Rolls:";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Title = "Number of Faces";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Title = "Number of Rolls";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            legend1.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(2, 251);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Die_1_Rolls";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Die_2_Rolls";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(913, 374);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // pbDiceShow2
            // 
            this.pbDiceShow2.BackColor = System.Drawing.Color.Transparent;
            this.pbDiceShow2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDiceShow2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDiceShow2.Location = new System.Drawing.Point(389, 24);
            this.pbDiceShow2.Name = "pbDiceShow2";
            this.pbDiceShow2.Size = new System.Drawing.Size(94, 91);
            this.pbDiceShow2.TabIndex = 11;
            this.pbDiceShow2.TabStop = false;
            this.pbDiceShow2.Visible = false;
            // 
            // btnSumOf2Dice
            // 
            this.btnSumOf2Dice.Location = new System.Drawing.Point(571, 199);
            this.btnSumOf2Dice.Name = "btnSumOf2Dice";
            this.btnSumOf2Dice.Size = new System.Drawing.Size(117, 46);
            this.btnSumOf2Dice.TabIndex = 12;
            this.btnSumOf2Dice.Text = "Sum of 2 Dice";
            this.btnSumOf2Dice.UseVisualStyleBackColor = true;
            this.btnSumOf2Dice.Click += new System.EventHandler(this.btnSumOf2Dice_Click);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            this.chart2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.chart2.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.Title = "Sum of 2 Dice";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.Title = "Number of Rolls";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            legend2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(2, 251);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Sum of 2 Dice";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(913, 374);
            this.chart2.TabIndex = 13;
            this.chart2.Text = "chart2";
            // 
            // textBox_mean_die1
            // 
            this.textBox_mean_die1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox_mean_die1.Location = new System.Drawing.Point(813, 349);
            this.textBox_mean_die1.Name = "textBox_mean_die1";
            this.textBox_mean_die1.Size = new System.Drawing.Size(74, 20);
            this.textBox_mean_die1.TabIndex = 14;
            this.textBox_mean_die1.TextChanged += new System.EventHandler(this.textBox_mean_die1_TextChanged);
            // 
            // label_mean1
            // 
            this.label_mean1.AutoSize = true;
            this.label_mean1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_mean1.Location = new System.Drawing.Point(750, 352);
            this.label_mean1.Name = "label_mean1";
            this.label_mean1.Size = new System.Drawing.Size(37, 13);
            this.label_mean1.TabIndex = 17;
            this.label_mean1.Text = "Mean:";
            // 
            // label_max1
            // 
            this.label_max1.AutoSize = true;
            this.label_max1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_max1.Location = new System.Drawing.Point(749, 380);
            this.label_max1.Name = "label_max1";
            this.label_max1.Size = new System.Drawing.Size(61, 13);
            this.label_max1.TabIndex = 18;
            this.label_max1.Text = "Max Count:";
            // 
            // label_min1
            // 
            this.label_min1.AutoSize = true;
            this.label_min1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_min1.Location = new System.Drawing.Point(750, 406);
            this.label_min1.Name = "label_min1";
            this.label_min1.Size = new System.Drawing.Size(58, 13);
            this.label_min1.TabIndex = 19;
            this.label_min1.Text = "Min Count:";
            // 
            // textBox_max1
            // 
            this.textBox_max1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox_max1.Location = new System.Drawing.Point(813, 377);
            this.textBox_max1.Name = "textBox_max1";
            this.textBox_max1.Size = new System.Drawing.Size(74, 20);
            this.textBox_max1.TabIndex = 20;
            this.textBox_max1.TextChanged += new System.EventHandler(this.textBox_max_TextChanged);
            // 
            // textBox_min1
            // 
            this.textBox_min1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox_min1.Location = new System.Drawing.Point(813, 403);
            this.textBox_min1.Name = "textBox_min1";
            this.textBox_min1.Size = new System.Drawing.Size(74, 20);
            this.textBox_min1.TabIndex = 21;
            // 
            // label_mean2
            // 
            this.label_mean2.AutoSize = true;
            this.label_mean2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_mean2.Location = new System.Drawing.Point(750, 459);
            this.label_mean2.Name = "label_mean2";
            this.label_mean2.Size = new System.Drawing.Size(37, 13);
            this.label_mean2.TabIndex = 22;
            this.label_mean2.Text = "Mean:";
            // 
            // textBox_mean_die2
            // 
            this.textBox_mean_die2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox_mean_die2.Location = new System.Drawing.Point(813, 456);
            this.textBox_mean_die2.Name = "textBox_mean_die2";
            this.textBox_mean_die2.Size = new System.Drawing.Size(74, 20);
            this.textBox_mean_die2.TabIndex = 23;
            // 
            // label_die1
            // 
            this.label_die1.AutoSize = true;
            this.label_die1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_die1.Font = new System.Drawing.Font("Bodoni MT Black", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_die1.Location = new System.Drawing.Point(749, 325);
            this.label_die1.Name = "label_die1";
            this.label_die1.Size = new System.Drawing.Size(57, 16);
            this.label_die1.TabIndex = 24;
            this.label_die1.Text = "Die #1:";
            // 
            // label_die2
            // 
            this.label_die2.AutoSize = true;
            this.label_die2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_die2.Font = new System.Drawing.Font("Bodoni MT Black", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_die2.Location = new System.Drawing.Point(749, 433);
            this.label_die2.Name = "label_die2";
            this.label_die2.Size = new System.Drawing.Size(57, 16);
            this.label_die2.TabIndex = 25;
            this.label_die2.Text = "Die #2:";
            // 
            // label_max2
            // 
            this.label_max2.AutoSize = true;
            this.label_max2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_max2.Location = new System.Drawing.Point(750, 485);
            this.label_max2.Name = "label_max2";
            this.label_max2.Size = new System.Drawing.Size(61, 13);
            this.label_max2.TabIndex = 26;
            this.label_max2.Text = "Max Count:";
            // 
            // label_min2
            // 
            this.label_min2.AutoSize = true;
            this.label_min2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_min2.Location = new System.Drawing.Point(749, 511);
            this.label_min2.Name = "label_min2";
            this.label_min2.Size = new System.Drawing.Size(58, 13);
            this.label_min2.TabIndex = 27;
            this.label_min2.Text = "Min Count:";
            // 
            // textBox_max2
            // 
            this.textBox_max2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox_max2.Location = new System.Drawing.Point(814, 482);
            this.textBox_max2.Name = "textBox_max2";
            this.textBox_max2.Size = new System.Drawing.Size(74, 20);
            this.textBox_max2.TabIndex = 28;
            // 
            // textBox_min2
            // 
            this.textBox_min2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox_min2.Location = new System.Drawing.Point(813, 508);
            this.textBox_min2.Name = "textBox_min2";
            this.textBox_min2.Size = new System.Drawing.Size(74, 20);
            this.textBox_min2.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Project1.Properties.Resources.wibu1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 624);
            this.Controls.Add(this.textBox_min2);
            this.Controls.Add(this.textBox_max2);
            this.Controls.Add(this.label_min2);
            this.Controls.Add(this.label_max2);
            this.Controls.Add(this.label_die2);
            this.Controls.Add(this.label_die1);
            this.Controls.Add(this.textBox_mean_die2);
            this.Controls.Add(this.label_mean2);
            this.Controls.Add(this.textBox_min1);
            this.Controls.Add(this.textBox_max1);
            this.Controls.Add(this.label_min1);
            this.Controls.Add(this.label_max1);
            this.Controls.Add(this.label_mean1);
            this.Controls.Add(this.textBox_mean_die1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.btnSumOf2Dice);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.pbDiceShow2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.cbBox_num_rolls);
            this.Controls.Add(this.label_num_rolls);
            this.Controls.Add(this.label_seed_num);
            this.Controls.Add(this.textBox_seednum);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStatistic);
            this.Controls.Add(this.pbDiceShow1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NghiaTruong_Project1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceShow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceShow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.PictureBox pbDiceShow1;
        private System.Windows.Forms.Button btnStatistic; //statistic
        private System.Windows.Forms.Button btnReset; //reset
        private System.Windows.Forms.TextBox textBox_seednum;
        private System.Windows.Forms.Label label_seed_num;
        private System.Windows.Forms.Label label_num_rolls;
        private System.Windows.Forms.PictureBox pbDiceShow2;
        private System.Windows.Forms.Button btnSumOf2Dice; //sum of 2 dice
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        public System.Windows.Forms.ComboBox cbBox_num_rolls;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox_mean_die1;
        private System.Windows.Forms.Label label_mean1;
        private System.Windows.Forms.Label label_max1;
        private System.Windows.Forms.Label label_min1;
        private System.Windows.Forms.TextBox textBox_max1;
        private System.Windows.Forms.TextBox textBox_min1;
        private System.Windows.Forms.Label label_mean2;
        private System.Windows.Forms.TextBox textBox_mean_die2;
        private System.Windows.Forms.Label label_die1;
        private System.Windows.Forms.Label label_die2;
        private System.Windows.Forms.Label label_max2;
        private System.Windows.Forms.Label label_min2;
        private System.Windows.Forms.TextBox textBox_max2;
        private System.Windows.Forms.TextBox textBox_min2;
    }
}

