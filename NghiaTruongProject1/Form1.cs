using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project1
{
    /// <summary>
    /// Form1 class inherits from Form
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// default constructor
        /// initialize all Components
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }          
        
        /// <summary>
        /// method for the frame load
        /// set invisible some components
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_seednum.ReadOnly = true;
            chart1.Visible = false;
            chart2.Visible = false;
            set_visible_group_of_components(false,false);
        }


        /// <summary>
        /// method for the Roll button click
        /// execute events when button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRoll_Click(object sender, EventArgs e)
        {
            var die = new aDie();

            //declare new datas to get number on the die after roll
            int die1 = die.Roll();
            int die2 = die.Roll();
            //show picture box of 2 dice
            pbDiceShow1.Visible = true;
            pbDiceShow2.Visible = true;

            //call function to show dice
            show_dice(die1, die2);
        }


        /// <summary>
        /// method for statistic button
        /// execute events when button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnStatistic_Click(object sender, EventArgs e)
        {

            //declare and initialize variables to store Seed number and number of Rolls
            int seed = 0, rolls = 0;

            //visible neccessary component, clear text box and get neccessary value
            clear_text_box();
            chart2.Visible = false;
            bool flag = get_textbox_value(ref seed, ref rolls, true);
            //if flag is false, stop the method
            if (flag == false)
            {
                return;
            }

            //visible the statistic chart
            chart1.Visible = true;

            //Dice1_count as an array of size 6
            // Declare and set array element values.
            int[] die1_count = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            int[] die2_count = new int[] { 0, 0, 0, 0, 0, 0, 0 };


            //create aDie objects
            aDie die_object1;
            aDie die_object2;
            //if seed is empty use default seed 
            //by calling default constructor aDie
            if (String.IsNullOrEmpty(textBox_seednum.Text))
            {
                die_object1 = new aDie();
                die_object2 = new aDie();
            }
            //else call the constructor with seed parameter
            else
            {
                //aDie objects with the input seed number
                die_object1 = new aDie(seed);
                die_object2 = new aDie(seed);
            }
            

            double sum_die1 = 0, sum_die2 = 0;
            int update = 10;

            
            for (int i = 1; i < rolls + 1; ++i)
            {
                //get the value of dice
                int die_number1 = die_object1.Roll();
                int die_number2 = die_object2.Roll();

                //count number of dice
                die1_count[die_number1] += 1;
                die2_count[die_number2] += 1;

                //sum of each die
                sum_die1 += die_number1;
                sum_die2 += die_number2;

                
                //update the chart every number of roll / 100
                //ex: 600 rolls total will be updated every 6 rolls
                //for 60 rolls, it also update every 6 rolls
                if (rolls < 100)
                {
                    if (i % update == 0)
                    {
                        for (int j = 1; j < 7; j++)
                        {
                            chart1.Series["Die_1_Rolls"].Points.AddXY(j, die1_count[j]);
                            chart1.Series["Die_2_Rolls"].Points.AddXY(j, die2_count[j]);

                        }
                        //update every 0.05s
                        await Task.Delay(50);
                    }

                }
                else
                {
                    if (i % (rolls / 100) == 0)
                    {
                        //setup for the chart (x axis, y axis)
                        for (int j = 1; j < 7; j++)
                        {
                            chart1.Series["Die_1_Rolls"].Points.AddXY(j, die1_count[j]);
                            chart1.Series["Die_2_Rolls"].Points.AddXY(j, die2_count[j]);              

                        }
                        //update every 0.05s
                        await Task.Delay(50);
                    }
                }        

            }
            //find max, min, mean
            //calculate the mean for each die
            double mean_die1 = sum_die1 / rolls;
            double mean_die2 = sum_die2 / rolls;
            //round 2 decimal places
            mean_die1 = Math.Round(mean_die1, 2);
            mean_die2 = Math.Round(mean_die2, 2);

            //display on the textBoxes
            textBox_mean_die1.Text = mean_die1.ToString();
            textBox_mean_die2.Text = mean_die2.ToString();

            //get the max and min values from each die
            int die1_max = die1_count.Max();
            int die2_max = die2_count.Max();

            
            //find the min value
            //because in sum array, value from 1 to 6, therefore, 0 at index 0
            //and in 60 rolls (the minimum) still has chance to a number does not appear
            //therefore, I decided to count by compare each elements, not using .Min()
            int die1_min = die1_count[1], die2_min = die2_count[1];

            int min1_index = 1, min2_index = 1;

            //the loop start at index 1 -> 6
            for (int i = 1; i < die1_count.Length; ++i)
            {
                if (die1_count[i] < die1_min)
                {
                    die1_min = die1_count[i];
                    min1_index = i;
                }
                if(die2_count[i] < die2_min)
                {
                    die2_min = die2_count[i];
                    min2_index = i;
                }

            }


            //display the max value to textbox
            textBox_max1.Text = die1_max.ToString() + " Face " + die1_count.ToList().IndexOf(die1_max);
            textBox_max2.Text = die2_max.ToString() + " Face " + die2_count.ToList().IndexOf(die2_max);

            
            //display the min value to textbox
            textBox_min1.Text = die1_min.ToString() + " Face " + min1_index;
            textBox_min2.Text = die2_min.ToString() + " Face " + min2_index;
            
            set_visible_group_of_components(true,false);
            
        }

        /// <summary>
        /// method to reset button when clicked
        /// clean components and change the seed go back to 999
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            //clear the data of the statistic chart when clicked
            foreach (var element in chart1.Series)
            {
                element.Points.Clear();
            }

            //clear the data of the sum of 2 dice chart when clicked
            foreach (var element in chart2.Series)
            {
                element.Points.Clear();
            }

            //clear the text boxes
            clear_text_box();

            //return the default value of seed number = 999
            textBox_seednum.Text = "999";

            //invisible neccessary boxes
            set_visible_group_of_components(false,false);
            //for sum of 2 dice case
            set_visible_group_of_components(false, true);

            //allow user to change num seed
            textBox_seednum.ReadOnly = false;
            
        }

        /// <summary>
        /// Method: sum of 2 dice when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnSumOf2Dice_Click(object sender, EventArgs e)
        {
            //invisible information related to statistic chart
            set_visible_group_of_components(false,false);
            //clear text boxes
            clear_text_box();

            int seed = 0, rolls = 0;
            bool flag = get_textbox_value(ref seed, ref rolls, false);

            //if flag = false, stop the method
            if(flag == false)
            {
                return;
            }

            // Declare and set array element values.
            int arr_size = 13;
            int[] sum = new int[arr_size];
            
            //assign or initialize the basic sum array with 0
            //explain: we have 2 dice, so the minimum sum is 2 (die 1 = 1, die 2 = 1) and max is 12 (die 1 = 6, die 2 = 6)
            for(int i = 0; i < arr_size; ++i)
            {
                sum[i] = 0;
            }

            //visible chart
            chart2.Visible = true;

            //create aDie objects for each die
            aDie die_object1;
            aDie die_object2;

            //if seed is empty use default seed 
            //by calling default constructor aDie
            if (String.IsNullOrEmpty(textBox_seednum.Text))
            {
                die_object1 = new aDie();
                die_object2 = new aDie();
            }
            //else call the constructor with seed parameter
            else
            {
                //aDie objects with the input seed number
                die_object1 = new aDie(seed);
                die_object2 = new aDie(seed);
            }

            int update = 10;
            for (int i = 1; i < rolls + 1; ++i)
            {
                //get random values of dice (1 ->6)
                int die_number1 = die_object1.Roll();
                int die_number2 = die_object2.Roll();

                //get sum of both dice values and store to sum[] array
                sum[die_number1 + die_number2] += 1;

                //add to the chart
                //the sum range is between 2 and 12 (inclusive)
                if (rolls < 100)
                {
                    if (i % update == 0)
                    {
                        for (int j = 2; j < arr_size; ++j)
                        {
                            chart2.Series["Sum of 2 Dice"].Points.AddXY(j, sum[j]);

                        }
                        await Task.Delay(50);
                    }

                }
                else
                {
                    if (i % (rolls / 100) == 0)
                    {
                        //setup for the chart (x axis, y axis)
                        for (int j = 2; j < arr_size; ++j)
                        {
                            chart2.Series["Sum of 2 Dice"].Points.AddXY(j, sum[j]);
                            
                        }
                        await Task.Delay(50);
                    }
                }
            }            

            //get the max and min values from each die
            int sum_max = sum.Max();

            //find the min value
            //because in sum array, value from 2 to 12, therefore, 0 at index 0 and 0 at index 1
            int sum_min = sum[2];
            int sum_value = 2;

            //the loop start at index 2 -> 12
            for(int i = 2; i < sum.Length; ++i)
            {
                if(sum[i] < sum_min)
                {
                    sum_min = sum[i];
                    sum_value = i;
                }
            }
            

            //display the max value to textbox
            textBox_max1.Text = sum_max.ToString() + " at " + sum.ToList().IndexOf(sum_max);

            //display the min value to textbox
            textBox_min1.Text = sum_min.ToString() + " at " + sum_value;
            set_visible_group_of_components(true, true);


        }

        /// <summary>
        /// Method: get the text box values
        /// also check the valid input by using try catch
        /// display the error message if necessary
        /// </summary>
        /// <param name="seed">the seed number pass by reference</param>
        /// <param name="rolls">the number of rolls pass by reference</param>
        /// <param name="chart_statistic">boolean value to know if it's for statistic button or not</param>
        /// <returns></returns>
        private bool get_textbox_value(ref int seed, ref int rolls, bool chart_statistic)
        {            
            //if function called from statistic button
            if(chart_statistic == true)
            {
                //clear the data of the chart when clicked
                foreach (var element in chart1.Series)
                {
                    element.Points.Clear();
                }
            }
            //if function called from sum of 2 dice button
            else
            {
                //clear the data of the chart when clicked
                foreach (var element in chart2.Series)
                {
                    element.Points.Clear();
                }
            }
            

            //if user does not enter number of rolls
            if (String.IsNullOrEmpty(cbBox_num_rolls.Text))
            {
                MessageBox.Show("Number of Rolls is EMPTY!", "Error Message");
                return false;
            }

            else
            {
                try
                {
                    //get the value from the box as integer
                    rolls = int.Parse(cbBox_num_rolls.Text);

                    //if empty box in seed number, set seed = 999 (default seed)
                    if (String.IsNullOrEmpty(textBox_seednum.Text))
                    {
                        MessageBox.Show("The Seed is EMPTY! Use DEFAULT SEED!!!", "Notify!");
                        return true;
                    }
                    else
                    {
                        seed = int.Parse(textBox_seednum.Text);
                        return true;
                    }

                }
                catch
                {
                    //Display the error and stop if fail to parse
                    MessageBox.Show("Invalid Input! Only Interger!!!", "Error Message");
                    return false;
                }
            }
        }

        /// <summary>
        /// function to set a bunch of boxes, labels, and chart being visible or invisible
        /// </summary>
        /// <param name="visible"> take parameter to recognize if it's visible or not</param>
        /// <param name="sum_case">take parameter to recognize if it's sum of 2 dice or not</param>
        private void set_visible_group_of_components(bool visible, bool sum_case)
        {
            
            if (!sum_case)
            {
                //set visible
                if (visible)
                {
                    textBox_max1.Visible = true;
                    textBox_max2.Visible = true;
                    textBox_min1.Visible = true;
                    textBox_min2.Visible = true;
                    textBox_mean_die1.Visible = true;
                    textBox_mean_die2.Visible = true;
                    label_die1.Visible = true;
                    label_die2.Visible = true;
                    label_max1.Visible = true;
                    label_max2.Visible = true;
                    label_mean1.Visible = true;
                    label_mean2.Visible = true;
                    label_min1.Visible = true;
                    label_min2.Visible = true;
                    chart1.Visible = true;

                }
                //set invisible
                else
                {
                    textBox_max1.Visible = false;
                    textBox_max2.Visible = false;
                    textBox_min1.Visible = false;
                    textBox_min2.Visible = false;
                    textBox_mean_die1.Visible = false;
                    textBox_mean_die2.Visible = false;
                    label_die1.Visible = false;
                    label_die2.Visible = false;
                    label_max1.Visible = false;
                    label_max2.Visible = false;
                    label_mean1.Visible = false;
                    label_mean2.Visible = false;
                    label_min1.Visible = false;
                    label_min2.Visible = false;
                    chart1.Visible = false;
                }
            }
            else
            {
                if (visible)
                {
                    //set visible for only sum_case
                    label_max1.Visible = true;
                    label_min1.Visible = true;
                    textBox_max1.Visible = true;
                    textBox_min1.Visible = true;
                }
                else
                {
                    //set invisible for only sum_case
                    label_max1.Visible = false;
                    label_min1.Visible = false;
                    textBox_max1.Visible = false;
                    textBox_min1.Visible = false;
                    chart2.Visible = false;
                }
            }
            

        }

        /// <summary>
        /// function to show dice in the picturebox
        /// </summary>
        /// <param name="num_die"> take parameter to determine which die will be shown</param>
        private void show_dice(int die1, int die2)
        {
            //compare the data with each random number
            switch (die1)
            {
                case 1:
                    //show face of 1
                    pbDiceShow1.Image = Properties.Resources._1;
                    break;

                case 2:
                    //show face of 2
                    pbDiceShow1.Image = Properties.Resources._2;
                    break;
                case 3:
                    //show face of 3
                    pbDiceShow1.Image = Properties.Resources._3;
                    break;
                case 4:
                    //show face of 4
                    pbDiceShow1.Image = Properties.Resources._4;
                    break;
                case 5:
                    //show face of 5
                    pbDiceShow1.Image = Properties.Resources._5;
                    break;
                case 6:
                    //show face of 6
                    pbDiceShow1.Image = Properties.Resources._6;
                    break;
            }

            //compare the data with each random number
            switch (die2)
            {
                case 1:
                    //show face of 1
                    pbDiceShow2.Image = Properties.Resources._1;
                    break;
                case 2:
                    //show face of 2
                    pbDiceShow2.Image = Properties.Resources._2;
                    break;
                case 3:
                    //show face of 3
                    pbDiceShow2.Image = Properties.Resources._3;
                    break;
                case 4:
                    //show face of 4
                    pbDiceShow2.Image = Properties.Resources._4;
                    break;
                case 5:
                    //show face of 5
                    pbDiceShow2.Image = Properties.Resources._5;
                    break;
                case 6:
                    //show face of 6
                    pbDiceShow2.Image = Properties.Resources._6;
                    break;
            }
        }

        /// <summary>
        /// Method: clear all the text boxes
        /// clean the text boxes before using them again
        /// </summary>
        private void clear_text_box()
        {
            textBox_max1.Text = "";
            textBox_max2.Text = "";
            textBox_min1.Text = "";
            textBox_min2.Text = "";
            textBox_mean_die1.Text = "";
            textBox_mean_die2.Text = "";
        }

        private void textBox_max_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_mean_die1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
