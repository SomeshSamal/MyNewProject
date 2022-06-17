using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.TestPaper2
{
    class Question_7
    {
        static void Main(String[] args)
        {
            for(int i=6;i>=1;i--)
            {
                for(int k=4;k>=i;k--)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
