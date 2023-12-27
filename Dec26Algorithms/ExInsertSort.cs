using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec26Algorithms
{
    internal class ExInsertSort
    {
       static void Isort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int key = arr[i];// key is 5
                int j = i - 1;// -1
                //move elements of arr[o --- to i-1] that is greater than a key, to one position ahead of current position 
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1; //j--   --j
                }
                arr[j + 1] = key;//5 is pushed to in place of 4 that is 2nd position
            }
                
            }
        static void PrintInsertSortArr(int[] arr)
        {
            int n = arr.Length;
            for(int i = 0; i<n; i++)
            {
                Console.Write(arr[i]+ " ");
                Console.Write(" \n");
            }
        }
        static void Main(string[] args)
        {
            int[] nums = { 5, 6, 4, 2, 1 };
            PrintInsertSortArr(nums);
            Console.WriteLine("after Insert Sort");
            Isort(nums);
            PrintInsertSortArr(nums);
        }

        }
    }

