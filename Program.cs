/*
Name:         Roger Silva Santos Aguiar
Function:     It tests the BinaryToInteger class
Initial date: January 29, 2021
Last update:  January 29, 2021
*/
using System;

namespace OnesAndZeroes
{
    class Program
    {
        static void Main(string[] args)
        {         
            Console.Write("Enter a binary number: ");
            string binary = Console.ReadLine();

            int [] BinaryArray = ConvertToArray(binary);            
            int integer_number = BinaryToNumber.binaryArrayToNumber(BinaryArray);            
            DisplayResult(integer_number, BinaryArray);
        }

        static int [] ConvertToArray(string binary)
        {
            int [] BinaryArray = new int[binary.Length];
            
            for(int i = 0; i < binary.Length; i++)
            {
                BinaryArray[i] = Convert.ToInt32(binary[i].ToString());
            }
            return BinaryArray;
        }
        static void DisplayResult(int integer_number, int [] BinaryArray)
        {
            string output = "";

            for(int i = 0; i < BinaryArray.Length; i++)
            {
                output += BinaryArray[i].ToString();
            }
            Console.WriteLine($"{output} = {integer_number}");
        }
    }
}
