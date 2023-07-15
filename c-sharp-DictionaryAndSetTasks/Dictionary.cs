using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace c_sharp_DictionaryAndSetTasks
{
    internal class Dictionary
    {
        /*
       Task 1: Word Frequency Counter
       Create a program that prompts the user to enter a sentence.The program should count the frequency of
       each word in the sentence and display the results as a dictionary, where the keys are the unique words
       and the values are the corresponding frequencies
       */

        public Dictionary<string, int> Frequency(string sentence)
        {
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

            string[] words = sentence.Split(' ');

            foreach (string word in words)
            {
                if (wordFrequency.ContainsKey(word))
                {
                    wordFrequency[word]++;
                }
                else
                {
                    wordFrequency[word] = 1;
                }
            }

            return wordFrequency;
        }
        
        
        

    }
}

