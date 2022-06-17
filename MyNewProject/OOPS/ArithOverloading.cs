using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.OOPS
{
    class ArithOverloading
    {
        public void Cal()
        {
            Console.WriteLine("Cal");
        }
        public void Cal(int a,int b)
       
        {
            Console.WriteLine("Addition" +"="+ (a + b));
        }
       public void Cal(double a,int b)
        {
            Console.WriteLine("Substraction" +"="+ (a - b));
        }
        public void Cal(float a,int b)
        {
            Console.WriteLine("Multiplication" +"="+ (a * b));
        }
        public void Cal(float a,float b)
        {
            Console.WriteLine("Division" +"="+ (a / b));
        }
        static void Main(String[] args)
        {
            ArithOverloading r = new ArithOverloading();
            r.Cal(10, 20);
            r.Cal(9.5f, 9);
            r.Cal(100f, 5.6f);
            r.Cal(20.4, 5);
        }
    }
}
