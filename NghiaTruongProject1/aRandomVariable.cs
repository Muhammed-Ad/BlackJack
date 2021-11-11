using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    /// <summary>
    /// intermadiate class that inherits from Random class
    /// Why this intermediate class is a good approach:
    /// In this class, we use static random variable
    /// So that we can call and reuse the rand_number without creating object
    /// Moreover, Static member variables only need to be declared and initialize once 
    /// and continue to exist throughout the program until the end of the program.
    /// 
    /// This practice using intermediate class calls inheritance.
    /// by applying inheritance, we can set data in the base class to be protected
    /// so that the derived class can get and use it.
    /// </summary>
    public class aRandomVariable : Random
    {

        /// <summary>
        /// static random object for aRandomVariable class
        /// able to be protected or public so that aDie class can inherits
        /// by using static, we can implement multiple types of objects 
        /// that require some form of a random number generator 
        /// without running into the issue of generating multiple random number generators in a short period of time.
        /// </summary>
        public static Random rand_number;
    }
}
