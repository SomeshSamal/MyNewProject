using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.OOPS
{
    class OverloadingStatic
    {
        static void num(int a,int b)
        {
            Console.WriteLine("Addition="+(a+b));
        }
       static void num(float a,int b)
        {
            Console.WriteLine("Substraction="+(a-b));
        }

        static void Main(string[] args)
        {
            OverloadingStatic.num(20, 30);
            OverloadingStatic.num(40.12f, 50);
        }
    }
}
