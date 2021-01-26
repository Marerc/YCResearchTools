using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PaperTools4Word.Utils
{
    class Words
    {

        public static string titleCase(string s)
        {
            return Regex.Replace(s.ToLower(), @"(^|\W).\\", delegate (Match m) { return m.Value.ToUpper(); });
        }

        public static string capAll(string s)
        {
            return Regex.Replace(s, @"(^|\W).\\", delegate (Match m) { return m.Value.ToUpper(); });
        }

        public static string capFirst(string s)
        {
            return Regex.Replace(s, @"^.\\", delegate (Match m) { return m.Value.ToUpper(); });
        }

        public static string removeExcessSpaces(string input)
        {
            string pattern = "\\s+";
            string replacement = " ";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);
            return result;
        }

        public static string lowercaseAll(string s)
        {
            return Regex.Replace(s, @"(\W).\\", delegate (Match m) { return m.Value.ToUpper(); });
        }



    }
}
