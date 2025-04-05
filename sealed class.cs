using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sealedclass
{
    sealed class class1
    {
        public void print()
        {
            Console.WriteLine("Hello");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            class1 c2 = new class1();
            c2.print();
            Console.Read();
        }
    }
}

/* Hello */

