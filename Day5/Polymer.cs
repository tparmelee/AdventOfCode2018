using System.Collections.Generic;
using System.Linq;

namespace Day5
{
    public class Polymer
    {
        public string Prereaction;
        public string Reacted;

        public Polymer(string input) {
            this.Prereaction = input;
            this.Reacted = React(input);
        }

        private static string React(string input)
        {
            bool changeMade = true;
            List<byte> ascii = System.Text.Encoding.UTF8.GetBytes(input).ToList();

            while (changeMade)
            {
                changeMade = false;

                int i = 0;
                while (i < ascii.Count - 1)
                {
                    if (System.Math.Abs(ascii[i] - ascii[i + 1]) == 32)
                    {
                        changeMade = true;

                        ascii.RemoveAt(i);
                        ascii.RemoveAt(i);

                        // Step back 1 position to check the data on
                        // either side of currently removed.
                        if (i > 0) {
                            i--;
                        }
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            string result = System.Text.Encoding.UTF8.GetString(ascii.ToArray());
            return result;
        }
    }
}