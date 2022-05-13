using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    public class AlgorithmChanllenges
    {
        public string theWord { get; set; }
        // CHALLENGE 1: ALGORITHM THAT REVERSES EACH WORD IN A SENTENCE
        public string ReverseEachWord(string word)
        {
            char[] arr = word.ToCharArray();
            Array.Reverse(arr);
            string sentenceRe = new String(arr);

            char[] delimeter = { ' ' };
            string[] newWords = sentenceRe.Split(delimeter);
            string[] original = new string[newWords.Length];

            int j = 0;
            int len = newWords.Length - 1;

            foreach(string wor in original)
            {
                original[j] = newWords[len];
                j++;
                len--;
            }

            return String.Join(" ", original);
        }

        
    }
}
