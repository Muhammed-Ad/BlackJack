using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Project2
{
    /// <summary>
    /// contain up to 8 decks of card 
    /// </summary>
    class aDeckOfCards
    {

        public List<aCard> cards;

        //this constructor is weird though:
        public aDeckOfCards( aDeckOfCards previous_aDeckOfCards)
        {
            Cards = previous_aDeckOfCards.Cards;
        }


        public List<aCard> Cards
        {
            get { return this.Cards; }
            set { this.cards = value; }
        }

        //this is the constructor
        public aDeckOfCards()
        {
            //this is the empty deck of card
            Cards = new List<aCard>();


            ShuffleNewDeck();
        }


        /// <summary>
        /// orderby linq will shuffle the deck
        /// </summary>
        public void ShuffleNewDeck()
        {
            cards.Clear();
            for (int i = 1; i < 5; i++)//CardSuits
            {
                for (int j = 1; j < 14; j++)//CardValues: 2...10,J,Q,K,A = 13 different values
                {
                    aCard card = new aCard();

                    //add in value and suit(faces)
                    card.Value = (CardValue)j;
                    card.Suit = (CardSuit)i;
                    cards.Add(card);
                }
            }


            //Note: need to use project 1 random.
            Random r = new Random();

            //linQ shuffle the
            cards = cards.OrderBy(x => r.Next()).ToList();
        }


        //where is the hand coming from though. 

        //using stack of cards.
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hand"></param>
        /// <returns></returns>
        public aCard drawCard(Hand hand)
        {
            //get the card
            aCard drawn = cards[cards.Count - 1];

            //remvove from deck
            cards.Remove(drawn);

            //add to hands
            hand.Cards.Add(drawn);

            //return the card
            return drawn;

        }


        


    }
    /// <summary>
    /// Exception class for the deck. throw and catch the exception.
    /// </summary>
    [Serializable]
    internal class DeckException : Exception
    {
        public DeckException()
        {
        }

        public DeckException(string message) : base(message)
        {
        }

        public DeckException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DeckException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
