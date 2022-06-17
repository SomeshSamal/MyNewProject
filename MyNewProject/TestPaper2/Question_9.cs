using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.TestPaper2
{
    class Question_9
    {
        static void Main(String[] args)
        {
            for(int i=5;i>0;i--)
            {
                int mysteryInt = 100;
                mysteryInt -= i;
                Console.WriteLine(mysteryInt);
            }
        }
    }
}
