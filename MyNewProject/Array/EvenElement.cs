using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.Array
{
    class EvenElement
    {
        static void Main(string[] args)
        {
            int[] a= { 1, 2, 3, 4, 5, 6 };

            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2==0)
                {
                    Console.WriteLine(" "+a[i]);
                }
            }
        }
    }
}
