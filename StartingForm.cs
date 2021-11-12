using System;
using System.Windows.Forms;

/// <summary>
/// Project: Black Jack
/// Group 1: Jason Truong, Muhammed Ademola
/// </summary>

namespace Project2
{
    /// <summary>
    /// Starting form class
    /// </summary>
    public partial class StartingForm : Form
    {
        /// <summary>
        /// constructor StartingForm
        /// </summary>
        public StartingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// method in case Start button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            int seed; int NumDecks = 1;
            bool s17 = S17CheckBox.Checked;
            //check value of game mode comboBox
            //var index = gameModecomboBox.FindStringExact(gameModecomboBox.Text);
            if (!int.TryParse(NumDecksTextBox.Text, out NumDecks))
            {
                MessageBox.Show("You choose the Number of Decks!", "Error");
                return;

            }
            //check invalid number of decks
            else if(NumDecks < 1)
            {
                MessageBox.Show("Number of decks must be an integer greater than 0");
                return;
            }

            //check mode
            if(!s17)
            {
                MessageBox.Show("Game Mode: H17", "Notice"); //build the constructor to put args
            }
            
            //check seed
            if(string.IsNullOrEmpty(SeedTextBox.Text) || string.IsNullOrWhiteSpace(SeedTextBox.Text))
            {
                seed = -1;
                MessageBox.Show("Seed empty, using default seed", "Notice");
            }
            else
            {
                if (!int.TryParse(SeedTextBox.Text, out seed))
                {
                    MessageBox.Show("Seed must be an integer"); //build the constructor to put args
                    return;
                }
            }
            //call game form
            GameForm GameForm = new GameForm( NumDecks, s17, seed);
            GameForm.Show();
        }
    }
}
