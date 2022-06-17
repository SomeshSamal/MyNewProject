using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.Array
{
    class Alternative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            Console.WriteLine("Enter array element ");
            for (int i=0;i<a.Length;i++)
            {
                int b = int.Parse(Console.ReadLine());
                a[i] = b;

            }
            Console.WriteLine("Alternate Array elements ");
            //for(int j=0;j<a.Length;j++)
            {
                //int c = int.Parse(Console.ReadLine());
                //a[j] = c;
            }



            for (int i = 0; i < a.Length; i = i + 2)
            {
                Console.WriteLine(a[i]);
            }

            
        }
    }
}
