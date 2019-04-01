using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    public class Computer
    {
        private static int index = 0;

        public Computer()
        {
            index++;
        }

        public override string ToString()
        {
            return "Computer #" + index;
        }
    }
}
