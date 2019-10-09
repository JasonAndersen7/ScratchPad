using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
   public class Pair
    {
        //private array to hold the two objects

        private object[] thePair = new object[2];

        //the delegate declaration
        public delegate Comparison WhichIsFirst(object obj1, object obj2);

        public delegate string ReverseMyName(object obj1);

        //in the constructor
        //added in order recieved
        public Pair(Object firstObject, object secondObject)
        {
            thePair[0] = firstObject;
            thePair[1] = secondObject;
        }

        //public method which orders the two objects by whatever criteria 

        public void Sort(WhichIsFirst theDelegateFunc)
        {
            if (theDelegateFunc(thePair[0], thePair[1]) == Comparison.TheSecondComesFirst)
            {
                object temp = thePair[0];
                thePair[0] = thePair[1];
                thePair[1] = temp;
            }
        }

        //public method which orders the two objects by reverse
        public void ReverseSort(WhichIsFirst theDelegateFunc)
        {
            if (theDelegateFunc(thePair[0], thePair[1]) == Comparison.TheFirstComesFirst)
            {
                object temp = thePair[0];
                thePair[0] = thePair[1];
                thePair[1] = temp;
            }
        }

        public void ReverseObject(ReverseMyName theDelegateFunc)
        {
            Console.WriteLine($"Reversed the value is: {theDelegateFunc(thePair[0])} and {theDelegateFunc(thePair[1])}");
        }

        /// <summary>
        /// ask the two objects their string value
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"The Values are first: {thePair[0].ToString()} and second: {thePair[1]}";
        }
    }
}
