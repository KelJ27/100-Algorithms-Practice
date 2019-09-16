using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsLucky
{
    class Class1
    {
        public bool IsLucky(string ticketNum)
        {
            int totalNum;
            int length = ticketNum.Length;
            int i = 0;
            int j = 0;

            length /= 2;
            Int32.TryParse(ticketNum, out totalNum);
            var digits = totalNum.ToString().Select(t => int.Parse(t.ToString())).ToArray();


            int[] firstHalf = new int[length];
            int[] secondHalf = new int[length];


            for (i = 0; i < length; i++)
            {
                firstHalf[i] = digits[i];
            }

            while (i < ticketNum.Length)
            {
                secondHalf[j] = digits[i];
                j++;
                i++;
            }

            if (firstHalf.Sum() == secondHalf.Sum())
                return true;
            else
                return false;

        }
    }
}
