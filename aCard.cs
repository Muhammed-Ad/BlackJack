﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Drawing;

namespace Project2
{
   
    public enum CardValue
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }

    public enum CardSuit
    {
        Hearts = 1,
        Spades = 2,
        Clubs = 3,
        Diamonds = 4
    }


    /// <summary>
    /// a card contains value, face and picture? 
    /// </summary>
    class aCard
    {
        /// <summary>
        /// card value
        /// </summary>
        /// this is an enum
        CardValue cardValue;

        /// <summary>
        /// face 
        /// </summary>
        CardSuit suit;


        /// <summary>
        /// the image
        /// </summary>
        Image image;

        public Image Image
        {
            get
            {
                return this.image;
            }
        }

        public CardValue Value
        {
            get
            {
                return this.cardValue;
            }
            set
            {
                this.cardValue = value;
                GetImage();
            }
        }

        public CardSuit Suit
        {
            get
            {
                return this.suit;
            }
            set
            {
                this.suit = value;
                GetImage();
            }
        }

        public aCard()
        {
            cardValue = 0;
            suit = 0;
            image = null;
        }
        


        public void GetImage()
        {

            if (this.Suit != 0 && this.Value != 0)//so it must be a valid card (see the Enums)
            {
                int x = 0;//starting point from the left
                int y = 0;//starting point from the top. Can be 0, 98, 196 and 294
                int height = 97;
                int width = 73;

                switch (this.Suit)
                {
                    case CardSuit.Hearts:
                        y = 196;
                        break;
                    case CardSuit.Spades:
                        y = 98;
                        break;
                    case CardSuit.Clubs:
                        y = 0;
                        break;
                    case CardSuit.Diamonds:
                        y = 294;
                        break; 
                }
                
                x = width * ((int)this.Value - 1);//the Ace has the value of 1 (see the Enum), so the X coordinate will be the starting (first one), that's why we have to subtract 1. The card 6 has the total width of the first 6 cards (6*73=438) minus the total width of the first 5 cards (5*73=365). Of course it is 73. The starting X coordinate is at the end of the 5th card (or the start of the left side of the 6th card). Hope you understand. :)

                Bitmap  source = Properties.Resources.cards;//the original cards.png image
                Bitmap img = new Bitmap(width, height);//this will be the created one for each card
                Graphics g = Graphics.FromImage(img);
                g.DrawImage(source, new Rectangle(0, 0, width, height), new Rectangle(x, y, width, height), GraphicsUnit.Pixel);//here we slice the original into pieces
                g.Dispose();
                this.image = img;

                
                
               
            }
        }

        public Bitmap GetBitmapImage()
        {
            Bitmap bitmapImg = new Bitmap(97,73);
            

            if (this.Suit != 0 && this.Value != 0)//so it must be a valid card (see the Enums)
            {
                int x = 0;//starting point from the left
                int y = 0;//starting point from the top. Can be 0, 98, 196 and 294
                int height = 97;
                int width = 73;

                switch (this.Suit)
                {
                    case CardSuit.Hearts:
                        y = 196;
                        break;
                    case CardSuit.Spades:
                        y = 98;
                        break;
                    case CardSuit.Clubs:
                        y = 0;
                        break;
                    case CardSuit.Diamonds:
                        y = 294;
                        break;
                }

                x = width * ((int)this.Value - 1);//the Ace has the value of 1 (see the Enum), so the X coordinate will be the starting (first one), that's why we have to subtract 1. The card 6 has the total width of the first 6 cards (6*73=438) minus the total width of the first 5 cards (5*73=365). Of course it is 73. The starting X coordinate is at the end of the 5th card (or the start of the left side of the 6th card). Hope you understand. :)

                Bitmap source = Properties.Resources.cards;//the original cards.png image
                Bitmap img = new Bitmap(width, height);//this will be the created one for each card
                Graphics g = Graphics.FromImage(img);
                g.DrawImage(source, new Rectangle(0, 0, width, height), new Rectangle(x, y, width, height), GraphicsUnit.Pixel);//here we slice the original into pieces
                g.Dispose();
                this.image = img;



                return img;
            }

            return bitmapImg;


        }

        /*

        public aCard drawCard(Hand hand)
        {
            aCard drawn = cards[cards.Count - 1];
            cards.Remove(drawn);
            hands.Cards.Add(drawn);
            return dranw;
        }
        */







    }

    
}
