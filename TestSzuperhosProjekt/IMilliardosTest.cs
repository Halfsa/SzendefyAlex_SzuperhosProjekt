using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestSzuperhosProjekt
{
    public class IMilliardosTest
    {
        [Fact]
        public void InterfaceMethods()
        {
            Type type = typeof(IMilliardos);
            Assert.True(type.IsInterface);
            Assert.True(type.GetMethod("KutyutKeszit").IsAbstract);
        }
    }
}
