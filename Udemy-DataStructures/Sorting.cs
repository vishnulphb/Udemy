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

        public static void SelectionSort()
        {
            Console.WriteLine("Enter the numbers for Selection sort separated by commas:");
            string numbers = Console.ReadLine();
            int[] nums = Array.ConvertAll(numbers.Split(','), Int32.Parse);

            for (int i = 0; i <= nums.Length-1; i++)
            {
                int minLocation = i;

                for (int j = i+1; j <= nums.Length-1; j++)
                {
                    if (nums[j] < nums[minLocation])
                    {
                        minLocation = j;
                        
                    }
                }

                int temp = nums[minLocation];
                nums[minLocation] = nums[i];
                nums[i] = temp;
            }
            foreach  (var num in nums)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}


/*
 In Place vs Not IN Place sorting
 Basically if we are using only a temporary variable to swap the elements, which means not much extra memory is used to perform the sorting.This sorting is called IN Place.
 else if we use memory proporionate to the array which has to be sorted. that kind of sorting is called NOT IN PLACE SORTING. For e.g if I create a new array and place the smaller elements in the
 beginning of the new array and then finally returning that array. Its a waste of lot of memory. 
  */