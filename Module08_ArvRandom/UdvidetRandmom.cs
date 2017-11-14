using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08_ArvRandom
{
    class UdvidetRandmom : System.Random
    {
        private static Random rnd = new Random();
        public bool NextBool()
        {
            int j = rnd.Next(1, 1002);
            if (j < 500)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
