using System;

namespace Seggregate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 5, 5, 8, 9, 3, 2, 1, 8, 9, 6, 5,4,0,0,2 };            
            int target = 4;
            Segregate(nums, target);
            foreach (int ctr in nums)
            {
                Console.WriteLine(ctr);
            }
            Console.ReadLine();

        }

        private static void Segregate(int[] nums , int target)
        {
            int counter = 0;
            int pivot = 0;
            int targetIndex = 0;
            while (counter < nums.Length)
            {
                if(pivot == 0 && nums[counter] > target)
                {
                    pivot = counter;
                }
                else if(pivot > 0 && nums[counter] < target)
                {
                    swapNumbers(nums, counter, pivot);
                    pivot++;
                }

                if (nums[counter] == target)
                    targetIndex = counter;

                counter++;
            }

            swapNumbers(nums, pivot, targetIndex);
            
        }

        private static void swapNumbers (int[] nums, int counter, int pivot)
        {
            var sum = nums[counter] + nums[pivot];
            nums[pivot] = sum - nums[pivot];
            nums[counter] = sum - nums[counter];
        }
    }
}
