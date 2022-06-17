using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.Inheritance
{
    class Vehicle
    {
        public virtual void run()
        {
            Console.WriteLine("Vehicle is running");
        }
          
    }
    class Car:Vehicle
    {
        public override void run()
        {
            Console.WriteLine("Car is running");
        }
    }
    class Truck : Vehicle
    {
        public override void run()
        {
            Console.WriteLine("Truck is running");
        }
    }

    class Transport
    {
        static void Main(string[] args)
        {
            Vehicle v = new Car();
            v.run();
            Vehicle v1 = new Truck();
            v1.run();

            
            

        }
    }
}
