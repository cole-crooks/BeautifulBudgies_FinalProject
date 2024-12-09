using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace crookscl_FinalProject
{
    public class Class1
    {
        public int MinimumBoxes(int N)
        {
            int height = 1, bottom = 1, total = 1;

            // Step 1: Build the pyramid until the total >= N
            while (total < N)
            {
                height++;
                bottom += height;
                total += bottom;
            }

            // Step 2: Backtrack to adjust for any excess boxes
            while (total >= N)
            {
                bottom--;
                total -= height;
                height--;
            }

            // Return the final number of floor boxes
            return bottom + 1;
        }
    }
}