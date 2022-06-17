using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.Array
{
    class SumOfPrime
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter array Size");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            Console.WriteLine("Enter Number");
            for (int j = 0; j < a.Length; j++) ;
            {
                a[n] = int.Parse(Console.ReadLine());
                sum = sum + a[n];

            }
            Console.WriteLine("Sum of numbers"+sum);


            
            
           
            
            
                
            

            
            

            
        }
    }
}
