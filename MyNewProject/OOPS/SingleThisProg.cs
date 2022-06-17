using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.OOPS
{
    class SingleThisProg
    {
        String name;
        int roll_no;
        String gender;
        int section;

        void input(string name,int roll_no,string gender,int section)
        {
            this.name = name;
            this.roll_no = roll_no;
            this.gender = gender;
            this.section = section;
        }
        void display()
        {
            this.input("Rambo", 36, "Male", 8);
            Console.WriteLine(name + " " + roll_no + " " + gender + " " + section);
        }
        static void Main(String[] args)
        {
            SingleThisProg s = new SingleThisProg();
            s.display();
        }

    }
}
