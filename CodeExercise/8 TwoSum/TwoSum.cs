using System;
using System.Collections.Generic;
using System.Linq;
/*

Write a function that, when passed a list and a target sum, returns, efficiently with respect to time used, two distinct zero-based indices of any two of the numbers, whose sum is equal to the target sum. If there are no two numbers, the function should return null.

For example, FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10) should return a Tuple<int, int> containing any of the following pairs of indices:

0 and 3 (or 3 and 0) as 3 + 7 = 10
1 and 5 (or 5 and 1) as 1 + 9 = 10
2 and 4 (or 4 and 2) as 5 + 5 = 10

  
 */

class TwoSum
{
    public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
    {
        //throw new NotImplementedException("Waiting to be implemented.");   

        /* 
         * Performance test with a large list of numbers: Time limit exceeded
         * Hint 1: Nested for loops can iterate over the list and calculate a sum in O(N ^ 2) time. 
         * Hint 2: A dictionary can be used to store pre - calculated values, this may allow a solution with O(N) complexity.
        */

        int idx = 0;
        Dictionary<int, int> dict = list.ToDictionary(x => idx++);

        for (int i = 0; i < dict.Count; i++)
        {
            for (int j = i+1; j < dict.Count; j++)
            {
                if (dict[i] + dict[j] == sum)
                {
                    return Tuple.Create(i, j);
                }
            }
        }

        return null;
    }

    //public static void Main(string[] args)
    //{
    //    Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
    //    if (indices != null)
    //    {
    //        Console.WriteLine(indices.Item1 + " " + indices.Item2);
    //    }
    //}
}
