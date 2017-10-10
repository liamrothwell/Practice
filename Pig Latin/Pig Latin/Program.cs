using System;
using System.Collections.Generic;
using System.Linq;

namespace Pig_Latin
{
    class Program
    {
        static void Main()
        {
            List<string> outputList = new List<string>();

            string sentence = GetSentence();
            var listOfWords = sentence.Split(' ').ToList();
            ConvertToPigLatin();
            Console.WriteLine(ListToString().ToLower());
            Console.ReadKey();

            string GetSentence()
            {
                Console.WriteLine("Enter the sentence you wish to convert, then press enter.");
                return Console.ReadLine();
            }

            void ConvertToPigLatin()
            {
                foreach (var word in listOfWords)
                {
                    outputList.Add(word.Substring(1) + word[0] + "ay");
                }
            }

            string ListToString()
            {
                string output = "";
                foreach (var word in outputList)
                {
                    output = output + " " + word;
                }
                return output;
            }
        }
    }
}
