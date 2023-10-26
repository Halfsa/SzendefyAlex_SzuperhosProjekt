using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzuperhosProjekt;

namespace TestSzuperhosProjekt
{
    public class BosszualloTest
    {
        private class BosszualloMock : Bosszuallo
        {
            public BosszualloMock() : base(300, true)
            {
            }

            public override bool MegmentiAVilagot()
            {
                return false;
            }
        }

        Bosszuallo bosszuallo;
        public BosszualloTest()
        {
            bosszuallo = new BosszualloMock();
        }

        [Fact]
        public void GetSzuperero()
        {
            Assert.Equal(300, bosszuallo.Szuperero);
        }

        [Fact]
        public void SetSzuperero()
        {
            Assert.Equal(300, bosszuallo.Szuperero);
            bosszuallo.Szuperero = 200;
            Assert.Equal(200, bosszuallo.Szuperero);
        }

        [Fact]
        public void GetVanEGyengesege()
        {
            Assert.True(bosszuallo.VanEGyengesege);
        }

        [Fact]
        public void SetVanEGyengesege()
        {
            Assert.True(bosszuallo.VanEGyengesege);
            bosszuallo.VanEGyengesege = false;
            Assert.False(bosszuallo.VanEGyengesege);
        }

        [Fact]
        public void LegyoziEBosszuallo()
        {
            BosszualloMock other = new BosszualloMock();
            Assert.False(bosszuallo.LegyoziE(other));
            other.Szuperero = 299;
            Assert.True(bosszuallo.LegyoziE(other));
            other.VanEGyengesege = false; 
            Assert.False(bosszuallo.LegyoziE(other));
            Batman batman = new Batman();
            Assert.False(bosszuallo.LegyoziE(batman));
            bosszuallo.Szuperero = 400;
            Assert.True(bosszuallo.LegyoziE(batman));
            bosszuallo.Szuperero = 399;
            Assert.False(bosszuallo.LegyoziE(batman));
        }

        [Fact]
        public void LegyoziEBatman()
        {
            Batman batman = new Batman();
            Assert.False(bosszuallo.LegyoziE(batman));
            bosszuallo.Szuperero = 400;
            Assert.True(bosszuallo.LegyoziE(batman));
            bosszuallo.Szuperero = 399;
            Assert.False(bosszuallo.LegyoziE(batman));
        }

        [Fact]
        public void MekkoraAzEreje()
        {
            Assert.Equal(bosszuallo.Szuperero, bosszuallo.MekkoraAzEreje());
        }

        [Fact]
        public void MegmentiAVilagot()
        {
            var method = typeof(Bosszuallo).GetMethod("MegmentiAVilagot");
            Assert.True(method.IsAbstract);
        }

        [Fact]
        public void String()
        {
            Assert.Equal("Szupererő: 300; van gyengesége", bosszuallo.ToString());
            bosszuallo.Szuperero = 200;
            Assert.Equal("Szupererő: 200; van gyengesége", bosszuallo.ToString());
            bosszuallo.VanEGyengesege = false;
            Assert.Equal("Szupererő: 200; nincs gyengesége", bosszuallo.ToString());
        }
        [Fact]
        public void ImplementsInterfaces()
        {
            Assert.True(bosszuallo is ISzuperhos);
        }
    }
}
