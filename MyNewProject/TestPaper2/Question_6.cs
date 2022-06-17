using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.TestPaper2
{
    class Question_6
    {
        static void Main(String[] args)
        {
            for(int i=1;i<=4;i++)
            {
                for (int j = 1; j >= i; j--)
                {
                    Console.Write(" ");
                }
                    for (int k = 1;k<=i; k++)
                    {
                        Console.Write("i");
                    }
                    Console.WriteLine();
                }
            }
        }
    }

