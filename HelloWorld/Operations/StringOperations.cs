using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BegginerCourse
{
    public class StringOperations
    {

        public int CountNumberOfVowels(string text)
        {
            string pattern = @"[aeiouà-ú]";

            Regex regex = new Regex(pattern);

            return regex.Matches(text.ToLower()).Count;
        }


        public string ReverseString(string line)
        {
            string reversedName ="";

            List<string> names = new List<string>();

            char[] letters = line.ToCharArray();

            for (int i = 0; i < letters.Length; i++)
            {
                names.Add(letters[i].ToString());
            }

            names.Reverse();

            for (int i = 0; i < letters.Length; i++)
            {
                reversedName = reversedName + names[i].ToString();
            }

            return reversedName;

        }


    }
}
