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
    public partial class Form1 : Form
    {
        


        //imageList 
        ImageList playerPictureboxList;
        ImageList computerPictureboxList;
        

        //PictureBox computerPicturebox;
        //PictureBox playerPicturebox;
        int startingHand = 2;

        //did not specify though
        int max_cards_on_table = 11;

        //number of decks
        int nDecks;

        //also got a deck of card one though lol.
        aDeckOfCards deck;
        Hand playerHand;
        Hand computerHand;
        int computerSum;
        int playerSum;
        aShoe dealingShoe;
        string win = "You Won";
        string lose = "You Lost";

        

        /// <summary>
        /// form1 constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            //create the new iamge list
            playerPictureboxList = new ImageList();
            //dealingShoe = new aShoe();

            playerHand = new Hand();
            computerHand = new Hand();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// function got called after click the hit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hitBttn_Click(object sender, EventArgs e)
        {

            /*
            aCard a = new aCard();

            aCard drawn = decks[0].cards[decks[0].cards.Count - 1];

            //remvove from deck
            decks[0].cards.Remove(drawn);

            //add to hands
            //hand.Cards.Add(drawn);
            */


            //shuffle is an aShoe obj
            //IDrawCard interfaceObj = dealingShoe;


            //draw a card and remove from deck.
            aCard aSingleCard = dealingShoe.Draw();

            //add to hands 
            playerHand.Cards.Add(aSingleCard);
            playerHand.AddValue(aSingleCard,ref playerSum);
            player_status_label.Text = playerSum.ToString();

            if(playerSum > 21)
            {
                win_loseLabel.Text = lose;
            }

            //PUT PLAYER CARD INTO THE PICTUREBOX
            //prepare and add playerHand cards to picture box
            List<Bitmap> images = new List<Bitmap>();
            int totalWidth = 73 * (int) playerHand.Cards.Count();
            int height = 97;

            //put in the images list.
            for (int j = 0; j < playerHand.Cards.Count(); j++)
            {
                images.Add(playerHand.Cards[j].GetBitmapImage());
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
            playerPicturebox.Image = combinedBitmap;



        }

        /// <summary>
        /// function calls when form1 loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Form1_Load(object sender, EventArgs e)
        {
            //set starting credit to 100:
            totalTxtbox.Text = "100";
         
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


        /// <summary>
        /// function gets called when reset button clicks, resets all
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetBttn_Click(object sender, EventArgs e)
        {
            //reset pictureboxes
            computerPicturebox.Image = null;
            playerPicturebox.Image = null;

            //delete player and delear previous game cards
            playerHand.Cards.Clear();
            computerHand.Cards.Clear();

            totalTxtbox.Text = "100";
            betTxtbox.Text = "";

        }

        /// <summary>
        /// function calls after Play button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playBttn_Click(object sender, EventArgs e)
        {
            playerSum = 0;
            computerSum = 0;
            win_loseLabel.Text = "";
            playerHand.Cards.Clear();
            computerHand.Cards.Clear();

            //get the number of deck.
            int nDeck = int.Parse(nDeckCombobox.GetItemText(nDeckCombobox.SelectedItem));

            //init a Shoe with number of deck(empty shoe?) 
            dealingShoe = new aShoe(nDeck);

            //init a hand obj
            playerHand = new Hand();

            //init a hand for computer 
            computerHand = new Hand();



            //draw 2 card for player and remove from deck.
            aCard aSingleCard;

            aSingleCard = dealingShoe.Draw();
            playerHand.Cards.Add(aSingleCard);
            //playerPictureboxList.Images.Add(aSingleCard.Image);

            aSingleCard = dealingShoe.Draw();
            playerHand.Cards.Add(aSingleCard);
            //playerPictureboxList.Images.Add(aSingleCard.Image);


            //CALCULATE PLAYER SUM
            foreach(aCard card in playerHand.Cards)
            {
                //get value of each card
                playerHand.AddValue(card,ref playerSum);
            }

            player_status_label.Text = playerSum.ToString();



            ///------------------for computer-----------------------
            //draw a card for computer

            aSingleCard = dealingShoe.Draw();
            computerHand.Cards.Add(aSingleCard);
            computerHand.AddValue(aSingleCard, ref computerSum);
            dealer_status_label.Text = computerSum.ToString();

            //if player sum == 21 
            if (playerSum == 21)
            {
                //dealer hits until its == 21 if > then lose:
                while(computerSum != 21)
                {
                    //break the loops
                    if (computerSum > 21)
                    {
                        dealer_status_label.Text = computerSum.ToString();
                        win_loseLabel.Text = win;
                        
                        //is this break of the loop though
                        break;
                    }

                    aSingleCard = dealingShoe.Draw();
                    computerHand.Cards.Add(aSingleCard);
                    computerHand.AddValue(aSingleCard, ref computerSum);
                }

                dealer_status_label.Text = computerSum.ToString();

            }
            

            
            //PUT PLAYER CARD INTO THE PICTUREBOX
            //prepare and add playerHand cards to picture box
            List<Bitmap> images = new List<Bitmap>();
            int totalWidth = 73*2;
            int height = 97;

            //put in the images list.
            for( int j = 0; j < playerHand.Cards.Count(); j++)
            {
                images.Add(playerHand.Cards[j].GetBitmapImage());
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
                combinedGraphics.DrawImage(bitmap, new Point(drawingPosition,0));
                drawingPosition += bitmap.Width;
            }

            //done putting in
            playerPicturebox.Image = combinedBitmap;

            
            //DRAWING TO PICTUREBOX FOR COMPUTER
            List<Bitmap> compImages = new List<Bitmap>();
            int comp_totalWidth = 73 * (int)computerHand.Cards.Count();

            //put in the images list.
            for (int j = 0; j < computerHand.Cards.Count(); j++)
            {
                compImages.Add(computerHand.Cards[j].GetBitmapImage());
            }

            //
            Bitmap comp_combinedBitmap = new Bitmap(comp_totalWidth, height);

            //combine the images from the bit map list - with the graphic 
            Graphics comp_combinedGraphics = Graphics.FromImage(comp_combinedBitmap);

            int comp_drawingPosition = 0;

            //put into combinedGraphic (or a picture)
            foreach (Bitmap bitmap in compImages)
            {

                //draw image into the graphic, cool. 
                comp_combinedGraphics.DrawImage(bitmap, new Point(comp_drawingPosition, 0));
                comp_drawingPosition += bitmap.Width;
            }
            //done putting in
            computerPicturebox.Image = comp_combinedBitmap;

            /*


            //
            for ( int i = 0; i <)
            {

            }



            //create image for all needed images: based on number of img in 
            Bitmap combinedBitmap = new Bitmap(100, 100);

            Graphics combinedGraphics = Graphics.FromImage(combinedBitmap);

            Int32 drawingPosition = 0;

            //for images in the imageList: of the player

            //for images in the hand.cards
            foreach (Bitmap bitmap in playerHand.Cards.)
            {
                combinedGraphics.DrawImage(bitmap, new Point(0, drawingPosition));
            }
            


            //change the playerpicture box.
            /*
            foreach (var a_single_card in playerHand.Cards)
            {
                //add multiple picture in box.
            }
            */

        }

        private void playerPicturebox_Click(object sender, EventArgs e)
        {

        }

        private void standBttn_Click(object sender, EventArgs e)
        {
            


            if (gameModeComboBox.SelectedItem.ToString() == "H17")
            {
                //dealer hits until its == 21 if > then lose:
                while (computerSum != 21)
                {
                    //break the loops
                    if (computerSum > 21)
                    {
                        dealer_status_label.Text = computerSum.ToString();
                        win_loseLabel.Text = win;

                        //is this break of the loop though
                        break;
                    }

                    aCard aSingleCard;
                    aSingleCard = dealingShoe.Draw();
                    computerHand.Cards.Add(aSingleCard);
                    computerHand.AddValue(aSingleCard, ref computerSum);
                }

                dealer_status_label.Text = computerSum.ToString();
                updatePicturebox(ref computerPicturebox, ref computerHand);

            }
            else
            {
                while (computerSum != 21)
                {
                    //break the loops
                    if (computerSum > 21)
                    {
                        dealer_status_label.Text = computerSum.ToString();
                        win_loseLabel.Text = win;

                        //is this break of the loop though
                        break;
                    }

                    aCard aSingleCard;
                    aSingleCard = dealingShoe.Draw();
                    computerHand.Cards.Add(aSingleCard);
                    computerHand.AddValue(aSingleCard, ref computerSum);
                }

                dealer_status_label.Text = computerSum.ToString();

                //then this update but missing why 2 and 7 got to that number though.
                updatePicturebox(ref computerPicturebox,ref computerHand);
            }
        }

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
        }

        private void computerPicturebox_Click(object sender, EventArgs e)
        {

        }
    }
}
