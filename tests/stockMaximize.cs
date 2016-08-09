using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    
        static long calculateProfit(long n, long[] prices)
        {
            bool[] sellIdx = new bool[n];
            long profit = 0;
            
            long stock = 0;
            long stockQty = 0;
            long higherPrice = 0;

            for (long i = n-1; i >= 0; i--)
            {
                //Gets the higher price 
                if (higherPrice < prices[i])
                {
                    higherPrice = prices[i];
                    sellIdx[i] = true;
                }
                else
                {
                    sellIdx[i] = false;
                }
            }

            for (long i = 0; i < n; i++)
            {
                if (!sellIdx[i])
                {
                    stock += prices[i]; //buy
                    stockQty++;
                }
                else if (stock != 0)
                {
                    profit += prices[i] * stockQty - stock;
                    
                    //Reset stock and others
                    stock = 0;
                    stockQty = 0;
                }
            }

            return profit;
        }

        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

            //Gets the number of tests
            long t = Convert.ToInt64(Console.ReadLine());

            if (t < 0)
                throw new Exception("Invalid value");

            //For each test
            for (int i = 0; i < t; i++)
            {
                //Gets the number of prices
                long n = Convert.ToInt64(Console.ReadLine());

                if (n < 0)
                    throw new Exception("Invalid value");

                //Gets the prices string
                string aux = Console.ReadLine();
                long[] prices = Array.ConvertAll(aux.Split(' ').ToArray(), s => long.Parse(s));  //convert to int array

                long profit = calculateProfit(n, prices);

                //print test[n] result
                Console.WriteLine(profit);                
            }
        }
}
