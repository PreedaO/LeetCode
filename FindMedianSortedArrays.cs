using System;

namespace FindMedianSortedArrays
{
    class Program
    {
        static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] merged = new int[nums1.Length + nums2.Length];

            int i = 0;
            int p = 0;
            int q = 0;

            while (p < nums1.Length && q < nums2.Length)
            {
                if (nums1[p] <= nums2[q])
                {
                    merged[i] = nums1[p];
                    p++;
                }
                else if (nums1[p] > nums2[q])
                {
                    merged[i] = nums2[q];
                    q++;
                }
                i++;
            }

            while (p < nums1.Length)
            {
                merged[i] = nums1[p];
                i++;
                p++;
            }

            while (q < nums2.Length)
            {
                merged[i] = nums2[q];
                i++;
                q++;
            }

            double result = 0.0;
            int midPoint = merged.Length / 2;
            if (merged.Length % 2 == 0)
            {
                result = (merged[midPoint] + merged[midPoint - 1]) / 2.0;
            }
            else
            {
                result = merged[midPoint];
            }

            return result;
        }

        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 3 };
            int[] nums2 = new int[] { 2 };
            Console.WriteLine("The median is {0:0.0}", FindMedianSortedArrays(nums1, nums2));

            int[] nums3 = new int[] { 1, 2 };
            int[] nums4 = new int[] { 3, 4 };
            Console.WriteLine("The median is {0:0.0}", FindMedianSortedArrays(nums3, nums4));
        }
    }
}
