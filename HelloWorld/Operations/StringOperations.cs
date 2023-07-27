using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegginerCourse
{
    internal class StringOperations
    {

        public int CountNumberOfVowels(string text)
        {
            int numberOfVowels = 0;

            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < text.Length; i++)
            {
                if (vowels.Contains(text[i]))
                {
                    numberOfVowels++;
                }
            }

            return numberOfVowels;
        }
        public string [] SeparateStringValuesWithComma(string list)
        {
            string[] result = list.Split(',');

            return result;
        }

        public string[] SeparateStringValuesWithSpaces(string list)
        {
            string[] result = list.Split(' ');

            return result;
        }

        public string[] SeparateStringValuesWithColon(string list)
        {
            string[] result = list.Split(':');

            return result;
        }

        public string[] SeparateStringValuesWithHyphen(string list)
        {
            string[] result = list.Split('-');

            return result;
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
