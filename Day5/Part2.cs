using System.Collections.Generic;
using System.Linq;

namespace Day5
{
    public class Part2
    {
        public static int FindPolymerOfShortestLength(string input) {

            int minLength = int.MaxValue;

            foreach( char lowerChar in LowercaseAlphabet()) {
                char upperChar = char.ToUpper(lowerChar);

                string test = string.Copy(input);

                test = test.Replace(lowerChar.ToString(), string.Empty);
                test = test.Replace(upperChar.ToString(), string.Empty);

                Polymer poly = new Polymer(test);
                if (poly.Reacted.Length < minLength) {
                    minLength = poly.Reacted.Length;
                }
            }

            return minLength;
        }

        private static string LowercaseAlphabet() 
        {
            return "abcdefghijklmnopqrstuvwxyz";
        }
    }
}