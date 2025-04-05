using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace absstractclass
{
    abstract class class1
    {
        public abstract void print();
    }
    class class2 : class1
    {
        public override void print()
        {
            Console.WriteLine("Abstract");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            class2 c2 = new class2();
            c2.print();
            Console.Read();
        }
    }
}

/* Abstract */

