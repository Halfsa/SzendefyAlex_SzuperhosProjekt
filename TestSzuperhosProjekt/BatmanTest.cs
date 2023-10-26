using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzuperhosProjekt;

namespace TestSzuperhosProjekt
{
    public class BatmanTest
    {
        private class SzuperhosMock : ISzuperhos
        {
            public bool LegyoziE(ISzuperhos szuperhos)
            {
                return false;
            }

            public double MekkoraAzEreje()
            {
                return 300;
            }
        }


        Batman batman;
        public BatmanTest() {
            batman = new Batman();
        }

        [Fact]
        public void Batman()
        {
            Assert.Equal(200, batman.MekkoraAzEreje());
        }

        [Fact]
        public void KutyutKeszit()
        {
            batman.KutyutKeszit();
            Assert.Equal(300, batman.MekkoraAzEreje());
        }

        [Fact]
        public void LegyoziE()
        {
            Assert.False(batman.LegyoziE(new SzuperhosMock()));
            batman.KutyutKeszit();
            batman.KutyutKeszit();
            batman.KutyutKeszit(); 
            batman.KutyutKeszit();
            Assert.False(batman.LegyoziE(new SzuperhosMock()));
            batman.KutyutKeszit();
            Assert.True(batman.LegyoziE(new SzuperhosMock()));
        }

        [Fact]
        public void MekkoraAzEreje()
        {
            Assert.Equal(200, batman.MekkoraAzEreje());
            batman.KutyutKeszit();
            Assert.Equal(300, batman.MekkoraAzEreje());
        }

        [Fact]
        public void String()
        {
            Assert.Equal("Batman: leleményesség: 100", batman.ToString());
            batman.KutyutKeszit();
            Assert.Equal("Batman: leleményesség: 150", batman.ToString());
        }

        [Fact]
        public void ImplementsInterfaces()
        {
            Assert.True(batman is ISzuperhos);
            Assert.True(batman is IMilliardos);
            Assert.False(batman is Bosszuallo);
        }
    }
}
