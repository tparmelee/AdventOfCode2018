using System.Collections.Generic;
using System.Linq;

namespace Day3
{
    public class Part2
    {

        public static int FindOnlyNonOverlappingClaim(List<string> input) {
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

            // Loop through each claim again to find cell counts
            List<Claim> nonOverlappingIds = claims.Where(c => {
                foreach (string id in c) {
                    if (cellCounts[id] > 1) {
                        return false;
                    }
                }

                return true;
            }).ToList();

            return nonOverlappingIds[0].id;
        }
    }
}