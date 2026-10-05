using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class29
    {

        public static  void Main()

        {


            Console.WriteLine("Name : shreeya vekariya");
            Console.WriteLine("Enrollment No : 24SOECE11050 ");

            //int[] arr = { 30, 50, 60, 70, 60, 40 };
            //for (int i = 0; i < arr.Length; i++)

            int[] arr = new int[5];
            for ( int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter elements : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + "");
            }
            Console.Read();
        }
    }
}
