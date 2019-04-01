using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    public class Car: IAccelerate
    {
        private int accelerate = 10;
        private static int index = 0;

        public Car()
        {
            index++;
        }

        public void setAccelerate(int change)
        {
            this.accelerate = change;
        }

        public int getAccelerate()
        {
            return this.accelerate;
        }

        public override string ToString()
        {
            return "Car #"+ index;
        }
    }
}
