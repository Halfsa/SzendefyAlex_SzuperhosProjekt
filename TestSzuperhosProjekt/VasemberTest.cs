using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzuperhosProjekt;

namespace TestSzuperhosProjekt
{
    public class VasemberTest
    {
        Vasember vasember;

        public VasemberTest()
        {
            vasember = new Vasember();
        }

        [Fact]
        public void Vasember()
        {
            Assert.Equal(150, vasember.Szuperero);
            Assert.True(vasember.VanEGyengesege);
        }

        [Fact]
        public void KutyutKeszit()
        {
            for (int i = 0; i < 10000; i++)
            {
                double szuperero = vasember.Szuperero;
                vasember.KutyutKeszit();
                Assert.Equal(szuperero + 5, vasember.Szuperero, 5.0);
            }
        }

        [Fact]
        public void MegmentiAVilagot()
        {
            Assert.False(vasember.MegmentiAVilagot());
            vasember.Szuperero = 1000;
            Assert.False(vasember.MegmentiAVilagot());
            vasember.Szuperero = 1001;
            Assert.True(vasember.MegmentiAVilagot());
        }

        [Fact]
        public void String()
        {
            Assert.Equal("Vasember: Szupererő: 150; van gyengesége", vasember.ToString());
            vasember.Szuperero = 200;
            Assert.Equal("Vasember: Szupererő: 200; van gyengesége", vasember.ToString());
            vasember.VanEGyengesege = false;
            Assert.Equal("Vasember: Szupererő: 200; nincs gyengesége", vasember.ToString());
        }

        [Fact]
        public void ImplementsInterfaces()
        {
            Assert.True(vasember is ISzuperhos);
            Assert.True(vasember is IMilliardos);
            Assert.True(vasember is Bosszuallo);
        }
    }
}
