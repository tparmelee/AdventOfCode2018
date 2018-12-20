using System.Collections.Generic;
using System.Linq;

namespace Day5
{
    public class Part1
    {
        
        public static int GetRemainingPolymerCount(string input) {
            Polymer polymer = new Polymer(input);
            
            return polymer.Reacted.Length;
        }
        
    }
}