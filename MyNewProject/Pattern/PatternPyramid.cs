using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.Pattern
{
    class PatternPyramid
    {
        static void Main(String[] args)
        {
            for(int i=1;i<=6;i++)
            {
                for(int k=4;k>=i;k--)
                {
                    Console.Write(" ");
                }
                for (int j=1;j<=i;j++)
                {
                    Console.Write("* ");
                }

                
                Console.WriteLine();
            }
           
                
         
            
            
        }
    }
}
