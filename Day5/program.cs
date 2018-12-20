using System;
using System.Collections.Generic;
using System.IO;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            int part1result = Part1.GetRemainingPolymerCount(SampleData());
            Console.WriteLine($"The Part 1 Result is: {part1result}");
            // Correct part 1 result is 9386

            int part2result = Part2.FindPolymerOfShortestLength(SampleData());
            Console.WriteLine($"The Part 2 Result is: {part2result}");
            // Correct part 2 result is 4876
        }

        static string SampleData()
        {
            FileStream fs = new FileStream("SampleData.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(fs)) {
                string data = reader.ReadLine();
                return data;
            }

        }
    }
}
