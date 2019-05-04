using System;

/*
Implement function CountNumbers that accepts a sorted array of unique integers and, 
efficiently with respect to time used, counts the number of array elements that are less than the parameter lessThan.

For example, SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4) should return 2 because there are two array elements less than 4.
*/

public class SortedSearch
{

    //if (sortedArray.Length ==0)
    //    return 0;

    //int count = 0;

    //foreach (var num in sortedArray)
    //{            
    //    if (lessThan.CompareTo(num) <= 0) continue;
    //    else
    //        count++;
    //}

    //return count;

    public static int CountNumbers(int[] sortedArray, int lessThan)
    {        
        int begin = 0;
        int end = sortedArray.Length - 1;
        int mid = 0;
        while (begin <= end)
        {
            mid = (begin + end) / 2;
            if (sortedArray[mid] < lessThan)
            {
                if (mid < sortedArray.Length - 1 && sortedArray[mid + 1] < lessThan)
                {   
                    begin = mid + 1;
                    continue;
                }
                else
                    return mid + 1;
            }
            end = mid - 1;

        }
        return 0;

        //throw new NotImplementedException("Waiting to be implemented.");
    }

    //public static void Main(string[] args)
    //{
    //    Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));
    //}
}