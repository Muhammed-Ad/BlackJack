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
    
    /// <summary>
    /// Main form
    /// </summary>
    public partial class GameForm : Form
    {
        


        //imageList 
        ImageList playerPictureboxList;
        ImageList computerPictureboxList;
        

        //PictureBox computerPicturebox;
        //PictureBox playerPicturebox;
        int startingHand = 2;
        Random rand; //random number gen. to start from once given seed
        //did not specify though
        int max_cards_on_table = 11;

        //number of decks
        int nDecks;
        bool s17Mode = false;  //playing mode
        //also got a deck of card one though lol.
        aDeckOfCards deck;
        int computerSum;
        int playerSum;
        aShoe dealingShoe;
        string win = "You Won";
        string lose = "You Lost";

        

        /// <summary>
        /// form1 constructor
        /// </summary>
        public GameForm()
        {
            InitializeComponent();

            //create the new iamge list
            playerPictureboxList = new ImageList();
            //dealingShoe = new aShoe();

            
        }

        public GameForm(int seed, int NumDecks, bool mode)
        {
            InitializeComponent();

            seedTextbox.Text = seed.ToString();
            
            //create the new iamge list
            playerPictureboxList = new ImageList();
            //dealingShoe = new aShoe();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        

        /// <summary>
        /// function calls when form1 loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Form1_Load(object sender, EventArgs e)
        {
            //set starting credit to 100:
            totalTextBox.Text = "100";
         
        }

        /// <summary>
        /// function call setting button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
        //need picture box though
        private void updatePicturebox(ref PictureBox pBox, ref Hand hand)
        {
            //PUT PLAYER CARD INTO THE PICTUREBOX
            //prepare and add playerHand cards to picture box
            List<Bitmap> images = new List<Bitmap>();

            //but still missing though kinda weird.
            int totalWidth = 73 * (int)hand.Cards.Count();
            int height = 97;

            //put in the images list.
            for (int j = 0; j < hand.Cards.Count(); j++)
            {
                images.Add(hand.Cards[j].GetBitmapImage());
            }

            //create an image(bitmap)
            Bitmap combinedBitmap = new Bitmap(totalWidth, height);

            //combine the images from the bit map list - with the graphic 
            Graphics combinedGraphics = Graphics.FromImage(combinedBitmap);

            int drawingPosition = 0;

            //put into combinedGraphic (or a picture)
            foreach (Bitmap bitmap in images)
            {

                //draw image into the graphic, cool. 
                combinedGraphics.DrawImage(bitmap, new Point(drawingPosition, 0));
                drawingPosition += bitmap.Width;
            }

            //done putting in
            pBox.Image = combinedBitmap;
        }*/

        private void gameModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// function got called after click the hit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void hitButton_Click(object sender, EventArgs e)
        {
            if(playerSum >= 17)//check the s17 mode
            {

            }
        }

        private void standButton_Click(object sender, EventArgs e)
        {
           
        }

        private void dealerCards_Click(object sender, EventArgs e)
        {

        }

        private void playerPicturebox1_Click(object sender, EventArgs e)
        {

        }

        private void dealerPicturebox1_Click(object sender, EventArgs e)
        {

        }
    }
}
