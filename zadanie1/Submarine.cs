using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Submarine: IAccelerate, IDrive, IRise
    {
        private int accelerate = 10;
        private int drive = 20;
        private int rise = 30;
        private static int index = 0;

        public Submarine() {
            index++;
        }

        public int getAccelerate() {
            return this.accelerate;
        }

        public void setAccelerate(int change) {
            this.accelerate = change;
        }

        public int getDrive() {
            return this.drive;
        }

        public void setDrive(int change) {
            this.drive = change;
        }

        public int getRise() {
            return this.rise;
        }

        public void setRise(int change) {
            this.rise = change;
        }

        public override string ToString()
        {
            return "Submarine #" + index;
        }
    }
}
