using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnagramLib
{
    public class anagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írj be egy szöveget!");
            Console.WriteLine("");

            string text = Console.ReadLine();
            string[] words = text.Split();

            Console.WriteLine("");
            Console.WriteLine("Összekeverve:");
            Console.WriteLine("");

            foreach (string word in words)
            {
                Console.Write(mixWord(word) + " ");
            }        

            Console.ReadKey();
        }

        static string mixWord(string word)
        {
            int length = word.Length;
            char[] anagram = new char[length];
            Random rnd = new Random();
                        
            for (int i = 0; i < length; i++)
            {
                int num = rnd.Next(0, length);

                if (char.IsLetter(anagram[num]))
                {
                    i--;
                }
                else
                {
                    anagram[num] = word[i];
                }
            }

            return new string(anagram);
        }

      
    }
}
