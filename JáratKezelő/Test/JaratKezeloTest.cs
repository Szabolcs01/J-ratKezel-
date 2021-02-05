using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace JáratKezelő.Test
{
    [TestFixture]
    class JaratKezeloTest
    {
        JaratKezelo jaratKezelo;
        Jarat jarat;

        [SetUp]
        public void setUp()
        {
            jaratKezelo = new JaratKezelo();
        }

        [Test]
        public void UjJaratSzamTest()
        {
            Jarat jaratTest = new Jarat("87", "BudaPest", "Berlin", new DateTime(2021, 2, 5, 13, 8, 10));
            Assert.AreEqual("87", jaratTest.JaratSzam);
        }
        [Test]
        public void UjJaratrepterHonnanTest()
        {
            Jarat jaratTest = new Jarat("87", "BudaPest", "Berlin", new DateTime(2021, 2, 5, 13, 8, 10));
            Assert.AreEqual("BudaPest", jaratTest.HonnanRepter);
        }
        [Test]
        public void UjJaratrepterHovaTest()
        {
            Jarat jaratTest = new Jarat("87", "BudaPest", "Berlin", new DateTime(2021, 2, 5, 13, 8, 10));
            Assert.AreEqual("Berlin", jaratTest.HovaRepter);
        }
        [Test]
        public void UjJaratindulasTest()
        {
            Jarat jaratTest = new Jarat("87", "BudaPest", "Berlin", new DateTime(2021, 2, 5, 13, 8, 10));
            Assert.AreEqual("Berlin", jaratTest.HovaRepter);
        }
        [Test]
        public void KesesTobbTest()
        {
            jaratKezelo.UjJarat("87", "BudaPest", "Berlin", new DateTime(2021, 2, 5, 19, 10, 20));
            jaratKezelo.Keses("87", 15);
            jaratKezelo.Keses("87", 30);
            Assert.AreEqual(new DateTime(2021, 2, 5, 19, 55, 20), jaratKezelo.MikorIndul("87"));

        }
        [Test]
        public void KesesNegativTest()
        {
            jaratKezelo.UjJarat("87", "BudaPest", "Berlin", new DateTime(2021, 2, 5, 19, 10, 20));
            jaratKezelo.Keses("87", 15);

            Assert.Throws<NegativKesesException>(
                () =>
                {
                    jaratKezelo.Keses("87", -20);
                }
            );

        }
        [Test]
        public void MikorIndulTest()
        {
            jaratKezelo.UjJarat("87", "BudaPest", "Berlin", new DateTime(2021, 2, 5, 19, 10, 20));
            Assert.AreEqual(new DateTime(2019, 3, 10, 14, 8, 0), jaratKezelo.MikorIndul("87"));
        }

        [Test]
        public void KetJaratUANevTest()
        {
            jaratKezelo.UjJarat("87", "BudaPest", "Berlin", new DateTime(2021, 2, 5, 19, 10, 20));

            Assert.Throws<ArgumentException>(
                () =>
                {
                    jaratKezelo.UjJarat("87", "BudaPest", "Berlin", new DateTime(2021, 2, 5, 19, 10, 20));
                }
            );

        }

    }
}
