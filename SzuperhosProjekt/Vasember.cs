using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Vasember : Bosszuallo, IMilliardos
    {
        private Random RND = new Random();

        public Vasember() : base(150,true)
        {
            
        }

        public Vasember(double szuperero, bool vaEGyengesege) : base(szuperero, vaEGyengesege)
        {
        }

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
       

       
    }
}
