using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace StringUtilities
{
    public static class StringUtilities
    {
        public static bool IsUniqueCharacterSet(this string s)
        {
            // remove all space chars from string
            var cleanString = Regex.Replace(s, @"\s+", string.Empty).ToLower();

            // check for duplicate letters
            HashSet<char> hashset = new HashSet<char>();

            foreach( var letter in cleanString)
            {
                if (hashset.Contains(letter))
                {
                    return false;
                }
                hashset.Add(letter);
            }

            return true;
        }
    }
}
