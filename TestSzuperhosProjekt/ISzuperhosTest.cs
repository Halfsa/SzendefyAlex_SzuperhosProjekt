using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSzuperhosProjekt
{
    public class ISzuperhosTest
    {
        [Fact]
        public void InterfaceMethods()
        {
            Type type = typeof(ISzuperhos);
            Assert.True(type.IsInterface);
            Assert.True(type.GetMethod("LegyoziE").IsAbstract);
            Assert.True(type.GetMethod("MekkoraAzEreje").IsAbstract);
        }
    }
}

