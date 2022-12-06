using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TextualAnalysis
{
    public class TextualAnalysis
    {
        public static string stopWordFilePath = "../../../Data/stop-words.txt";

        public TextualAnalysis()
        {
        }


        public static Dictionary<string, int> ComputeWordFrequencies(string s, bool ignoreStopWords = false)
        {
            var wordCounts = new Dictionary<string, int>();
            string[] stopWords = GetStopWordsFromFile(stopWordFilePath);
            // create hash set
            // add stop words to hash set
            HashSet<string> hashset = new HashSet<string>();
            foreach (string word in stopWords)
            {
                hashset.Add(word);
            }

            // s = "all the faith he had had had had no effect."

            // remove punctuation
            var cleanString = Regex.Replace(s, @"[^\w\s]", "");

            // split the string into words (filtering out the empty strings)
            var words = cleanString.ToLower().Split().Where(s => s != "");

            // foreach word
            // if ignoring stop words and the word is a stop word
            // skip the word
            // else
            // either add word if new with a count of one
            // or increment the word count if it's already in the dictionary
            foreach (var word in words)
            {
                if (ignoreStopWords == true && stopWords.Contains(word) == true)
                {
                    continue;
                }
                else
                {
                    if (wordCounts.ContainsKey(word))
                    {
                        wordCounts[word]++;
                    }
                    else
                    {
                        wordCounts.Add(word, 1);
                    }
                }

            }


            return wordCounts;
        }


        public static Dictionary<string, int> ComputeWordFrequenciesFromFile(string path, bool ignoreStopWords = false)
        {
            // read in the file
            string text = System.IO.File.ReadAllText(path);

            // call the other method
            if (ignoreStopWords == true)
            {
                var result = ComputeWordFrequencies(text, ignoreStopWords = true);
                return result;
            }
            else
            {
                var result = ComputeWordFrequencies(text);
                return result;
            }

            // return the result of the other method
        }

        private static string[] GetStopWordsFromFile(string path)
        {
            var rawLines = System.IO.File.ReadAllLines(path);
            var lines = new List<string>();

            foreach (var line in rawLines)
            {
                // ignore blank lines
                if (line.Trim() != "")
                {
                    lines.Add(line.Trim().ToLower());
                }
            }

            return lines.ToArray();
        }

    }
}
