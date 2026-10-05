//Reverse the array without using another array
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class25
    {
        public static void Reverse_Array()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int n = arr.Length;

            int start = 0;
            int end = n - 1;

            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }

            Console.WriteLine("Reversed Array : [ " + string.Join(" , ", arr) + " ]");
            Console.ReadLine();
        }
    }
}