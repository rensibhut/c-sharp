using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace method
{
    class afternoon
    {
        public void method1(int i,int j)
        {
            Console.WriteLine(i + j);
        }
        public void method1(string res,string grade)
        {
            Console.WriteLine(res + "," + grade);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            afternoon a = new afternoon();
            a.method1(10, 20);
            a.method1("Pass", "A");
            Console.Read();
        }
    }
}

/* 30
Pass, A */

