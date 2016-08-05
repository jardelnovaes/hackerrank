using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        int A = Convert.ToInt32(Console.ReadLine());
        int B = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(GetSequences(A, B));
        
        //3:25 -> 2925
        //Console.WriteLine(GetSequences(3, 25));
        
        //24:17 -> 0  
        //Console.WriteLine(GetSequences(24, 17));
    }
    
    public static int GetSequences(int A, int B)
        {
            const int MOD = 1000000007;
            const int SCORE_DIF = 2;
            const int MIN_SCORE = 25;

            int games = 0;

            if (A < B)
            {
                int temp = A;
                A = B;
                B = temp;
            }

            if (A < MIN_SCORE)
                return 0;

            if (A == MIN_SCORE)
            {
                if (A - B < SCORE_DIF)
                    return 0;
                else
                    return Comb(A - 1, B, MOD);
            }

            if (A - B != SCORE_DIF)
            {
                return 0;
            }

            games = Comb(24, 24, MOD);
            games = (int)((((long)games) * pow(2, B - 24, MOD)) % MOD);

            return games;
        }

        private static int Comb(int n, int r, int mod)
        {
            if (n < r)
            {
                int temp = n;
                n = r;
                r = temp;
            }

            if (n < 1 || r < 1)
            {
                return 1;
            }

            int[] row = new int[r];
            for (int i = 0; i < r; row[i++] = 1) ;
            for (int i = 2; i < r; ++i)
                for (int j = i - 1; j > 0; --j)
                    row[j] = (row[j] + row[j - 1]) % mod;

            --r;
            int sum = row[r];
            for (int i = 0; i < n; ++i)
            {
                for (int j = r; j > 0; --j)
                    row[j] = (row[j] + row[j - 1]) % mod;

                sum = (sum + row[r]) % mod;
            }

            return sum;
        }

        private static int pow(int Base, int exp, int mod)
        {
            long res = 0;

            if (exp < 2)
                return (exp < 1) ? 1 : Base;

            res = pow(Base, exp >> 1, mod);
            res = (res * res) % mod;

            if ((exp & 1) == 1)
                return (int)((res * Base) % mod);
            else
                return (int)(res);
        }
}
 
