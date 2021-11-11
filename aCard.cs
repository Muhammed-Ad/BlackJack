using System.Drawing;


namespace Project2
{
   /// <summary>
   /// enumerator card Value Type
   /// </summary>
    public enum CardValue: int
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
        King = 13,
    }

    /// <summary>
    /// enumerator of card suits
    /// </summary>
    public enum CardSuit
    {
        Spades = 1,
        Clubs = 2,
        Diamonds = 3,
        Hearts = 4,
    }


    /// <summary>
    /// Class aCard contains value, face and picture? 
    /// </summary>
    public class aCard
    {
        /// <summary>
        /// card value
        /// </summary>
        /// this is an enum
        private CardValue cardValue;

        /// <summary>
        /// face 
        /// </summary>
        private CardSuit suit;


        /// <summary>
        /// the image
        /// </summary>
        private Image image;

        /// <summary>
        /// constructor with 3 parameter
        /// </summary>
        /// <param name="value">card value</param>
        /// <param name="suit">card suit</param>
        /// <param name="image">the images</param>
        public aCard(CardValue value, CardSuit suit, System.Drawing.Image image)
        {
            this.cardValue = value;
            this.suit = suit;
            this.image = image;
        }

        /// <summary>
        /// method to get the image
        /// </summary>
        /// <returns></returns>
        public Image getImage()
        {
            return this.image;
        }

        /// <summary>
        /// method to get value of the card
        /// </summary>
        /// <returns>return integer number of card corresponding</returns>
        public int getValue()
        {
            if (this.cardValue == CardValue.Ace)
                return 11;
            else if (this.cardValue == CardValue.Two)
                return 2;
            else if (this.cardValue == CardValue.Three)
                return 3;
            else if (this.cardValue == CardValue.Four)
                return 4;
            else if (this.cardValue == CardValue.Five)
                return 5;
            else if (this.cardValue == CardValue.Six)
                return 6;
            else if (this.cardValue == CardValue.Seven)
                return 7;
            else if (this.cardValue == CardValue.Eight)
                return 8;
            else if (this.cardValue == CardValue.Nine)
                return 9;
            else if (this.cardValue == CardValue.Ten || this.cardValue == CardValue.Jack ||
                this.cardValue == CardValue.Queen || this.cardValue == CardValue.King)
                return 10;
            else
                return 0;
        }

    }
    
}
