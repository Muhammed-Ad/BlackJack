using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Project1;

namespace Project2
{
    
    /// <summary>
    /// Main form
    /// </summary>
    public partial class GameForm : Form
    {
        /// <summary>
        /// dealer and player object of aCard List
        /// </summary>
        List<aCard> dealer = new List<aCard>();
        List<aCard> player = new List<aCard>();
        
        /// <summary>
        /// images List
        /// </summary>
        PictureBox[] dealerImages;
        PictureBox[] playerImages;

        //aRandomVariable rand; //random number gen. to start from once given seed
        //did not specify though
               

        /// <summary>
        /// aShoe object
        /// </summary>
        aShoe dealingShoe;

        /// <summary>
        /// boolean varibles for mode and button
        /// </summary>
        bool s17Mode = false;  //playing mode
        bool h17Mode = false;
        bool playButtonHit = false;
        int mode = 17;

        /// <summary>
        /// variables for sumValue and number of Aces
        /// </summary>
        int dealerSum = 0;
        int playerSum = 0;
        int dealerAce = 0;
        int playerAce = 0;

        /// <summary>
        /// index of the images Lists
        /// </summary>
        int playerImageNum = 0, dealerImageNum = 0;

        /// <summary>
        /// status variable
        /// </summary>
        const string win = "You Win";
        const string lose = "You Lost";
        int numTimesPlayed = 0;

        /// <summary>
        /// ratio of player win 3:2
        /// </summary>
        double ratio = 1.5;

        /// <summary>
        /// form1 constructor
        /// </summary>
        public GameForm()
        {
            InitializeComponent();
            aRandomVariable.rand_number = new Random(999);
            
            dealingShoe = new aShoe(new Random());
            dealerImages = new PictureBox[] { dealerPictureBox1, dealerPictureBox2, dealerPictureBox3, dealerPictureBox4, dealerPictureBox5,
                dealerPictureBox6, dealerPictureBox7, dealerPictureBox8, dealerPictureBox9, dealerPictureBox10, dealerPictureBox11, dealerPictureBox12};
            playerImages = new PictureBox[] { playerPicturebox1, playerPicturebox2, playerPicturebox3, playerPicturebox4, playerPicturebox5,
                playerPicturebox6, playerPicturebox7, playerPicturebox8, playerPicturebox9, playerPicturebox10, playerPicturebox11, playerPicturebox12};

            totalTextBox.Text = "100";
        }

        /// <summary>
        /// GameForm constructor with 3 parameters
        /// </summary>
        /// <param name="NumDecks">the number of decks that user chose</param>
        /// <param name="mode">mode S17 or H17</param>
        /// <param name="seed">the seed number that user chose</param>
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

            if (seed == -1)
            {
                dealingShoe = new aShoe(aRandomVariable.rand_number, NumDecks);
            }
            else
            {
                aRandomVariable.rand_number = new Random(seed);
                dealingShoe = new aShoe(aRandomVariable.rand_number, NumDecks);
            }
            //dealingShoe = seed == -1 ? new aShoe(aRandomVariable.rand_number , NumDecks) : new aShoe(aRandomVariable.rand_number, NumDecks);
                       
            
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

        
        /// <summary>
        /// method taking the event when user click Hit Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButton_Click(object sender, EventArgs e)
        {

            if (playButtonHit)
            {
                MessageBox.Show("Cannot hit play button if game not Reset!!\nReset will reset the cards", "Error");
                return;
            }

            //check the user bet
            if (String.IsNullOrEmpty(betTextBox.Text))
            {
                MessageBox.Show("You have to bet before playing!", "Error");
                return;
            }

            double parsedValue = 0.0;
            if (!double.TryParse(betTextBox.Text, out parsedValue))
            {
                MessageBox.Show("This is a number only field", "Error");
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
                visibleButton(true);
                return;
            }

            //enable Hit and Stand button
            buttonStatus(true);
            betTextBox.ReadOnly = true;
            visibleButton(true);
        }
        
        /// <summary>
        /// when user click the reset button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {

            //clear bet money box
            //betTextBox.Text = string.Empty;
            //reset buttons and cards
            resetCards();
            playButtonHit = false;
            winOrLoseRichTextBox.Text = "Win or Lose or Tie status";


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

