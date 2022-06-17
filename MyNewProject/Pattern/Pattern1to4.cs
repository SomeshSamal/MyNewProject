using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.Pattern
{
    class Pattern1to4
    {
        static void Main(String[] args)
        {
            for (int i= 1; i<=4;i++)
            {
                for (int j=1;j<=i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
