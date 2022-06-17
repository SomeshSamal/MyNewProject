using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.Inheritance
{
    class Cycle
    {
        protected int tyre = 2;
        protected string type = "Tubeless";
        protected int key = 2;
        
    }
    class Hercules:Cycle
    {
        string brake = "Drum";

        void show()
        {
            Console.WriteLine("tyre "+tyre+"type "+type+key+"Key"+brake);
        }
        static void Main(string[] args)
        {
            Hercules h = new Hercules();
            h.show();
        }
    }
}
