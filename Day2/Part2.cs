using System.Collections.Generic;
using System.Linq;

namespace Day2
{
    public class Part2
    {

        public static string FindPrototypeBox(List<string> input)
        {

            for (int i = 0; i < input.Count - 1; i++)
            {
                string first = input[i];
                for (int j = 0; j < input.Count; j++)
                {
                    string second = input[j];
                    int diffIndex = -1;
                    int diffCount = 0;

                    // find differences between strings
                    for (int k = 0; k < first.Length; k++)
                    {
                        
                        // Store found differences
                        if (first[k] != second[k])
                        {
                            diffIndex = k;
                            diffCount++;
                        }
                    }

                    if (diffCount == 1) {
                        return first.Remove(diffIndex, 1);
                    }
                }
            }

            return "";
        }

    }
}