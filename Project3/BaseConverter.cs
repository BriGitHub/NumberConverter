///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project3/Project3
//	File Name:         BaseConverter.cs
//	Description:       Contains the methods to be able to convert the numbers to different bases
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Brianna Martinson, martinson@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Friday, March 29, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    /// <summary>
    /// Contains the methods to be able to convert the numbers to different bases
    /// </summary>
    class BaseConverter
    {
        static string[] letterArray = { "A", "B", "C", "D", "E", "F" };

        /// <summary>
        /// Converts the number, as a string, to an integer of the desired base.
        /// </summary>
        /// <param name="num">The number, as a string, being converted.</param>
        /// <param name="baseFrom">The base the number is being converted to.</param>
        /// <returns>The string as an integer after it has been converted</returns>
        public static int ToDecimal(string num, int baseFrom)
        {
            Stack<char> chars = new Stack<char>();

            int result = 0;
            string tempChar;

            //Pushes all the characters into the stack
            foreach (char character in num.ToCharArray().Reverse())
            {
                chars.Push(character);
            }

            //Checks to see if the number is greater than 9 AKA a letter
            tempChar = chars.Pop().ToString().ToUpper();
            if (letterArray.Contains(tempChar))
            {
                result += Array.IndexOf(letterArray, tempChar) + 10;
            }
            else
            {
                result += Int32.Parse(tempChar);
            }

            //Adds the rest of the numbers and pops them out of the stack
            while (chars.Count > 0)
            {
                result *= baseFrom; //Multiplies by the base it's from
                tempChar = chars.Pop().ToString().ToUpper();
                if (letterArray.Contains(tempChar))
                {
                    result += Array.IndexOf(letterArray, tempChar) + 10;
                }
                else
                {
                    result += Int32.Parse(tempChar);
                }
            }

            return result;
        }

        /// <summary>
        /// Converts the number to a string of the desired base.
        /// </summary>
        /// <param name="num">The number being converted.</param>
        /// <param name="baseTo">The base the number is being converted to.</param>
        /// <param name="digits">The number of digits the string has to have</param>
        /// <returns>The string representing the number after being converted to the desired base</returns>
        public static string FromDecimal(int num, int baseTo, int digits)
        {
            Stack<int> nums = new Stack<int>();

            string result = "";

            //Pushes each digit into the stack
            while (num > 0) 
            {
                nums.Push(num % baseTo);
                num /= baseTo;
            }

            //Pushes 0's to the stack to reach the desired number of digits in the result
            while (nums.Count < digits)
            {
                nums.Push(0);
            }

            int pow = nums.Count - 1;
            while (nums.Count > 0) 
            {
                if (nums.Peek() > 9)
                {
                    result += letterArray[nums.Pop() - 10];
                }
                else
                {
                    result += nums.Pop().ToString();
                }
                pow--;
            }

            return result;
        }
    }
}
