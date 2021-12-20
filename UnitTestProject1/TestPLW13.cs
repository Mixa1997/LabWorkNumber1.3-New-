using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestProjectLabWorkNomer13;

namespace UnitTestProject1
{
    [TestClass]
    public class TestPLW13
    {
        [TestMethod]
        public void TestMethod()
        {
            Tannel auto = new Tannel("Туннель");
            Vxod auto2 = new Vxod("Вход");

            Assert.AreEqual("Туннель", auto.name);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Tannel auto = new Tannel("Туннель");
            Assert.AreEqual("Прошло несколько секунд,прежде чем он понял,что произошло. Они нырнули в туннель.", auto.Deistvie());
        }

        [TestMethod]
        public void TestMethod3()
        {
            Vxod auto2 = new Vxod("Вход");
            Svet auto3 = new Svet("Свет");

            Assert.AreEqual("Вход", auto2.name);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Vxod auto2 = new Vxod("Вход");
            Assert.AreEqual("То,что он принял за движущийся им навстречу объект,было его освещённым входом", auto2.Deistvie2());
        }

        [TestMethod]
        public void TestMethod5()
        {
            Svet auto3 = new Svet("свечение");
            Speed auto4 = new Speed("Скорость");

            Assert.AreEqual("свечение", auto3.name);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Svet auto3 = new Svet("Свет");
            Assert.AreEqual("Серебристое свечение испускали круглые стены туннеля,", auto3.Deistvie3());
        }

        [TestMethod]
        public void TestMethod7()
        {
            Speed auto4 = new Speed("Скорость");
            Assert.AreEqual(auto4.name,"Скорость");
        }

        [TestMethod]
        public void TestMothod8()
        {
            Speed auto4 = new Speed("Скорость");
            Assert.AreEqual(auto4.Diestvie4(),"очевидно,со скоростью несколько сот миль в час.");
        }
    }
}
