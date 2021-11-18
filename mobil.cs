using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1184064
{
    public class Mobil
    {
        private int hargaMob = 0;
        public void HargaMie(int buy)
        {

            hargaMob = Convert.ToInt32(buy * 250000000);

        }
        public void output()
        {
            Console.WriteLine("Total Harganya : " + hargaMob);
        }

    }
}
