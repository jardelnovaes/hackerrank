using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

        static void Main(String[] args)
        {
            //5 6 7
            //3 6 10
            //   => Expected 1 1 

            int totalA = 0;
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);

            if ((!checkConstraint(a0)) || (!checkConstraint(a1)) || (!checkConstraint(a2)))
            {
                Console.WriteLine("0 0");
                return;
            }

            int totalB = 0;
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);

            if ((!checkConstraint(b0)) || (!checkConstraint(b1)) || (!checkConstraint(b2)))
            {
                Console.WriteLine("0 0");
                return;
            }

            totalA += (a0 > b0) ? 1 : 0;
            totalA += (a1 > b1) ? 1 : 0;
            totalA += (a2 > b2) ? 1 : 0;

            totalB += (a0 < b0) ? 1 : 0;
            totalB += (a1 < b1) ? 1 : 0;
            totalB += (a2 < b2) ? 1 : 0;

            Console.WriteLine(String.Format("{0} {1}", totalA, totalB));

            Console.ReadLine();

        }

        static bool checkConstraint(int v)
        {
            return ((v >= 1) || (v <= 100));
        }

}
