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
                // Approach : Try to mark indexes of elements in place without using extra space.
                int mark;               
                // mark the indexes of numbers as -ve of the number if they exist 
                for(int i=0;i<nums.Length;i++){
                    mark = Math.Abs(nums[i])-1;
                    if(nums[mark]>0){
                        nums[mark] *= -1;
                    }
                }
                // new array to record the missing numbers
                List<int> missingNumbers = new List<int>();
                // all numbers that are greater than 0, i.e missing will be added here.
                for(int i=0;i<nums.Length;i++){
                    if(nums[i]>0){
                        missingNumbers.Add(i+1);
                    }
                }      
                // this approach avoids sorting      
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
                // Approach : 2-Pointer
                // initialize a left and right pointer 
                int lP = 0;
                int rP = nums.Length-1;
                int temp;
                // iterate through the array until the two pointers overlap
                while(lP<rP){
                    // if number at left pointer is non-even and right pointer is non-odd then swap else move the pointers
                    if(nums[lP]%2==0)
                    {
                        lP++;
                    }
                    else if(nums[rP]%2!=0){
                        rP--;
                    }
                    else{
                        temp = nums[lP];
                        nums[lP]=nums[rP];
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
                // Approach: Use a dictionary to store the complement (target - nums[i]) as the key and the index as the value; 
                //for each number, check if it's already in the dictionary, which means we found the pair that sums up to the target,
                // and return their indices.

                Dictionary<int,int> twoSum = new Dictionary<int, int>();
                for(int i=0;i<nums.Length;i++){
                    int diff = target - nums[i];
                    if(twoSum.ContainsKey(nums[i])){
                        return new int[] { twoSum[nums[i]], i };
                    }
                    else{
                        twoSum[diff] = i;
                    }
                }
                return new int[0]; // Placeholder
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
                int maxProduct = 0;
                int windowSize = 3;
                for(int i=0;i<nums.Length-windowSize;i++){
                    int prod = 1;
                    for(int j=i;j<=i+windowSize;j++)
                    {
                        prod *= nums[j];
                    }          

                    if(prod>maxProduct){
                        maxProduct = prod;
                    }
                }
                return maxProduct; // Placeholder
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
                // Write your code here
                return "101010"; // Placeholder
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
                // Write your code here
                return 0; // Placeholder
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
                // Write your code here
                return false; // Placeholder
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
                // Write your code here
                return 0; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
