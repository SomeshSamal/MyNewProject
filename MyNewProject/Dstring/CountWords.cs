using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.Dstring
{
    class CountWords
    {
        static void Main(string[] args)
        {
            int a = 0, count = 1;
            string str = "Hello World";


            String[] s = str.Split(" ");

            Console.WriteLine("Number of word="+s.Length);
        }
    }
}
