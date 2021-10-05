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
            int lengthOfNumbers = numbersToCheck.Length;
            Dictionary<int, int> Map = new Dictionary<int, int>();

            for (int i = 0; i < lengthOfNumbers; i++)
            {
                if(Map.ContainsKey(numbersToCheck[i]))
                    return numbersToCheck[i];
                Map.Add(numbersToCheck[i], numbersToCheck[i]);
            }
            return null;
        }
    }
}