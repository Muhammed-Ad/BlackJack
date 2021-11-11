using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    /// <summary>
    /// aDie class inherits aRandomVariable class
    /// </summary>
    class aDie : aRandomVariable
    {             

        /// <summary>
        /// default constructor of aDie class
        /// </summary>
        public aDie()
        {   
            //initialize rand_number
            rand_number = new Random();
        }
                
        /// <summary>
        /// constructor to take the seed from user input
        /// </summary>
        /// <param name="seed">the seed number that user input</param>
        public aDie(int seed)
        {
            rand_number = new Random(seed);
        }
                
        /// <summary>
        /// method to get the die number in a Roll
        /// </summary>
        /// <returns>return die_number as integer</returns>
        public int Roll()
        {
            //get the random int number from 1 to 6
            int die_number = rand_number.Next(1, 7);
            return die_number;
        }
    }
}
