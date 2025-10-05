using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSA
{
    /*You are given an array prices where prices[i] is the price of a given stock on the ith day.

    You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

    Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.*/
    public class BuyAndSellStock
    {
        // brute force -- O(n^2)
        public static int MaxProfitBF(int[] prices)
        {
            int maxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    int profit = prices[j] - prices[i];
                    if (profit > maxProfit)
                    {
                        maxProfit = profit;
                    }

                }

            }

            return maxProfit;
        }

        // optimal -- O(n)
        public static int MaxProfitOptimal(int[] prices)
        {
            int min = prices[0];
            int profit = 0;
            int maxProfit = 0;

            //7,1,5,3,6,4
            for (int i = 0; i < prices.Length; i++)
            {

                if (prices[i] < min)
                {
                    min = prices[i];
                }

                profit = prices[i] - min;
                maxProfit = Math.Max(profit, maxProfit);


            }

            return maxProfit;
        }
    }
}
