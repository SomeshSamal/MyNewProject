using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.Pattern
{
    class Pattern4321
    {
        static void Main(String[] args)
        {
            for(int i=4;i>=1;i--)
            {
                for(int j=i;j>=1;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
