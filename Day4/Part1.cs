using System.Collections.Generic;
using System.Linq;
using System;

namespace Day4
{
    public class Part1
    {

        public static int FindGuard(List<string> input)
        {
            input.Sort();

            // first key = guard #id
            // second key = day
            // List = cyles for guard in each day
            Dictionary<int, int[]> mappedSleep = new Dictionary<int, int[]>();

            int startTime = -1;
            int guardId = -1;


            foreach (string x in input)
            {
                string[] split = x.Split(" ");

                string date = split[0].Substring(1);
                int day = int.Parse(date.Substring(date.Length - 2));

                string time = split[1].Substring(0, split[1].Length - 1);
                int minute = int.Parse(time.Substring(3));

                string action = split[2];               

                switch (action)
                {
                    case ("Guard"):
                        {
                            guardId = int.Parse(split[3].Substring(1));
                            // Create new entry for this guard if not found
                            if (!mappedSleep.ContainsKey(guardId))
                            {
                                mappedSleep.Add(guardId, new int[60]);
                            }

                            break;
                        }
                    case ("falls"):
                        {
                            // record fall asleep time
                            startTime = minute;

                            break;
                        }
                    case ("wakes"):
                        {
                            // record awake time

                            for (int i = startTime; i < minute; i++)
                            {
                                mappedSleep[guardId][i]++;
                            }
                        }
                        break;
                }
            }

            // Find most asleep guard
            int maxGuard = -1;
            int maxSleep = 0;
            foreach (var pair in mappedSleep)
            {
                int currentSleep = pair.Value.Sum();

                if (currentSleep > maxSleep)
                {
                    maxSleep = currentSleep;

                    maxGuard = pair.Key;
                }
            }

            // Find max sleep minute of selected guard
            int maxMinute = -1;
            int maxSleepMinute = -1;
            for (int i = 0; i < mappedSleep[maxGuard].Length; i++)
            {
                if (mappedSleep[maxGuard][i] > maxSleepMinute)
                {
                    maxSleepMinute = mappedSleep[maxGuard][i];
                    maxMinute = i;
                }
            }

            return maxGuard * maxMinute;
        }
    }
}