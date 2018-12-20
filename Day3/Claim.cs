using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Day3
{

    public class Claim : IEnumerable<string>
    {
        public int id;
        public int left;
        public int top;
        public int width;
        public int height;

        public static Claim Parse(string input) {
            string[] splitClaim = input.Split(" ");

            Claim parsed = new Claim();
            
            // Get ID
            parsed.id = int.Parse(splitClaim[0].Remove(0,1));

            // Top Left Corner
            string loc = splitClaim[2].Substring(0, splitClaim[2].Length - 1);
            string[] locParts = loc.Split(",");
            parsed.left = int.Parse(locParts[0]);
            parsed.top = int.Parse(locParts[1]);

            // Dimensions
            string dims = splitClaim[3];
            string[] dimsParts = dims.Split("x");
            parsed.width = int.Parse(dimsParts[0]);
            parsed.height = int.Parse(dimsParts[1]);

            return parsed;
        }

        public IEnumerator<string> GetEnumerator()
        {
            for (int x = left; x < left + width; x++)
            {
                for (int y = top; y < top + height; y++)
                {
                    yield return UniqueCellId(x, y);
                }
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private static string UniqueCellId(int x, int y) {
            return $"{x.ToString()}_{y.ToString()}";
        }
    }
}