using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public abstract class Bosszuallo : ISzuperhos
    {
        private double szuperero;
        private bool vaEGyengesege;

        protected Bosszuallo(double szuperero, bool vaEGyengesege)
        {
            this.szuperero = szuperero;
            this.vaEGyengesege = vaEGyengesege;
        }

        public virtual double Szuperero { get => szuperero; set => szuperero = value; }
        public virtual bool VaEGyengesege { get => vaEGyengesege; set => vaEGyengesege = value; }

        public bool LegyoziE(ISzuperhos szuperhos)
        {
            if (szuperhos.GetType() == typeof(Bosszuallo))
            {
                if (((Bosszuallo)szuperhos).VaEGyengesege)
                {
                    if (this.MekkoraAzEreje()>szuperhos.MekkoraAzEreje())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else if (szuperhos.GetType() == typeof(Batman))
            {
                if (this.MekkoraAzEreje() >= szuperhos.MekkoraAzEreje()*2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new Exception("Nincs ilyen szuperhős");
            }
        }

        public double MekkoraAzEreje()
        {
            return this.szuperero;
        }
        public abstract bool MegmentiAVilagot();
        public override string ToString()
        {
            return $"Szupererő: {this.MekkoraAzEreje()}; { (vaEGyengesege? "van gyengesége" : "nincs gyengesége")}";
        }
    }
}
