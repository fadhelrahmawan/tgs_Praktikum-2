using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1184064
{
    public class Motor
    {
        private int hargaMot = 0;

        public void HargaMot(int buy)
        {

            hargaMot = Convert.ToInt32(buy * 12000000);

        }
        public void output() //method untuk menampilkan hasil dari proses method HargaMot
        {
            Console.WriteLine("Total Harganya : " + hargaMot);
        }

    }
}