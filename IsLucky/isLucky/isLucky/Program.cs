using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsLucky
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Class1 test = new Class1();

            if (test.IsLucky("239017") == true)
                Console.WriteLine("True!!! Ticket number is lucky.");
            else
                Console.WriteLine("False!!! Ticket number is unlucky.");

        }
    }
}
