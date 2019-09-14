using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsLucky
{
    class Class1
    {
        public bool IsLucky(int ticketNum)
        {
            int[] outarry = Array.ConvertAll(ticketNum.ToString().ToArray(), x => (int)x - 48);



            Console.WriteLine(outarry[0]);
            Console.ReadKey();

            return true;
        }
    }
}
