using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.Pattern
{
    class AutomorphicOrNot
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = int.Parse(Console.ReadLine());

            int temp = num;

            int sq = num * num;

            int count = 0;
            while(num>0)
            {
                count++;
                num = num / 10;
            }
            Console.WriteLine(count);
            int power = 1;
            while(count>0)
            {
                power = power * 10;
                count--;
            }
            Console.WriteLine(power);
            num = temp;

            int end = sq % power;

            if(num==end)
                
            
            {
                Console.WriteLine("Automurphic Number");

            }
            else
            {
                Console.WriteLine("Not Automorphic Number");
            }
               
        }
    }
}
