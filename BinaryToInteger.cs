/*
Name:         Roger Silva Santos Aguiar
Function:     It converts an array of zero and one to its integer representation
Initial date: January 29, 2021
Last update:  January 29, 2021
*/

using System;

namespace OnesAndZeroes
{
    class BinaryToNumber
    {       
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            int number = 0;
            int power = BinaryArray.Length - 1;

            for(int bit = 0; bit < BinaryArray.Length; bit++)
            {
                number = number + (Convert.ToInt32(BinaryArray[bit] * (Math.Pow(2, power))));
                power--;
            }

            return number;          
        }        
    }

}
