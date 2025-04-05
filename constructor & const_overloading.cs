using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructor
{
    class afternoon
    {
        public void afternnon(int i, int j)
        {
            Console.WriteLine(i + j);
        }
        public afternoon(string res, string grade)
        {
            Console.WriteLine(res + "," + grade);
        }
}
    internal class Program
    {
        static void Main(string[] args)
        {
            afternoon a = new afternoon("10", "20");
            afternoon a1 = new afternoon("Pass", "B");
            Console.Read();
        }
    }
}


/* 10,20
Pass, B */
