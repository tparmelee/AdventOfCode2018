using System.Collections.Generic;
using System.Linq;
using System;

namespace Day6
{
    public class Part1
    {

        public static int MaxNonInfiniteSpace(List<string> input)
        {
            List<Location> locations = ParseInput(input);

            List<int> xArr = locations.Select(loc => loc.x).ToList();
            List<int> yArr = locations.Select(loc => loc.y).ToList();

            int xMin = xArr.Min();
            int xMax = xArr.Max();
            int xWidth = xMax - xMin;

            int yMin = yArr.Min();
            int yMax = yArr.Max();
            int yWidth = yMax - yMin;

            int[][] map = InitializeMap(xWidth, yWidth);

            map = UpdateDistances(map, locations);

            int maxArea = FindLargestNonInfinateArea(locations, map, xMin, xMax, yMin, yMax);

            return maxArea;
        }

        private static int FindLargestNonInfinateArea(List<Location> locations, int[][] map, int xMin, int xMax, int yMin, int yMax)
        {
            int largestArea = 0;

            for (int locId = 0; locId < locations.Count; locId++) {
                Location loc = locations[locId];

                if (loc.x == xMin || loc.x == xMax || loc.y == yMin || loc.y == yMax) {
                    // This location is on an edge and therefore its area is an infinate area;
                    continue;
                } else {
                    int currentLocArea = 0;

                    foreach(int[] row in map) {
                        foreach (int cell in row) {
                            if(cell == locId) {
                                currentLocArea++;
                            }
                        }
                    }

                    if (currentLocArea > largestArea) {
                        largestArea = currentLocArea;
                    }
                }

            }

            return largestArea;
        }

        private static int[][] UpdateDistances(int[][] map, List<Location> locations)
        {

            for (int x = 0; x < map.Length; x++)
            {
                // Loop over rows
                int[] row = map[x];

                for (int y = 0; y < row.Length; y++)
                {
                    // loop over columns
                    
                    Dictionary<int, List<int>> distances = new Dictionary<int, List<int>>();

                    for (int locId = 0; locId < locations.Count; locId++)
                    {
                        // find closest dangerous coord
                        Location loc = locations[locId];

                        // distance from current grid coordinate to the dangerous coord
                        int dist = Math.Abs(loc.x - x) + Math.Abs(loc.y - y);

                        // add distances
                        if (distances.ContainsKey(dist)) {
                            distances[dist].Add(locId);
                        }
                        else
                        {
                            distances.Add(dist, new List<int>() {locId});
                        }
                    }       

                    int minDist = distances.Keys.Min();

                    if (distances[minDist].Count > 1) {
                        map[x][y] = -1;
                    }
                    else{
                        map[x][y] = distances[minDist][0];
                    }

                }

            }

            return map;
        }

        private static int[][] InitializeMap(int xWidth, int yWidth)
        {
            int[][] map = new int[xWidth][];

            for (int i = 0; i < xWidth; i++)
            {
                map[i] = new int[yWidth];
            }

            return map;
        }

        private static List<Location> ParseInput(List<string> input)
        {
            return input.Select(x => ParseSingleLocation(x)).ToList();
        }

        private static Location ParseSingleLocation(string line)
        {
            string[] splitLine = line.Replace(" ", "").Split(',');

            return new Location
            {
                x = int.Parse(splitLine[0]),
                y = int.Parse(splitLine[1])
            };
        }
    }
}