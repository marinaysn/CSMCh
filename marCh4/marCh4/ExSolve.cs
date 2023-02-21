using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marCh4
{
    internal class ExSolve
    {

        public static int Solve(int[] boxes)
        {
            int len = boxes.Length; 
            int[,] dp = new int[len, len]; 

            for (int i = 0; i < len; i++)
            {
                dp[i, i] = boxes[i];
            }

            for (int row = 1; row < len; row++)
            {
                for (int i = 0; i < len - row; i++)
                {
                    int j = i + row;
                    dp[i, j] = Math.Max(boxes[i] - dp[i + 1, j], boxes[j] - dp[i, j - 1]);
                }
            }

            return dp[0, len - 1];
        }

    }
}


/*
 * 
 * Alex and Cindy, two students who recently spent some time on treasure hunting. 
 * Apart from scrap metal, they found a number of boxes full of old coins. 
 * Boxes are of different value and now are lined up in a row. 
 * Cindy proposes an idea to divide the treasure into two parts. 
 * She thinks that a fair way is that she and Alex take turns, 
 * and each of them chooses one box from either left or right side of the line. 
 * Cindy is a very generous person and lets Alex to go first.

 * Alex wants to check whether this idea is actually good for him. 
 * He asks you to write a program to calculate the total value 
 * that he will get compared to how much Cindy will get if he chooses a box first. 
 * You can be sure that they both are very smart, and always select the next box 
 * in such way that it leads to the best overall individual solution for them. 
 * This means they may not always choose the highest value box of the two 
 * currently available in order to ensure they get a higher value box later.

Examples
Solve([7, 2]) ➞ 5
// Alex will choose the 7, and then Cindy gets the 2.
// So the result is 7 ‐ 2 = 5.

Solve([2, 7, 3]) ➞ ‐2
// It doesn't matter whether Alex chooses the 2 or the 3. Cindy will
// choose the 7 and Alex will get the remaining box. (2+3) ‐ 7 = ‐2.

Solve([1000, 1000, 1000, 1000, 1000]) ➞ 1000
// Since Alex chooses first, he will get 3 boxes and Cindy will get only 2.
// They all have the same value so (1000+1000+1000) ‐ (1000+1000) = 1000.

Solve([823, 912, 345, 100000, 867, 222, 991, 3, 40000]) ➞ ‐58111
Notes
Reading sections 5.1, 5.3 and 5.4 of the book "Data Structures and Algorithms in Java" by Michael T. Goodrich, Irvine Roberto Tamassia, and Michael H. Goldwasser (2014) should help you with the solution to this task.

 */