        /// <summary>
        /// method taking the event whenever user click Stand button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void standButton_Click(object sender, EventArgs e)
        {
            if (!playButtonHit)
            {
                MessageBox.Show("Cannot stand, must click play first", "Error!");
                return;
            }
            //if player value greater than 21 => bust
            if (playerSum > 21)
            {
                winOrLoseRichTextBox.Text = lose;
            }

            //draw card for dealer until reach the mode(S17 or H17)
            while(dealerSum < mode)
            {
                drawCard(true, 1);
            }
            //if player value is not bust
            if(playerSum <= 21)
            {
                ///if dealer greater than 21 (bust), player wins
                if (dealerSum > 21)
                {
                    winOrLoseRichTextBox.Text = win; 
                }
                else
                {
                    //if dealer is black jack, player not black jack => lose
                    if (isBlackJack(dealer))
                    {
                        winOrLoseRichTextBox.Text = lose;
                    }
                    //if neither bust and are equal, then it's a tie
                    if (dealerSum == playerSum)
                    {
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

        /// <summary>
        /// function to draw cards
        /// </summary>
        /// <param name="isDealer">boolean value to know if dealer or not</param>
        /// <param name="numCardsDrawn">number of cards want to draw</param>
        private void drawCard(bool isDealer, int numCardsDrawn)
        {
            aCard temp;
            for (int i = 0; i < numCardsDrawn; i++)
            {
                temp = dealingShoe.Draw();
                if (isDealer)
                {
                    /*if(dealerSum > 21 && temp.getValue() == 11) //if card is ace, increment by ten if sum is greater than 10 already
                    {
                        //dealerSum += 11;
                        
                        dealerSum -= 10;
                    }
                    else
                    {
                        dealerSum += temp.getValue();
                        
                    }*/
                    //work with Ace cards
                    checkAceValue(temp, ref dealerSum, ref dealerAce);

                    //dealer[dealerImageNum] = temp;
                    dealer.Add(temp);
                    dealerImages[dealerImageNum].Image = dealer[dealerImageNum].getImage();
                    //updateDealer(dealerImageNum + 1);
                    dealerImageNum++;
                }
                else
                {
                    /*if(playerSum > 21 && temp.getValue() == 11)
                    {
                        //playerSum += 11;
                        
                        playerSum -= 10;
                    }
                    else
                    {
                        playerSum += temp.getValue();
                        
                    }*/
                    //work with Ace cards
                    checkAceValue(temp, ref playerSum, ref playerAce);

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
        /// function to calculate the player's money
        /// </summary>
        private void calcBet()
        {
            if (winOrLoseRichTextBox.Text == lose)
            {
                //player bust
                totalTextBox.Text = (double.Parse(totalTextBox.Text) - double.Parse(betTextBox.Text)).ToString();
            }
            else if (winOrLoseRichTextBox.Text == win)
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
        /// the function to visible or invisible the Labels and Buttons
        /// </summary>
        /// <param name="status">boolean status</param>
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

        /// <summary>
        /// The function to enable or disable button
        /// </summary>
        /// <param name="status">boolean status</param>
        private void buttonStatus(bool status)
        {
            if (status)
            {
                hitButton.Enabled= true;
                standButton.Enabled = true;
                resetButton.Enabled = false;
            }
            else
            {
                hitButton.Enabled = false;
                standButton.Enabled = false;
                resetButton.Enabled = true;
            }
        }

        /// <summary>
        /// The function to check BlackJack case
        /// </summary>
        /// <param name="cards">object cards in aCard List</param>
        /// <returns>true if blackjack and false if not</returns>
        private bool isBlackJack(List<aCard> cards)
        {
            //cards[0] = "Ace";
           
            return ((cards[0].getValue() + cards[1].getValue()) == 21);
                  
        }

        /// <summary>
        /// The function to check whenever Ace card appears
        /// </summary>
        /// <param name="card">object of aCard class</param>
        /// <param name="cardSum">the sum of cards</param>
        /// <param name="aces">number of aces</param>
        private void checkAceValue(aCard card, ref int cardSum, ref int aces)
        {
            //If the card is Ace, increase number of aces
            if(card.getValue() == 11)
            {
                ++aces;
            }
            cardSum += card.getValue(); 

            //if the card value is greater then 21
            //Ace now become 1
            if(cardSum >= 22 && aces >= 1)
            {
                --aces;
                cardSum -= 10;
            }
        }
    }
}
