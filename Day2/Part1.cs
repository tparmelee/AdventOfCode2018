using System.Collections.Generic;
using System.Linq;

namespace Day2
{
    public class Part1
    {

        public static int CalculateCheckSum(List<string> boxIds)
        {
            int twoCount = 0;
            int threeCount = 0;

            boxIds.ForEach(id =>
            {
                Dictionary<char, int> letterSet = CountOccurencesOfLettersInString(id);

                if (letterSet.Values.Contains(2))
                {
                    twoCount++;
                }
                if (letterSet.Values.Contains(3))
                {
                    threeCount++;
                }
            });

            return twoCount * threeCount;
        }

        private static Dictionary<char, int> CountOccurencesOfLettersInString(string id)
        {
            Dictionary<char, int> set = new Dictionary<char, int>();

            foreach (var letter in id)
            {
                if (set.ContainsKey(letter))
                {
                    set[letter]++;
                }
                else
                {
                    set.Add(letter, 1);
                }
            }

            return set;
        }
    }
}