using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudio
{
    [TestFixture]
    class MyTestCase
    {
        [TestCase]
        public void Add()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(77, math.Add(32, 45));
        }

        [TestCase]
        public void Sub()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(-13, math.Sub(32, 45));
        }

        [TestCase]
        public void Mul()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(12, math.Mul(-3, -4));
        }

        [TestCase]
        public void Div()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(12, math.Div(-48, -4));
        }
    }
}
