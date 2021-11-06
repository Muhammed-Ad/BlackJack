using System.Collections.Generic;
using System.Linq;
using System;

namespace Project2
{
    /// <summary>
    /// creating a shuffling machine or a shoe containing potentially up to 8 decks of cards
    /// </summary>
    public class aShoe //: IDrawCard
    {
        /// <summary>
        /// object shoe as read only at the runtime
        /// </summary>
        private readonly List<aDeckOfCards> shoe = new List<aDeckOfCards>();

        /// <summary>
        /// number of deck
        /// </summary>
        int numberOfDecks;

        /// <summary>
        /// Contructor with the default number of decks is 1 if no argument passed
        /// </summary>
        /// <param name="numberOfDecks"></param>
        public aShoe(int numberOfDecks = 1)
        {
            this.numberOfDecks = numberOfDecks;
            for (int i = 0; i < numberOfDecks; ++i)
            {
                shoe.Add(new aDeckOfCards());
            }

        }

        /*
        public aCard Draw()
        {
            Random rand = new Random();
            int value = rand.Next(0, deck.Count);
            aCard drawCard = deck[value];

            deck.RemoveAt(value);

            return drawCard;

        }*/
    }
 

}
