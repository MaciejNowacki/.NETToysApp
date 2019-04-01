using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    public class Plane: IAccelerate, IRise
    {
        private static int index = 0;
        private int accelerate = 10;
        private int rise = 20;

        public Plane()
        {
            index++;
        }

        public void setAccelerate(int acc)
        {
            this.accelerate = acc;
        }

        public int getAccelerate()
        {
            return this.accelerate;
        }

        public void setRise(int rise)
        {
            this.rise = rise;
        }

        public int getRise()
        {
            return this.rise;
        }

        public override string ToString()
        {
            return "Plane #" + index;
        }
    }
}
