using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithamProgram
{
    /// <summary>
    /// Here We Are Checking Anagram.
    /// </summary>
    class AnagramDetection
    {

        public void CheckAnagram()
        {
            //Here, we are checking the following two strings.
            string str1 = "abcd";
            string str2 = "DCBA";
            //Convert the two srings in character array.
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            //Now Sort them.
            Array.Sort(ch1);
            Array.Sort(ch2);

            //After sorting convert them to strings.
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            Console.WriteLine(val1);
            Console.WriteLine(val2);

            if (val1 == val2)
            {
                Console.WriteLine("Both The Srings Are Anagrams");

            }
            else
                Console.WriteLine("Both The Strings Are Not Anagram");

        }
    }
}
