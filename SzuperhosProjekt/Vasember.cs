using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Vasember : Bosszuallo , Milliardos
    {
        public Vasember(double szuperero, bool vaEGyengesege) : base(szuperero, vaEGyengesege)
        {
            szuperero = 150;
            vaEGyengesege = true;
        }

        public void KutyutKeszit()
        {
            throw new NotImplementedException();
        }

        public override bool MegmentiAVilagot()
        {
            throw new NotImplementedException();
        }
    }
}
