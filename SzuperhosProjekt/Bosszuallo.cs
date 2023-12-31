﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public abstract class Bosszuallo : ISzuperhos
    {
        private double szuperero;
        private bool vanEGyengesege;

        protected Bosszuallo(double szuperero, bool vaEGyengesege)
        {
            this.szuperero = szuperero;
            this.vanEGyengesege = vaEGyengesege;
        }

        public virtual double Szuperero { get => szuperero; set => szuperero = value; }
        public virtual bool VanEGyengesege { get => vanEGyengesege; set => vanEGyengesege = value; }

        public bool LegyoziE(ISzuperhos szuperhos)
        {
            if (!(szuperhos.GetType() == typeof(Batman)))
            {
                if (((Bosszuallo)szuperhos).VanEGyengesege)
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
            return false;
        }

        public double MekkoraAzEreje()
        {
            return this.szuperero;
        }
        public abstract bool MegmentiAVilagot();
        public override string ToString()
        {
            return $"Szupererő: {this.MekkoraAzEreje()}; { (vanEGyengesege? "van gyengesége" : "nincs gyengesége")}";
        }
    }
}
