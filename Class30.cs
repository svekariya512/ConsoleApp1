using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class30
    {
        public static void Main()
        {
            Console.WriteLine("Name : shreeya vekariya");
            Console.WriteLine("Enrollment No : 24SOECE11050 ");

            int[] arr = new int[5];
            
            for ( int i = 0; i < 5; i++)
            {
                Console.Write("Enter elements" + i + ":");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Array.Sort(arr);
            Console.WriteLine("Sorted Array : ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                
            }


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i] + "");
            }
            Console.Read();
        }
    }
}