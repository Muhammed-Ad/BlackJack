using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project2;

namespace SubProject
{
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int seed; int NumDecks; 
            bool s17 = S17CheckBox.Checked;
            while(!int.TryParse(SeedTextBox.Text, out seed))
                MessageBox.Show("Seed must be an integer"); //build the constructor to put args

            while(!int.TryParse(NumDecksComboBox.Text, out NumDecks))
                MessageBox.Show("Number of decks must be an integer");
            Form1 GameForm = new Form1();
            GameForm.Show();
        }
    }
}
