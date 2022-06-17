using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.Encapsulation
{
    class Car
    {
        private int modelno;
        private string name;
        private string color;
        private int price;

        public int Modelno
        {
            get { return modelno; }
            set { modelno = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

    }

    class CarInfo
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Modelno = 63;
            c.Name = "G-Wagon";
            c.Color = "Black";
            c.Price = 20000000;

            Console.WriteLine(c.Modelno + " " + c.Name + " " + c.Color + " " + c.Price);



        }
    }
}
    
