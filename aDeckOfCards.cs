using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Drawing;

namespace Project2
{
    /// <summary>
    /// contain up to 8 decks of card 
    /// </summary>
    public class aDeckOfCards// : IDrawCard
    {

        /// <summary>
        /// deck array list
        /// readonly to create a constant as runtime
        /// </summary>
        private readonly List<aCard> deck = new List<aCard>();

        int cardCount = 52;
        public int Count
        {
            get { return this.cardCount; }
        }
        /// <summary>
        /// default constructor
        /// </summary>
        public aDeckOfCards()
        {
            for (int i = 1; i < 53; ++i)
            {
                CardValue value = aCard.calculateValue(i % 13);
                CardSuit suit = aCard.calculateSuit(i % 4);

                deck.Add(new aCard(value, suit, cardImage(value + " " + suit)));
            }
        }

        public aCard drawCard(int index)
        {
            return deck[index];
        }

        public void removeCard(int index)
        {
            deck.RemoveAt(index);
        }

        public bool isEmpty()
        {
            return this.cardCount == 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private Image cardImage(string type)
        {
            switch (type)
            {
                case "Ace Spades":
                    return Properties.Resources.AS;
                case "Ace Clubs":
                    return Properties.Resources.AC;
                case "Ace Diamonds":
                    return Properties.Resources.AD;
                case "Ace Hearts":
                    return Properties.Resources.AH;
                case "Two Spades":
                    return Properties.Resources._2S;
                case "Two Clubs":
                    return Properties.Resources._2C;
                case "Two Diamonds":
                    return Properties.Resources._2D;
                case "Two Hearts":
                    return Properties.Resources._2H;
                case "Three Spades":
                    return Properties.Resources._3S;
                case "Three Clubs":
                    return Properties.Resources._3C;
                case "Three Diamonds":
                    return Properties.Resources._3D;
                case "Three Hearts":
                    return Properties.Resources._3H;
                case "Four Spades":
                    return Properties.Resources._4S;
                case "Four Clubs":
                    return Properties.Resources._4C;
                case "Four Diamonds":
                    return Properties.Resources._4D;
                case "Four Hearts":
                    return Properties.Resources._4H;
                case "Five Spades":
                    return Properties.Resources._5S;
                case "Five Clubs":
                    return Properties.Resources._5C;
                case "Five Diamonds":
                    return Properties.Resources._5D;
                case "Five Hearts":
                    return Properties.Resources._5H;
                case "Six Spades":
                    return Properties.Resources._6S;
                case "Six Clubs":
                    return Properties.Resources._6C;
                case "Six Diamonds":
                    return Properties.Resources._6D;
                case "Six Hearts":
                    return Properties.Resources._6H;
                case "Seven Spades":
                    return Properties.Resources._7S;
                case "Seven Clubs":
                    return Properties.Resources._7C;
                case "Seven Diamonds":
                    return Properties.Resources._7D;
                case "Seven Hearts":
                    return Properties.Resources._7H;
                case "Eight Spades":
                    return Properties.Resources._8S;
                case "Eight Clubs":
                    return Properties.Resources._8C;
                case "Eight Diamonds":
                    return Properties.Resources._8D;
                case "Eight Hearts":
                    return Properties.Resources._8H;
                case "Nine Spades":
                    return Properties.Resources._9S;
                case "Nine Clubs":
                    return Properties.Resources._9C;
                case "Nine Diamonds":
                    return Properties.Resources._9D;
                case "Nine Hearts":
                    return Properties.Resources._9H;
                case "Ten Spades":
                    return Properties.Resources._10S;
                case "Ten Clubs":
                    return Properties.Resources._10C;
                case "Ten Diamonds":
                    return Properties.Resources._10D;
                case "Ten Hearts":
                    return Properties.Resources._10H;
                case "Jack Spades":
                    return Properties.Resources.JS;
                case "Jack Clubs":
                    return Properties.Resources.JC;
                case "Jack Diamonds":
                    return Properties.Resources.JD;
                case "Jack Hearts":
                    return Properties.Resources.JH;
                case "Queen Spades":
                    return Properties.Resources.QS;
                case "Queen Clubs":
                    return Properties.Resources.QC;
                case "Queen Diamonds":
                    return Properties.Resources.QD;
                case "Queen Hearts":
                    return Properties.Resources.QH;
                case "King Spades":
                    return Properties.Resources.KS;
                case "King Clubs":
                    return Properties.Resources.KC;
                case "King Diamonds":
                    return Properties.Resources.KD;
                case "King Hearts":
                    return Properties.Resources.KH;
                default:
                    return Properties.Resources.back_cards_07;

            }
        }

        /*public aCard Draw()
        {
            Random rand = new Random();
            int value = rand.Next(0, deck.Count);
            aCard drawCard = deck[value];

            deck.RemoveAt(value);

            return drawCard;

        }*/
    }
}

