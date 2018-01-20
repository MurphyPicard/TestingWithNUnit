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

        [TestCase]
        public void AddOne()
        {
            var math = new NewMath();
            Assert.AreEqual(33, math.AddOne(32));
        }

        [TestCase]
        public void SubOne()
        {
            var math = new NewMath();
            Assert.AreEqual(31, math.SubOne(32));
        }

        [TestCase]
        public void MulTwo()
        {
            var math = new NewMath();
            Assert.AreEqual(64, math.MulTwo(32));
        }

        [TestCase]
        public void DivTwo()
        {
            var math = new NewMath();
            Assert.AreEqual(16, math.DivTwo(32));
        }
    }
}
