using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                // Mark indexes by making the corresponding number negative if found
                for(int i = 0; i < nums.Length; i++)
                {
                    int mark = Math.Abs(nums[i]) - 1;
                    if(nums[mark] > 0)
                    {
                        nums[mark] *= -1;
                    }
                }

                // Collect indexes of positive numbers (i.e., missing numbers)
                List<int> missingNumbers = new List<int>();
                for(int i = 0; i < nums.Length; i++)
                {
                    if(nums[i] > 0)
                    {
                        missingNumbers.Add(i + 1);
                    }
                }
                
                return missingNumbers; 
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                // 2-pointer approach: place evens on left, odds on right
                int lP = 0, rP = nums.Length - 1;
                while(lP < rP)
                {
                    if(nums[lP] % 2 == 0) lP++;
                    else if(nums[rP] % 2 != 0) rP--;
                    else
                    {
                        // Swap if left is odd and right is even
                        int temp = nums[lP];
                        nums[lP] = nums[rP];
                        nums[rP] = temp;
                        lP++;
                        rP--;
                    }
                }
                return nums;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                // Use dictionary to track index of complement values
                Dictionary<int, int> twoSum = new Dictionary<int, int>();
                for(int i = 0; i < nums.Length; i++)
                {
                    if(twoSum.ContainsKey(nums[i]))
                    {
                        // Found the pair
                        return new int[] { twoSum[nums[i]], i };
                    }
                    // Store complement
                    twoSum[target - nums[i]] = i;
                }
                return new int[0];
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                // Sliding window to calculate the product of every three consecutive numbers
                int maxProduct = 0;
                int windowSize = 3;
                for(int i = 0; i <= nums.Length - windowSize; i++)
                {
                    int prod = 1;
                    for(int j = i; j < i + windowSize; j++)
                    {
                        prod *= nums[j];
                    }

                    if(prod > maxProduct)
                    {
                        maxProduct = prod;
                    }
                }
                return maxProduct;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                // Convert to binary by repeatedly dividing by 2 and storing remainders
                if(decimalNumber == 0) return "0";

                string binary = "";
                while(decimalNumber > 0)
                {
                    int rem = decimalNumber % 2;
                    binary = rem + binary;
                    decimalNumber /= 2;
                }
                return binary;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                // Binary search for the pivot (minimum element)
                int lP = 0, rP = nums.Length - 1;
                if(nums[lP] < nums[rP])
                {
                    return nums[lP]; // Array is not rotated
                }

                while(lP < rP)
                {
                    int mid = (lP + rP) / 2;

                    if(nums[mid] > nums[rP])
                    {
                        lP = mid + 1;
                    }
                    else
                    {
                        rP = mid;
                    }
                }
                return nums[lP];
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                if(x < 0) return false; // Negative numbers are not palindromes

                int rev = 0, origNum = x;

                while(x > 0)
                {
                    int remainder = x % 10;
                    rev = rev * 10 + remainder;
                    x /= 10;
                }

                return origNum == rev;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                // Recursive Fibonacci calculation
                if(n == 0) return 0;
                if(n == 1) return 1;

                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
