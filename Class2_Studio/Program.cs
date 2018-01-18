using System;
using System.Collections.Generic;

namespace Class2_Studio
{
    class Program
    {
        /*public static int CharCount(string text, char c)
        {
            int count = 0;
            foreach (char ch in text)
            {
                if (ch.Equals(c))
                {
                    count++;
                }

            }
            return count;
        }*/

        public static SortedDictionary<char, ulong> Count(string stringToCount)
        {
            SortedDictionary<char, ulong> characterCount = new SortedDictionary<char, ulong>();

            foreach (var character in stringToCount)
            {
                if (!characterCount.ContainsKey(character))
                {
                    characterCount.Add(character, 1);
                }
                else
                {
                    characterCount[character]++;
                }
            }

            return characterCount;
           
}

            static void Main(string[] args)
        {

            string text = "Hello";
            //int count = CharCount(text, 'l');

            foreach (var character in Program.Count(text))
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }
        

       // Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
