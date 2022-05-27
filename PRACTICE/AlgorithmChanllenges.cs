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

        // EXAMPLE: BINARY SEARCH ALGORITHM AKA "DIVIDE AND CONQUER
        // Note: The initial input needs to sorted
        public bool BinarySearch(int[] arr, int theNum)
        {
            int Min = 0;
            int Max = arr.Length - 1;

            while(Min <= Max)
            {
                int mid = (Min + Max) / 2;
                if(arr[mid] == theNum)
                {
                    return true;
                }
                else if(arr[mid] > theNum)
                {
                    Max = mid - 1;
                }
                else
                {
                    Min = mid + 1;
                }
            }
            return false;
        }

        // CHALLENGE 2: ALGORITHM THAT ROTATES AN ARRAY
        public int[] RotateArray(int[] arr)
        {
            int temp = arr[0];
            for(int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            arr[arr.Length - 1] = temp;
            return arr;
        }
    }
}
