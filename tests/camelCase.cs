using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
    {
        public static void Main(String[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(GetWordQty(s));
            Console.ReadLine();
        }

        private static int GetWordQty(string s)
        {
            int wordQty = 1;

            if(Char.IsUpper(s[0]))
                return 0;


            for (int i = 1; i < s.Length; i++)
            {
                if(Char.IsUpper(s[i])){
                    wordQty++;
                }
            }

            return wordQty;
        }
    }
