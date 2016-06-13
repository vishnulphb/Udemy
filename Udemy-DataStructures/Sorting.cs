using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_DataStructures
{
    class Sorting
    {
        public static void InsertionSort()
        {
            Console.WriteLine("Enter the numbers for insertion sort separated by commas:");
            string numbers = Console.ReadLine();
            int[] nums = Array.ConvertAll(numbers.Split(','), Int32.Parse);

            for (int i = 0; i <= nums.Length-1; i++)
            {
                int j = i - 1;
                int current = nums[i];

                while (j >= 0 && nums[j] > current)
                {
                    nums[j + 1] = nums[j];
                    j = j - 1;
                }
                nums[j + 1] = current;
            }


            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
