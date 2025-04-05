using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inheritance
{
    class class1
    {
        public void print()
        {
            Console.WriteLine("Hello");
        }
    }
    class class2 :class1
    {
        public void print1()
        {
            Console.WriteLine("Hello Class2");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            class2 c2 = new class2();
            c2.print();
            c2.print1();
            Console.Read();
        }
    }
}

/* Hello
Hello Class2 */

