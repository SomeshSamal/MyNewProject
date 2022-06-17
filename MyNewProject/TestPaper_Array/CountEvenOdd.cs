using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.TestPaper_Array
{
    class CountEvenOdd
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter Number:");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                
            }
            
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]%2==0)
                {
                    Console.WriteLine("Even Elements:"+a[i]);
                }
                
            }
            

            
        }
    }
}
