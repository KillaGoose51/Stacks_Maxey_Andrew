using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Maxey_Andrew
{
    internal class Card
    {
    
        public string Number { get; }
        public string Suit { get; }
        // get the secounds word in the sentence and assigns it to Suit

        // Constructor assigns values to be used in a "New" object
        public Card(string numParam, string suitParam)
        {//Card("A", "Spades") turns the Number into a Number Param so now A = numParam
            //param resets the variable allowing new ones to be put through making a new object
            Number = numParam;
            //Param = placeholder, param allows change 
            Suit = suitParam;
        }

    }
}
