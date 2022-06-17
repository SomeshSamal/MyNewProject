using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.Array
{
    class TwoDArraySum
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2] { { 1, 2 },{4,5 } };
            int[,] b = new int[2, 2] { { 3, 2 }, { 6, 5} };

            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);i++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
