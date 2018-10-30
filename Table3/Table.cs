using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table3
{
    class Table
    {
        protected float width, height;
        protected Leg myLeg;

        public Table()
        {
        }
        public Table(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        public void addLeg(Leg l)
        {
            this.myLeg = l;
            myLeg.setLeg(this);
        }

        public virtual void ShowData()
        {
            Console.WriteLine("Width: {0}, Heigth: {1}", width, height);
        }
    }
}
