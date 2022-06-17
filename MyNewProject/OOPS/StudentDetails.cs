using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.OOPS
{
    class StudentDetails
    {
        int id;
        string name;
        int marks;

        public void input(int id, string name, int marks)
        {
            this.id = id;
            this.name = name;
            this.marks = marks;

        }
        void display()
        {
            this.input(101,"Rambo", 365);
            Console.WriteLine(101 + " " +"Rambo" + " " + 365);
        }
        void display1()
        {
            this.input(102, "Alex", 366);
            Console.WriteLine(id + " " + name + " " + marks);
        }
        void display2()
        {
            this.input(103, "Derik", 367);
            Console.WriteLine(id + " " + name + " " + marks);
        }
        static void Main(String[] args)
        {
            StudentDetails s = new StudentDetails();
            s.display();
            s.display1();
            s.display2();
        }
        

    
    }
}
