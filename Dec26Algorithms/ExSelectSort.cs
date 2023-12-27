using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec26Algorithms
{
    internal class ExSelectSort
    {
        static void SelectSort(int[] arr)
        {
            int n = arr.Length;
            int temp;
            for (int i = 0; i < n; i++)
            {
                int min_index = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_index])
                    {
                        min_index = j;
                    }
                    temp = arr[min_index];
                    arr[min_index] = arr[i];
                    arr[i] = temp;




                }
            }
        }
        static void PrintSelectSort(int[] arr)
        {
            int n = arr.Length;
            for(int i = 0;i<n;i++)
            
                Console.WriteLine(arr[i]+" ");
                Console.WriteLine("\n");

            
          
        }
            static void Main(string[] args)
            {
                
            int[] nums = { 4, 2, 1, 8, 3 };
            Console.WriteLine("Original Array\n");
            PrintSelectSort(nums);
            SelectSort(nums);
            Console.WriteLine("\nSorted Array\n");
            PrintSelectSort(nums);
        }
        }
    }

