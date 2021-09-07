using System;

namespace Basics
{
    class findIndex
    {
        public int[] run()
        {
            int[] numbersToCheck = new int[] { 12, 14, 10, 1 };
            int lengthOfNumbers = numbersToCheck.Length;
            int numberToFind = 13;

            for (int i = 0; i < lengthOfNumbers; i++)
            {
                var valueOfI = numbersToCheck[i];
                for (int x = i+1; x < lengthOfNumbers; x++)
                {
                    var valueOfX = numbersToCheck[x];
                    var addedNumbers = valueOfX+valueOfI;
                    if(addedNumbers == numberToFind)
                        return new int[] { i, x };
                }
            }
            return null;
        }
    }
}