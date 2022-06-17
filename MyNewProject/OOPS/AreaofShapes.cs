using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.OOPS
{
    class AreaofShapes
    {
        public void Area()
        {
            Console.WriteLine("Area");
        }
        public void Area(float r)
        {
            Console.WriteLine("Circle="+3.14f*r*r);
        }
        public void Area(int l,int b)
        {
            Console.WriteLine("Rectangle="+l*b);
        }
        public void Area(float b,int h)
        {
            Console.WriteLine("Triangle="+(b*h)/2);
        }
        public void Area(int side)
        {
            Console.WriteLine("Square="+side*side);
        }
        static void Main(string[] args)
        {
            AreaofShapes s = new AreaofShapes();
            s.Area(3.14f);
            s.Area(10, 5);
            s.Area(15.5f, 8);
            s.Area(4);
        }
            
    }
}
