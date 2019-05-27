using System;
/*
 * Given an unsorted integer array, find the smallest missing positive integer.

Example 1:

Input: [1,2,0]
Output: 3
Example 2:

Input: [3,4,-1,1]
Output: 2
Example 3:

Input: [7,8,9,11,12]
Output: 1
Note:

Your algorithm should run in O(n) time and uses constant extra space.
 */
namespace FirstMissingPositive
{
    class Program
    {
        static int FirstMissingPositive(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 1;
            }

            // Use the array to track whether those numbers are in the nums input.
            int[] arr = new int[nums.Length * 1000];
            arr[0] = 1;

            int val = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    // Ignore all the number greather than this size.
                    if (nums[i] > 1000 * nums.Length)
                    {
                        continue;
                    }

                    // Set 1 to the array possition.
                    if (nums[i] > val)
                    {
                        if (arr[nums[i]] == 0)
                        {
                            arr[nums[i]] = 1;
                        }
                    }

                    if (nums[i] == val)
                    {
                        val++;
                    }

                    while (val < arr.Length && arr[val] == 1)
                    {
                        val++;
                    }

                }
            }

            return val;
        }

        static void Main(string[] args)
        {
            // { 2, 1, 0 }
            // ans: 3

            // { 7, 8, 10, 12 }
            // ans: 1

            // { 3, 4, -1, 1 }
            // ans: 2

            // { 2147483647 }
            // ans: 1

            // { 1000002, -1000002, 1 }
            // ans: 2

            Console.WriteLine(FirstMissingPositive(new int[] { 3, 4, -1, 1 }));
        }
    }
}
