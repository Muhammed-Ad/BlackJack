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
            createDeck();
        }
        private void createDeck()
        {
            /*for (int i = 0; i < 52; ++i)
            {
                CardValue value = aCard.calculateValue((i % 13) + 1);
                CardSuit suit = aCard.calculateSuit((i % 4) + 1);

                deck.Add(new aCard(value, suit, cardImage(value + " of " + suit)));
                System.Console.WriteLine(value);
            }*/
            foreach(CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach(CardValue value in Enum.GetValues(typeof(CardValue)))
                {
                    deck.Add(new aCard(value, suit, cardImage(value + " of " + suit)));
                    System.Console.Write(value);
                    System.Console.Write(" of ");
                    System.Console.WriteLine(suit);

                }
            }
            cardCount = 52;
        }
        public aCard drawCard(int index)
        {
            if (index > deck.Count())
            {
                System.Windows.Forms.MessageBox.Show("Card index out of bounds, please exit.");
                return null;
            }
                
           
            return deck[index];
            
        }

        public void removeCard(int index)
        {
            deck.RemoveAt(index);
            cardCount--;
        }

        public bool isEmpty()
        {
            return this.cardCount == 0;
        }
        public void reset()
        {
            deck.Clear();
            createDeck();
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
                case "Ace of Spades":
                    return Properties.Resources.AS;
                case "Ace of Clubs":
                    return Properties.Resources.AC;
                case "Ace of Diamonds":
                    return Properties.Resources.AD;
                case "Ace of Hearts":
                    return Properties.Resources.AH;
                case "Two of Spades":
                    return Properties.Resources._2S;
                case "Two of Clubs":
                    return Properties.Resources._2C;
                case "Two of Diamonds":
                    return Properties.Resources._2D;
                case "Two of Hearts":
                    return Properties.Resources._2H;
                case "Three of Spades":
                    return Properties.Resources._3S;
                case "Three of Clubs":
                    return Properties.Resources._3C;
                case "Three of Diamonds":
                    return Properties.Resources._3D;
                case "Three of Hearts":
                    return Properties.Resources._3H;
                case "Four of Spades":
                    return Properties.Resources._4S;
                case "Four of Clubs":
                    return Properties.Resources._4C;
                case "Four of Diamonds":
                    return Properties.Resources._4D;
                case "Four of Hearts":
                    return Properties.Resources._4H;
                case "Five of Spades":
                    return Properties.Resources._5S;
                case "Five of Clubs":
                    return Properties.Resources._5C;
                case "Five of Diamonds":
                    return Properties.Resources._5D;
                case "Five of Hearts":
                    return Properties.Resources._5H;
                case "Six of Spades":
                    return Properties.Resources._6S;
                case "Six of Clubs":
                    return Properties.Resources._6C;
                case "Six of Diamonds":
                    return Properties.Resources._6D;
                case "Six of Hearts":
                    return Properties.Resources._6H;
                case "Seven of Spades":
                    return Properties.Resources._7S;
                case "Seven of Clubs":
                    return Properties.Resources._7C;
                case "Seven of Diamonds":
                    return Properties.Resources._7D;
                case "Seven of Hearts":
                    return Properties.Resources._7H;
                case "Eight of Spades":
                    return Properties.Resources._8S;
                case "Eight of Clubs":
                    return Properties.Resources._8C;
                case "Eight of Diamonds":
                    return Properties.Resources._8D;
                case "Eight of Hearts":
                    return Properties.Resources._8H;
                case "Nine of Spades":
                    return Properties.Resources._9S;
                case "Nine of Clubs":
                    return Properties.Resources._9C;
                case "Nine of Diamonds":
                    return Properties.Resources._9D;
                case "Nine of Hearts":
                    return Properties.Resources._9H;
                case "Ten of Spades":
                    return Properties.Resources._10S;
                case "Ten of Clubs":
                    return Properties.Resources._10C;
                case "Ten of Diamonds":
                    return Properties.Resources._10D;
                case "Ten of Hearts":
                    return Properties.Resources._10H;
                case "Jack of Spades":
                    return Properties.Resources.JS;
                case "Jack of Clubs":
                    return Properties.Resources.JC;
                case "Jack of Diamonds":
                    return Properties.Resources.JD;
                case "Jack of Hearts":
                    return Properties.Resources.JH;
                case "Queen of Spades":
                    return Properties.Resources.QS;
                case "Queen of Clubs":
                    return Properties.Resources.QC;
                case "Queen of Diamonds":
                    return Properties.Resources.QD;
                case "Queen of Hearts":
                    return Properties.Resources.QH;
                case "King of Spades":
                    return Properties.Resources.KS;
                case "King of Clubs":
                    return Properties.Resources.KC;
                case "King of Diamonds":
                    return Properties.Resources.KD;
                case "King of Hearts":
                    return Properties.Resources.KH;
                default:
                    return Properties.Resources.back_cards_07;

            }
        }
    }
}

