using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table3
{
    class Program
    {
        static void Main(string[] args)
        {
            //single table

            Table t = new Table(80, 120);
            Leg l = new Leg();
            Random rnd = new Random();
            t.addLeg(l);
            l.ShowData();
            Console.WriteLine();

            // array of tables
            Table[] tab = new Table[10];

            for (int i = 1; i < tab.Length; i++)
            {

                if (i % 2 == 0 && i == 1)
                {
                    tab[i - 1] = new Table(rnd.Next(50, 201), rnd.Next(50, 201));
                    tab[i - 1].ShowData();
                }
                else
                {
                    tab[i - 1] = new CoffeeTable(rnd.Next(40, 121), rnd.Next(40, 121));
                    tab[i - 1].ShowData();
                }
            }


            Console.Read();

        }
    }
}
