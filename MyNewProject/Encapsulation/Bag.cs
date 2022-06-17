using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.Encapsulation
{
    class Pen
    {
        int length;
        string color;
        int price;

        public Pen(int length,string color,int price)
        {
            this.length = length;
            this.color = color;
            this.price = price;
        }
        public void DisplayPen()
        {
            Console.Write(length+" "+color+" "+price);
        }

        
    }
    class Nib
    {
        string type;
        Pen mat;

        public Nib(string type,Pen mat)
        {
            this.type = type;
            this.mat = mat;
        }
        public void DisplayNib()
        {
            Console.Write(type+" ");
            
        }
    }

    class Bag
    {
        string brand;
        string color;
        Pen p;

        Bag(string brand,string color,Pen p)
        {
            this.brand = brand;
            this.color = color;
            this.p = p;
        }
        void show()
        {
            Console.Write(brand+" "+color+" ");
            p.DisplayPen();
        }
        static void Main(string[] args)
        {
            Bag b = new Bag("Levis", "Black", new Pen(3, "Blue", 100));
            b.show();
        }

    }
}
