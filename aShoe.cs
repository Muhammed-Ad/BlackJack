using System.Collections.Generic;
using System.Linq;
using System;

namespace Project2
{
    /// <summary>
    /// creating a shuffling machine or a shoe containing potentially up to 8 decks of cards
    /// </summary>
    public class aShoe : IDrawCard
    {
        /// <summary>
        /// object shoe as read only at the runtime
        /// </summary>
        private readonly List<aDeckOfCards> shoe = new List<aDeckOfCards>();
        Random rand;
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
                aDeckOfCards deck = new aDeckOfCards();
                // shoe.AddRange(deck.)
                shoe.Add(new aDeckOfCards());
            }
            rand = new Random();
        }

        
        public aCard Draw()
        {
            
            int DeckIndex = rand.Next(0, numberOfDecks);
            if (shoe[DeckIndex].isEmpty())
            {
                shoe.RemoveAt(DeckIndex);
                
                if (shoe.Count() == 0)
                {
                    System.Windows.Forms.MessageBox.Show("Empty Deck of cards. Please exit.");
                    return null;
                }
                
            }

            int value = rand.Next(0, shoe[DeckIndex].Count);
            aCard drawCard = shoe[DeckIndex].drawCard(value);

            shoe[DeckIndex].removeCard(value);

            return drawCard;

        }
    }
 

}
