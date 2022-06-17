using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.Array
{
    class SortInteger
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter array element");

            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for(int j=0;j<a.Length; j++)
            {
                Console.WriteLine(a[j]);
            }
            
        }
    }
}
