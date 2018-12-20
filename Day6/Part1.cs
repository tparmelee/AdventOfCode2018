using System.Collections.Generic;
using System.Linq;

namespace Day6
{
    public class Part1
    {

        public static int MaxNonInfiniteSpace(List<string> input) {
            List<Location> locations = ParseInput(input);
            
            List<int> xArr = locations.Select(loc => loc.x).ToList();
            List<int> yArr = locations.Select(loc => loc.y).ToList();

            int xMin = xArr.Min();
            int xMax = xArr.Max();
            int xWidth = xMax - xMin;

            int yMin = yArr.Min();
            int yMax = yArr.Max();
            int yWidth = yMax - yMin;


            return 0;
        }
        
        private static List<Location> ParseInput(List<string> input) {
            return input.Select(x => ParseSingleLocation(x)).ToList();
        }

        private static Location ParseSingleLocation(string line) {
            string[] splitLine = line.Replace(" ", "").Split(',');

            return new Location {
                x = int.Parse(splitLine[0]),
                y = int.Parse(splitLine[1])
            };
        }
    }
}