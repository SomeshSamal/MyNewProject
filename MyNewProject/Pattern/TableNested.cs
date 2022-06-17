using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.Pattern
{
    class TableNested
    {
        static void Main(String[] args)
        {
            for (int num= 1; num<=5; num++)
            {
                for (int i=1; i<=10;i++)
                {
                    Console.Write(num*i+"  ");
                }
                Console.WriteLine();
            }
        }
    }
}
