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
        string s17Mode = "";  //playing mode
        string h17Mode = "";
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

        public GameForm(int seed, int NumDecks, string mode)
        {
            InitializeComponent();

            //seedTextbox.Text = seed.ToString();
            rand = new Random(seed);
            if (mode == "S17")
            {
                s17Mode = mode;
            }
            else
                h17Mode = mode;
            
            dealingShoe = new aShoe(NumDecks);
            playerPictureboxList = new List<Image>();
            dealerPictureboxList = new List<Image>();
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
                playerPictureboxList.Add(default);
                dealerPictureboxList.Add(default);
            }
        }
        private void drawCard(bool dealer, int numCardsDrawn)
        {
            aCard temp;
            for (int i = 0; i < numCardsDrawn; i++)
            {
                if (dealer)
                {
                    temp = dealingShoe.Draw();
                    if(dealerSum > 10 && temp.getValue() == 1)
                    {
                        dealerSum += 10;
                    }
                    else
                    {
                        dealerSum += temp.getValue();
                    }
                    dealerPictureboxList[dealerImageNum++] = dealingShoe.Draw().getImage();
                }
                else
                {
            
                    temp = dealingShoe.Draw();
                    playerSum += temp.getValue();
                    playerPictureboxList[dealerImageNum++] = dealingShoe.Draw().getImage();
                }
            }
            
        }

        private void updateDealer()
        {
            dealerPictureBox1.Image = dealerPictureboxList[0];
            dealerPictureBox2.Image = dealerPictureboxList[1];
            dealerPictureBox3.Image = dealerPictureboxList[2];
            dealerPictureBox4.Image = dealerPictureboxList[3];
            dealerPictureBox5.Image = dealerPictureboxList[4];
            dealerPictureBox6.Image = dealerPictureboxList[5];

            dealerPictureBox7.Image = dealerPictureboxList[6];
            dealerPictureBox8.Image = dealerPictureboxList[7];
            dealerPictureBox9.Image = dealerPictureboxList[8];
            dealerPictureBox10.Image = dealerPictureboxList[9];
            dealerPictureBox11.Image = dealerPictureboxList[10];
            dealerPictureBox12.Image = dealerPictureboxList[11];

            //dealerPictureBox7.Visible = true;
        }

        private void updatePlayer()
        {
            playerPicturebox1.Image = dealerPictureboxList[0];
            playerPicturebox2.Image = dealerPictureboxList[1];
            playerPicturebox3.Image = dealerPictureboxList[2];
            playerPicturebox4.Image = dealerPictureboxList[3];
            playerPicturebox5.Image = dealerPictureboxList[4];
            playerPicturebox6.Image = dealerPictureboxList[5];

            playerPicturebox7.Image = dealerPictureboxList[6];
            playerPicturebox8.Image = dealerPictureboxList[7];
            playerPicturebox9.Image = dealerPictureboxList[8];
            playerPicturebox10.Image = dealerPictureboxList[9];
            playerPicturebox11.Image = dealerPictureboxList[10];
            playerPicturebox12.Image = dealerPictureboxList[11];
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

            //we have to reset the game
            resetCards();

            shoe = new aShoe();

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
            playerValueRichTextBox.Text = playerSum.ToString();

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
            }

            drawCard(false, 1);
            updatePlayer();
        }


        private void standButton_Click(object sender, EventArgs e)
        {
           //while()
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
