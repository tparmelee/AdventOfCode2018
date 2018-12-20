using System.Collections.Generic;
using System.Linq;

namespace Day3
{
    public class Part1
    {

        public static int FindOverlappingSquareInches(List<string> input) {
            List<Claim> claims = input.Select(x => Claim.Parse(x)).ToList();

            Dictionary<string, int> cellCounts = new Dictionary<string, int>();

            // Loop through all cells counting the repeats
            claims.ForEach(c =>
                {
                    foreach (string cell in c)
                    {
                        if (cellCounts.ContainsKey(cell))
                        {
                            cellCounts[cell]++;
                        }
                        else
                        {
                            cellCounts.Add(cell, 1);
                        }
                    }

                }
            );

            return cellCounts.Where(x => x.Value > 1).Count();
        }
        
    }
}