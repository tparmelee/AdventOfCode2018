using System.Collections.Generic;
using System.Linq;

namespace Day1
{
    public class Part2
    {

        public static int CalculateFirstRepeatedFrequency(List<int> frequencies)
        {
            HashSet<int> encounteredFrequencies = new HashSet<int>();
            encounteredFrequencies.Add(0);

            int currentFrequency = 0;
            while (true)
            {

                foreach (int change in frequencies)
                {
                    currentFrequency += change;

                    // If the frequency has already been found, then return
                    // otherwise add to the found frequencies
                    if (encounteredFrequencies.Contains(currentFrequency))
                    {
                        return currentFrequency;
                    }
                    else
                    {
                        encounteredFrequencies.Add(currentFrequency);
                    }
                }
            }
        }
    }
}