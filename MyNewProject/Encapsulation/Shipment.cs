using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.Encapsulation
{
    class MyDate
    {
        private int dd;
        private int mm;
        private int my;

        public int Dd
        {
            get { return dd; }
            set { dd = value; }
        }
        public int Mm
        {
            get { return mm; }
            set { mm = value; }
        }
        public int Yy
        {
            get { return Yy; }
            set { Yy = value; }
        }

    }

    class Order
    {
        private int id;
        private string name;
        private int price;
        private string city;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
    }
    
    class Shipment
    {
        private int ship_id;
        Order ord;
        MyDate dt;

        public int Ship_Id
        {
            get { return ship_id; }
            set { ship_id = value; }
        }
        public Order Ord
        {
            get { return ord; }
            set { ord = value; }
        }
        public MyDate Dt
        {
            get { return dt; }
            set { dt = value; }
        }

        static void Main(string[] args)
        {
            Shipment s = new Shipment();
            s.ship_id = 123456;
            s.ord = new Order();
            s.ord.Id = 4321;
            s.ord.Name = "Rambo";
            s.ord.Price = 160;
            s.ord.City = "Denver";

            s.Dt = new MyDate();
            s.Dt.Dd = 05;
            s.Dt.Mm = 11;
            s.Dt.Yy = 2022;

            Console.WriteLine(s.Ship_Id+" "+s.Ord.Id+" "+s.ord.Name+" "+s.Ord.Price+" "+s.Ord.City+"  "+s.Dt.Dd+"-"+s.Dt.Mm+"-"+s.Dt.Yy);

        }
    }
}
