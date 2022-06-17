using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.TestPaper2
{
    class Question_1
    {
        static void Main(String[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if(i%5==0 && i%10==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
