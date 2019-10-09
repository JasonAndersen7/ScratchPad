using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
   public class Dog
    {

        private int weight;

        public Dog(int weight)
        {
            this.weight = weight;
        }

        public override string ToString()
        {
            return  $" the weight of the dog is {weight.ToString().ToLower()}";
        }

        /// <summary>
        /// Dogs are sorted according to their weight
        /// </summary>
        /// <param name="o1"></param>
        /// <param name="o2"></param>
        /// <returns></returns>
        public static Comparison WhichDogComesFirst(Object o1, Object o2)
        {
            Dog s1 = (Dog) o1;
            Dog s2 = (Dog) o2;

            return s1.weight < s2.weight
                ? Comparison.TheFirstComesFirst
                : Comparison.TheSecondComesFirst;
        }

        public static string ReverseName(Object o1)
        {
            Dog d1 = (Dog) o1;

            string reverseName =  new string(d1.ToString().Reverse().ToArray());

            return reverseName;
        }
    }
}
