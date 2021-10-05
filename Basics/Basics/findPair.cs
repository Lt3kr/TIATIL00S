using System;
using System.Collections.Generic;

namespace Basics
{
    class findPair
    {
        public int? run()
        {
            // We store our data.
            int[] numbersToCheck = new int[] { 1, 2, 3, 4, 5 };
            // Check the length
            int lengthOfNumbers = numbersToCheck.Length;
            // We create our "hashmap".
            Dictionary<int, int> Map = new Dictionary<int, int>();

            // Loop through our array.
            for (int i = 0; i < lengthOfNumbers; i++)
            {
                // If it contains our pair return it!
                if(Map.ContainsKey(numbersToCheck[i]))
                    return numbersToCheck[i];

                // If it doesn't exist add it our map.
                Map.Add(numbersToCheck[i], numbersToCheck[i]);
            }

            // If we don't find a pair.
            return null;
        }
    }
}