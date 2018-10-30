using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table3
{
    class Leg : Table
    {
        private Table myTable;
        public Leg() { }

        public void setLeg(Table t)
        {
            this.myTable = t;
        }
        public void ShowData()
        {
            Console.WriteLine("I am a leg!");
            Console.WriteLine("And i belong to table with : ");
            myTable.ShowData();
        }
    }
}
