using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Vasember : Bosszuallo, Milliardos
    {
        private Random RND = new Random();

       

        public void KutyutKeszit()
        {
            base.Szuperero += RND.NextDouble()*10;
        }

        public override bool MegmentiAVilagot()
        {
            if (Szuperero >1000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return "Vasember: "+base.ToString();
        }
        public Vasember()
        {
            base.Szuperero = 0;
            base.VaEGyengesege = true;
        }
    }
}
