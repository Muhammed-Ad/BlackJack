using System.Collections.Generic;
using System.Linq;

namespace Project2
{

    interface IDrawCard
    {
        aCard Draw();
    }

    

    /// <summary>
    /// shuffle machine for deck of cards 
    /// </summary>
    class aShoe : IDrawCard
    {

        //may contain more than 8 decks - how to init the decks?

        


        private List<aDeckOfCards> decks;
        private Stack<aCard> allCardsStack;

        public aShoe(aDeckOfCards deck)
        {
            aDeckOfCards aDeck = new aDeckOfCards(deck);
            decks.Add(aDeck);
        }

        //constructor takes in number of decks.
        public aShoe(int nDecks)
        {


            //init deck list. 
            decks = new List<aDeckOfCards>();

            //init all card stack
            allCardsStack = new Stack<aCard>();
            
       
            aDeckOfCards deck;

            //create deck based on nDecks, then add to decks list and stack

            //double for loop got problem mah man
            for( int i = 0; i < nDecks; i++)
            {
                deck = new aDeckOfCards();
                decks.Add(deck);

                //add card in decks to stack but out of memory?
                for(int j = 0; j < deck.cards.Count(); j++)
                {
                    allCardsStack.Push(deck.cards[j]);
                }

            }

            //iterate through then add in stack.

            

            //add all cards to a list though then pop when draw?
        }


        //private aDeckOfCards decks;


        /// <summary>
        /// use to build application not tightly connected to each others.
        /// </summary>
        /// 

        //aCard IDrawCard.


        //no multiple inheritance. 
        //draw card function

        //got this draw card function, need to implement it though like deck

        //The function at aDeckOfCards: pass in a hand, draw card, add card to hand. 

       
        public static bool IsEmpty<aDeckofCards>(List<aDeckofCards> list)
        {
            if (list == null)
            {
                return true;
            }

            return !list.Any();
        }



        //return a card;
        public aCard Draw()
        {
            //int usingDeck = 0;

            //draw from the decks: 1 to 8 decks
            /*
            for( int i = 0; i < decks.Count; i++)
            {
                //if the deck is null
                if(decks[0] == null)
                {
                    //update the using deck.
                    usingDeck += 1;
                    break;
                }
            }
            */

            //new changes: draw from a stack though.
            //allCardsStack



            //aCard a = new aCard();

            //draw 1 from deck.
            /*
            aCard drawn = decks[usingDeck].cards[decks[usingDeck].cards.Count - 1];

            //remvove from deck
            decks[usingDeck].cards.Remove(drawn);

            //add to hands
            //hand.Cards.Add(drawn);
            */

            aCard drawn = allCardsStack.Pop();


            return drawn; 
        }
       
    }

}
