using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.Loops
{
    class WhileLoop
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            int reverse = 0;
            int temp = num;
            while(num>0)
            {
                int r = num % 10;
                reverse = reverse + r * r * r;
                num = num / 10;
            }
            if (temp == reverse)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not Armstrong number");
            }
           
        }
    }
}
