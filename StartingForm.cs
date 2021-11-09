using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
        }

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
            else if(NumDecks < 1)
            {
                MessageBox.Show("Number of decks must be an integer greater than 0");
                return;
            }

            if(!s17)
            {
                MessageBox.Show("Game Mode: H17", "Notice"); //build the constructor to put args
            }
            
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
            
            GameForm GameForm = new GameForm( NumDecks, s17, seed);
            GameForm.Show();
        }

        private void StartingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
