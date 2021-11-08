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
        List<aCard> dealer = new List<aCard>();
        List<aCard> player = new List<aCard>();

        //imageList 
        List<Image> playerPictureboxList;
        List<Image> dealerPictureboxList;

        Image defaultImage = Properties.Resources.gray_back;
        //PictureBox computerPicturebox;
        //PictureBox playerPicturebox;
        int startingHand = 2;
        Random rand; //random number gen. to start from once given seed
        //did not specify though
        int max_cards_on_table = 11;

        //number of decks
        int nDecks;
        bool s17Mode;  //playing mode
        bool h17Mode;
        //also got a deck of card one though lol.
        aDeckOfCards deck;
        aShoe shoe;

        //sum and ace
        int dealerSum = 0;
        int playerSum = 0;
        int dealerAce = 0;
        int playerAce = 0;

        int playerImageNum = 0, dealerImageNum = 0;
        aShoe dealingShoe;
        string win = "You Won";
        string lose = "You Lost";
        int numTimesPlayed = 0;
        

        /// <summary>
        /// form1 constructor
        /// </summary>
        public GameForm()
        {
            InitializeComponent();

            //create the new iamge list
            playerPictureboxList = new List<Image>();
            dealerPictureboxList = new List<Image>();
            initList();
            rand = new Random(999);
            dealingShoe = new aShoe();


        }

        public GameForm(int seed, int NumDecks, bool mode)
        {
            InitializeComponent();

            //seedTextbox.Text = seed.ToString();
            rand = new Random(seed);
            if (mode == true)
            {
                s17Mode = mode;
            }
            else             
                h17Mode = mode;
            
            dealingShoe = new aShoe(NumDecks);
            /*playerPictureboxList = new List<Image>();
            dealerPictureboxList = new List<Image>();*/
            initList();
            //drawCard(false, 2); //draw two cards for player
            //drawCard(true, 1);  //draw 1 card for dealer
            //updateDealer();
            //updatePlayer();
            
            
        }
        private void initList()
        {
            for(int i = 0; i < 12; i++)
            {
                player.Add(new aCard(0, 0, defaultImage));
                dealer.Add(new aCard(0, 0, defaultImage));
            }
        }
        private void drawCard(bool isDealer, int numCardsDrawn)
        {
            aCard temp;
            for (int i = 0; i < numCardsDrawn; i++)
            {
                temp = dealingShoe.Draw();
                if (isDealer)
                {
                    
                    if(dealerSum > 10 && temp.getValue() == 1)
                    {
                        dealerSum += 10;
                    }
                    else
                    {
                        dealerSum += temp.getValue();
                    }
                    dealer[dealerImageNum] = temp;
                    updateDealer(dealerImageNum);
                    dealerImageNum++;
                }
                else
                {
                    playerSum += temp.getValue();
                    player[playerImageNum] = temp;
                    updatePlayer(playerImageNum);
                    playerImageNum++;
                }
            }
            dealerValueRichTextBox.Text = dealerSum.ToString();
            playerValueRichTextBox.Text = playerSum.ToString();
        }

        private void updateDealer(int numUpdated)
        {
            if (numUpdated > 12 || numUpdated < 1)
                return;

            switch (numUpdated)
            {
                case 12:
                    dealerPictureBox12.Image = dealer[11].getImage();
                    break;
                case 11:
                    dealerPictureBox11.Image = dealer[10].getImage();
                    break;
                case 10:
                    dealerPictureBox10.Image = dealer[9].getImage();
                    break;
                case 9:
                    dealerPictureBox9.Image = dealer[8].getImage();
                    break;
                case 8:
                    dealerPictureBox8.Image = dealer[7].getImage();
                    break;
                case 7:
                    dealerPictureBox7.Image = dealer[6].getImage();
                    break;
                case 6:
                    dealerPictureBox6.Image = dealer[5].getImage();
                    break;
                case 5:
                    dealerPictureBox5.Image = dealer[4].getImage();
                    break;
                case 4:
                    dealerPictureBox4.Image = dealer[3].getImage();
                    break;
                case 3:
                    dealerPictureBox3.Image = dealer[2].getImage();
                    break;
                case 2:
                    dealerPictureBox2.Image = dealer[1].getImage();
                    break;
                case 1:
                    dealerPictureBox1.Image = dealer[0].getImage();
                    break;
            }
        }

        private void updatePlayer(int numUpdated)
        {
            if (numUpdated > 12 || numUpdated < 1)
                return;

            switch (numUpdated)
            {
                case 12:
                    playerPicturebox12.Image = player[11].getImage();
                    break;
                case 11:
                    playerPicturebox11.Image = player[10].getImage();
                    break;
                case 10:
                    playerPicturebox10.Image = player[9].getImage();
                    break;
                case 9:
                    playerPicturebox9.Image = player[8].getImage();
                    break;
                case 8:
                    playerPicturebox8.Image = player[7].getImage();
                    break;
                case 7:
                    playerPicturebox7.Image = player[6].getImage();
                    break;
                case 6:
                    playerPicturebox6.Image = player[5].getImage();
                    break;
                case 5:
                    playerPicturebox5.Image = player[4].getImage();
                    break;
                case 4:
                    playerPicturebox4.Image = player[3].getImage();
                    break;
                case 3:
                    playerPicturebox3.Image = player[2].getImage();
                    break;
                case 2:
                    playerPicturebox2.Image = player[1].getImage();
                    break;
                case 1:
                    playerPicturebox1.Image = player[0].getImage();
                    break;
            }
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
            
            //check the user bet
            if (String.IsNullOrEmpty(betTextBox.Text))
            {
                MessageBox.Show("You have to bet before playing!", "Error");
                return;
            }

            //if the user money less than total money, print error message
            if(int.Parse(betTextBox.Text) > int.Parse(totalTextBox.Text))
            {
                MessageBox.Show("Out of money! Please contact customer service to make a loan :3", "Warning");
                return;
            }
            numTimesPlayed++;
            //we have to reset the game
            if(numTimesPlayed > 1)
                resetCards();

            /*shoe = new aShoe();

            //draw and display a card for the dealer
            //bool isDealer = true;
            //drawCards(ref dealer, isDealer);

            //draw a card for dealer
            aCard dealerCard = shoe.Draw();
            dealerPictureBox1.Image = dealerCard.getImage();
            //calculate and display dealer's value
            dealerSum = dealerCard.getValue();
            dealerValueRichTextBox.Text = dealerSum.ToString();

            //draw 2 cards for player
            aCard playerCard1 = shoe.Draw();
            aCard playerCard2 = shoe.Draw();
            playerPicturebox1.Image = playerCard1.getImage();
            playerPicturebox2.Image = playerCard2.getImage();

            //calculate and display player's value
            playerSum = playerCard1.getValue() + playerCard2.getValue();
            playerValueRichTextBox.Text = playerSum.ToString();*/

            drawCard(false, 2); //draw two cards for player
            drawCard(true, 1);  //draw 1 card for dealer
            

        }

        private void drawCards(ref List<aCard> info, bool isDealer)
        {
            aCard card = shoe.Draw();

            //for dealer
            if (isDealer)
            {
                //if a card is Ace
                if(card.getValue() == 11)
                {
                    ++dealerAce;
                }
                dealerSum += card.getValue();

                //if a card is Ace but the total > 21, Ace should be 1
                if(dealerAce > 0 && dealerSum > 21)
                {
                    --dealerAce;
                    //11 - 10 = 1
                    dealerSum -= 10;
                }
            }
            //for player
            else
            {
                //if a card is Ace
                if (card.getValue() == 11)
                {
                    ++playerAce;
                }
                playerSum += card.getValue();

                //if a card is Ace but the total > 21, Ace should be 1
                if (playerAce > 0 && playerSum > 21)
                {
                    --playerAce;
                    //11 - 10 = 1
                    playerSum -= 10;
                }
            }
            

        }

        /// <summary>
        /// function the reset the cards of dealder and player
        /// </summary>
        private void resetCards()
        {
            
            //For dealer
            foreach(aCard cardDealer in dealer)
            {
                Controls.Remove(cardDealer.cardDisplay);
                //dispose card Display
                cardDealer.cardDisplay.Dispose();
            }
            //clear cards of player and set sum = 0 again
            dealer.Clear();
            dealerSum = 0;
            dealerAce = 0;
            //clear the rich text box
            dealerValueRichTextBox.Text = string.Empty;
            

            //For player
            foreach (aCard cardPlayer in player)
            {
                Controls.Remove(cardPlayer.cardDisplay);
                //dispose card Display
                cardPlayer.cardDisplay.Dispose();
            }

            //clear cards of player and set sum = 0 again
            player.Clear();
            playerSum = 0;
            playerAce = 0;
            //clear the rich text box
            playerValueRichTextBox.Text = string.Empty;
            
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //resetCards();
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
                MessageBox.Show("Cannot hit, must stand");
                standButton_Click(null, EventArgs.Empty);
                return;
            }

            drawCard(false, 1);///player draw card
        }


        private void standButton_Click(object sender, EventArgs e)
        {
           while(dealerSum < 17 && s17Mode)
            {
                drawCard(true, 1);
            }
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
