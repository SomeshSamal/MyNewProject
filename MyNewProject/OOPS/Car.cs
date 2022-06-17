using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.OOPS
{
    class Car
    {
        int carnum;
        String carname;
        String carcolor;
        int carprice;

        public void input()
        {
            carnum = 63;
            carname = "G-Wagon";
            carcolor = "Black";
            carprice = 20000000;
        }
        void display()
        {
            Console.WriteLine(carnum + " " + carname + " " + carcolor + " " + carprice);
        }
        static void Main(String[] args)
        {
            Car c =new Car();
            c.input();
            c.display();
              
        }

    }
}
