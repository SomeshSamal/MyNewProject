using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.TestPaper2
{
    class AvgEven
    {
        static void Main(string[] args)
        {
            int   count = 0, sum=0,avg=0;
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            for(int i=1;i<=num;i++)
            {
                int evn = num % 10;
                
                if (num % 2 == 0)
                {
                    sum = sum + evn;
                    count++;
                                        
                }
                avg = sum / count;
                              
            }
            Console.WriteLine("Average of even number=" + avg);
        }
        
    }
}
