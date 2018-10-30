using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table3
{
    class CoffeeTable : Table
    {
        public CoffeeTable(float width, float height) : base(width, height)
        {
            this.width = width;
            this.height = height;
        }
        public override void ShowData()
        {
            Console.WriteLine("(Coffee table) Width: {0}, Heigth: {1}", width, height);
        }
    }
}
