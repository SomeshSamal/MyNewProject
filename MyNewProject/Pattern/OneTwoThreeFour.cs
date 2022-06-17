using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.Pattern
{
    class OneTwoThreeFour
    {
        static void Main(String[] args)
        {
            for(int i=1;i>=0;i++)
            {
                for(int j=1;j>=i;j++)
                {
                    Console.Write("");
                }
                Console.WriteLine();
            }
        }
    }
}
