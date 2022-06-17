using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.TestPaper_Array
{
    class Refill
    {
        private string ink;
        private int length;

        public string Ink
        {
            get { return ink; }
            set { ink = value; }
        }
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        
    }

    class Nib
    {
        private string mtype;
        private float width;

        public string Mtype
        {
            get { return mtype; }
            set { mtype = value; }
        }
        public float Width
        {
            get { return width; }
            set { width = value; }
        }
    }

    class Pen
    {
        private int cap_length;
        private string brand;
        Refill refl;
        Nib tip;

        public int Cap_Length
        {
            get { return cap_length; }
            set { cap_length = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public Refill Refl
        {
            get { return refl; }
            set { refl= value; }
        }
        public Nib Tip
        {
            get { return tip; }
            set { tip = value; }
        }
        static void Main(string[] args)
        {
            Pen p = new Pen();
            p.cap_length = 2;
            p.brand = "Cello";

            p.refl = new Refill();
            p.refl.Ink = "Blue";
            p.refl.Length = 1;

            p.tip = new Nib();
            p.tip.Mtype = "Stainless";
            p.tip.Width = 0.2f;

            Console.WriteLine("Cap Length="+p.Cap_Length+","+"Pen Brand="+p.Brand+","+"Ink Type="+p.Refl.Ink+","+"Refill Legth="+p.Refl.Length+","+"Material Type="+p.Tip.Mtype+","+"Tip Width="+p.Tip.Width);

        }
            
            


    }
}
