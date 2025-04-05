using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interface_inheritance
{
    interface result
    {
        void grade();
    }
    class sem4 : result
    {
        public void grade()
        {
            Console.WriteLine("C");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            sem4 s = new sem4();
            s.grade();
            Console.Read();
        }
    }
}

/* C */

