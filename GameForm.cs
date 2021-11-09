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
        private enum OUTCOME {Tie = 0, Win = 1, Lose = 2}
        //imageList 
        PictureBox[] dealerImages;
        PictureBox[] playerImages;

        
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
        bool playButtonHit = false, gameOver = false; 
        //also got a deck of card one though lol.
        aDeckOfCards deck;
        aShoe shoe;
        int mode = 17;
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

        double ratio = 1.5;

        /// <summary>
        /// form1 constructor
        /// </summary>
        public GameForm()
        {
            InitializeComponent();
            rand = new Random(999);
            dealingShoe = new aShoe(new Random());
            dealerImages = new PictureBox[] { dealerPictureBox1, dealerPictureBox2, dealerPictureBox3, dealerPictureBox4, dealerPictureBox5,
                dealerPictureBox6, dealerPictureBox7, dealerPictureBox8, dealerPictureBox9, dealerPictureBox10, dealerPictureBox11, dealerPictureBox12};
            playerImages = new PictureBox[] { playerPicturebox1, playerPicturebox2, playerPicturebox3, playerPicturebox4, playerPicturebox5,
                playerPicturebox6, playerPicturebox7, playerPicturebox8, playerPicturebox9, playerPicturebox10, playerPicturebox11, playerPicturebox12};

            totalTextBox.Text = "100";
        }

        public GameForm( int NumDecks, bool mode, int seed)
        {
            InitializeComponent();
            totalTextBox.Text = "100";
            dealerImages = new PictureBox[] { dealerPictureBox1, dealerPictureBox2, dealerPictureBox3, dealerPictureBox4, dealerPictureBox5,
                dealerPictureBox6, dealerPictureBox7, dealerPictureBox8, dealerPictureBox9, dealerPictureBox10, dealerPictureBox11, dealerPictureBox12};
            playerImages = new PictureBox[] { playerPicturebox1, playerPicturebox2, playerPicturebox3, playerPicturebox4, playerPicturebox5,
                playerPicturebox6, playerPicturebox7, playerPicturebox8, playerPicturebox9, playerPicturebox10, playerPicturebox11, playerPicturebox12};

            //seedTextbox.Text = seed.ToString();
            if (mode == true)
            {
                s17Mode = mode;
                this.mode = 17;
            }
            else
            {
                h17Mode = mode;
                this.mode = 18;
            }
            //disable Hit and Stand button
            buttonStatus(false);

            visibleButton(false);
            dealingShoe = seed == -1 ? new aShoe(new Random(), NumDecks) : new aShoe(new Random(seed), NumDecks);
            /*playerPictureboxList = new List<Image>();
            dealerPictureboxList = new List<Image>();*/
            //initList();
            //drawCard(false, 2); //draw two cards for player
            //drawCard(true, 1);  //draw 1 card for dealer
            //updateDealer();
            //updatePlayer();
            
            
        }
        private void drawCard(bool isDealer, int numCardsDrawn)
        {
            aCard temp;
            for (int i = 0; i < numCardsDrawn; i++)
            {
                temp = dealingShoe.Draw();
                if (isDealer)
                {
                    if(dealerSum < 11 && temp.getValue() == 1) //if card is ace, increment by ten if sum is greater than 10 already
                    {
                        dealerSum += 11;
                    }
                    else
                    {
                        dealerSum += temp.getValue();
                    }
                    //dealer[dealerImageNum] = temp;
                    dealer.Add(temp);
                    dealerImages[dealerImageNum].Image = dealer[dealerImageNum].getImage();
                    //updateDealer(dealerImageNum + 1);
                    dealerImageNum++;
                }
                else
                {
                    if(playerSum < 11 && temp.getValue() == 1)
                    {
                        playerSum += 11;
                    }
                    else
                    {
                        playerSum += temp.getValue();
                    }
                    //player[playerImageNum] = temp;
                    player.Add(temp);
                    playerImages[playerImageNum].Image = player[playerImageNum].getImage();
                    //updatePlayer(playerImageNum + 1);
                    playerImageNum++;
                }
            }
            dealerValueRichTextBox.Text = dealerSum.ToString();
            playerValueRichTextBox.Text = playerSum.ToString();
        }
        /// <summary>
        /// function calls when form1 loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Form1_Load(object sender, EventArgs e)
        {
            //set starting credit to 100:
            
         
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

        private void playButton_Click(object sender, EventArgs e)
        {

            if (playButtonHit)
            {
                MessageBox.Show("Cannot hit play button if game not Reset!!\nReset will reset the cards", "Error");
                return;
            }

            double parsedValue = 0.0;
            if (!double.TryParse(betTextBox.Text, out parsedValue))
            {
                MessageBox.Show("This is a number only field", "Error");
                return;

            }
            
            //check the user bet
            if (String.IsNullOrEmpty(betTextBox.Text))
            {
                MessageBox.Show("You have to bet before playing!", "Error");
                return;
            }

            //if the user money less than total money, print error message
            if(double.Parse(betTextBox.Text) > double.Parse(totalTextBox.Text))
            {
                MessageBox.Show("Out of money! Please contact customer service to make a loan :3", "Warning");
                return;
            }
            //if the user type invalid value
            if (double.Parse(betTextBox.Text) <= 0)
            {
                MessageBox.Show("Invalid Money", "Warning");
                return;
            }

            playButtonHit = true;
            numTimesPlayed++;
            //we have to reset the game
            //if(numTimesPlayed > 1)
            //    resetCards();

            drawCard(false, 2); //draw two cards for player
            drawCard(true, 1);  //draw 1 card for dealer

            //check the cards if blackjack
            if (isBlackJack(player))
            {
                MessageBox.Show("Congratulations! BLACK JACK!", "YOU WIN!");
                winOrLoseRichTextBox.Text = win;
                calcBet();
                return;
            }

            //enable Hit and Stand button
            buttonStatus(true);
            betTextBox.ReadOnly = true;
            visibleButton(true);
        }

        /// <summary>
        /// function to calculate the player's money
        /// </summary>
        private void calcBet(){ 
            if (winOrLoseRichTextBox.Text == lose)
            {
                //player bust
                totalTextBox.Text = (double.Parse(totalTextBox.Text) - double.Parse(betTextBox.Text)).ToString();
            }
            else if(winOrLoseRichTextBox.Text == win)
            {
                //player win
                totalTextBox.Text = (double.Parse(totalTextBox.Text) + (double.Parse(betTextBox.Text) * ratio)).ToString();
            }
        }

        /// <summary>
        /// function the reset the cards of dealder and player
        /// </summary>
        private void resetCards()
        {
            //reset the picture boxes
            foreach (PictureBox picture in dealerImages)
            {
                picture.Image = null;
            }
            foreach (PictureBox picture in playerImages)
            {
                picture.Image = null;
            }

            //clear cards of player and set sum = 0 again
            dealer.Clear();
            dealerSum = 0;
            dealerAce = 0;
            //clear the rich text box
            dealerValueRichTextBox.Text = string.Empty;                                    

            //clear cards of player and set sum = 0 again
            player.Clear();
            playerSum = 0;
            playerAce = 0;
            //clear the rich text box
            playerValueRichTextBox.Text = string.Empty;
            
            playerImageNum = 0;
            dealerImageNum = 0;

            dealingShoe.reset();
            buttonStatus(false);
            betTextBox.ReadOnly = false;

            visibleButton(false);
        }

        /// <summary>
        /// when user click the reset button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {

            //clear bet money box
            betTextBox.Text = string.Empty;
            resetCards();
            playButtonHit = false;
            


        }
        /// <summary>
        /// function got called after click the hit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void hitButton_Click(object sender, EventArgs e)
        {
            if (!playButtonHit)
            {
                MessageBox.Show("Cannot hit, must click play first", "Error!");
                return;
            }
            if(playerSum >= 21)//check the s17 mode
            {
                MessageBox.Show("Cannot hit, must stand");
                standButton_Click(null, EventArgs.Empty);
                return;
            }

            drawCard(false, 1);///player draw card

            //player Bust
            if (playerSum > 21)
            {
                MessageBox.Show("YOU BUST", "Oops");
                winOrLoseRichTextBox.Text = lose;
                calcBet();
                buttonStatus(false);
            }
        }


        private void standButton_Click(object sender, EventArgs e)
        {
            if (!playButtonHit)
            {
                MessageBox.Show("Cannot stand, must click play first", "Error!");
                return;
            }
            if (playerSum > 21)
            {
                winOrLoseRichTextBox.Text = lose;
            }
            while(dealerSum < mode)
            {
                drawCard(true, 1);
            }
            if(playerSum <= 21)
            {
                if(dealerSum > 21)
                {
                    winOrLoseRichTextBox.Text = win; ///if dealer greater than 21, player wins
                }
                else
                {
                    if (isBlackJack(dealer))
                    {
                        winOrLoseRichTextBox.Text = lose;
                    }

                    if (dealerSum == 21 && playerSum == 21)
                    {
                        winOrLoseRichTextBox.Text = "It's tie"; //if player and dealer bust, dealer wins
                    }
                    else if (dealerSum == playerSum)
                    {//if neither bust and are equal, then it's a tie
                        winOrLoseRichTextBox.Text = "It's tie";
                    }
                    //if neither bust and player less, dealer wins
                    else if (dealerSum > playerSum)
                    {
                        winOrLoseRichTextBox.Text = lose;
                        
                    }
                    //if neither bust and player greater, player wins
                    else
                    {
                        winOrLoseRichTextBox.Text = win;
                    }
                }
                
            }
            calcBet();
            //disable button
            buttonStatus(false);

        }

        private void visibleButton(bool status)
        {
            //set whether visibility
            dealerValueLabel.Visible = status;
            playerValueLabel.Visible = status;
            dealerValueRichTextBox.Visible = status;
            playerValueRichTextBox.Visible = status;
            winOrLoseLabel.Visible = status;
            winOrLoseRichTextBox.Visible = status;
        }

        private void buttonStatus(bool status)
        {
            if (status)
            {
                hitButton.Enabled= true;
                standButton.Enabled = true;
            }
            else
            {
                hitButton.Enabled = false;
                standButton.Enabled = false;
            }
        }

        private bool isBlackJack(List<aCard> cards)
        {
            return ((cards[0].getValue() + cards[1].getValue()) == 21);
                  
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
