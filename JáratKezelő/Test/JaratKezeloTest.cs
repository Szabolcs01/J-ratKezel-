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

        [TestCase]
        public void UjJaratSzamTest()
        {
           Jarat jaratTest = new Jarat("87", "BudaPest", "Berlin", new DateTime(2021, 2, 5, 13, 8, 10));
            
        
            Assert.AreEqual("87", jaratTest.JaratSzam);

            jaratTest = new Jarat("120", "London", "Parizs", new DateTime(2021, 2, 5, 13, 8, 10));
            Assert.AreEqual("120", jaratTest.JaratSzam);

            jaratTest = new Jarat("22", "Kecskemét", "Madrid", new DateTime(2021, 2, 5, 13, 8, 10));
            Assert.AreEqual("22", jaratTest.JaratSzam);
        }

        [TestCase]
        public void UjJaratrepterHonnanTest()
        {
            Jarat jaratTest = new Jarat("87", "BudaPest", "Berlin", new DateTime(2021, 2, 5, 13, 8, 10));
  
            Assert.AreEqual("BudaPest", jaratTest.HonnanRepter);
            jaratTest = new Jarat("120", "London", "Parizs", new DateTime(2021, 2, 5, 13, 8, 10));
            Assert.AreEqual("London", jaratTest.HonnanRepter);

            jaratTest = new Jarat("22", "Kecskemét", "Madrid", new DateTime(2021, 2, 5, 13, 8, 10));
            Assert.AreEqual("Kecskemét", jaratTest.JaratSzam);

        }
        [TestCase]
        public void UjJaratrepterHovaTest()
        {
            Jarat jaratTest = new Jarat("87", "BudaPest", "Berlin", new DateTime(2021, 2, 5, 13, 8, 10));
          
            Assert.AreEqual("Berlin", jaratTest.HovaRepter);
            jaratTest = new Jarat("120", "London", "Parizs", new DateTime(2021, 2, 5, 13, 8, 10));
            Assert.AreEqual("Parizs", jaratTest.HovaRepter);

            jaratTest = new Jarat("22", "Kecskemét", "Madrid", new DateTime(2021, 2, 5, 13, 8, 10));
            Assert.AreEqual("Madrid", jaratTest.JaratSzam);

        }
        [TestCase]
        public void UjJaratindulasTest()
        {
            Jarat jaratTest = new Jarat("87", "BudaPest", "Berlin", new DateTime(2021, 2, 5, 13, 8, 10));
            Assert.AreEqual("Berlin", jaratTest.HovaRepter);

            jaratTest = new Jarat("120", "London", "Parizs", new DateTime(2021, 2, 5, 13, 8, 10));
            Assert.AreEqual("Parizs", jaratTest.HovaRepter);


            jaratTest = new Jarat("22", "Kecskemét", "Madrid", new DateTime(2021, 2, 5, 13, 8, 10));
            Assert.AreEqual("Madrid", jaratTest.HovaRepter);
        }
        [TestCase]
        public void KesesTobbTest()
        {
            jaratKezelo.UjJarat("87", "BudaPest", "Berlin", new DateTime(2021, 2, 5, 19, 10, 20));
            jaratKezelo.Keses("87", 15);
            jaratKezelo.Keses("87", 30);
            Assert.AreEqual(new DateTime(2021, 2, 5, 19, 55, 20), jaratKezelo.MikorIndul("87"));
          
            
            jaratKezelo.UjJarat("120", "London", "Parizs", new DateTime(2021, 2, 5, 13, 8, 10));
            jaratKezelo.Keses("120", 10);
            jaratKezelo.Keses("120", 30);
            Assert.AreEqual(new DateTime(2021, 2, 5, 13, 48, 10), jaratKezelo.MikorIndul("120"));


            jaratKezelo.UjJarat("22", "Kecskemét", "Madrid", new DateTime(2021, 2, 5, 13, 8, 10));
            jaratKezelo.Keses("22", 10);
            jaratKezelo.Keses("22", 30);
            Assert.AreEqual(new DateTime(2021, 2, 5, 13, 48, 10), jaratKezelo.MikorIndul("22"));
        }
        [TestCase]
        public void KesesNegativTest()
        {
            jaratKezelo.UjJarat("87", "BudaPest", "Berlin", new DateTime(2021, 2, 5, 19, 10, 20));
            jaratKezelo.Keses("87", 15);
            jaratKezelo.UjJarat("120", "London", "Parizs", new DateTime(2021, 2, 5, 13, 8, 10));
            jaratKezelo.Keses("120", 0);

            jaratKezelo.UjJarat("22", "Kecskemét", "Madrid", new DateTime(2021, 2, 5, 13, 8, 10));
            jaratKezelo.Keses("22", -98);

            Assert.Throws<NegativKesesException>(
                () =>
                {
                    jaratKezelo.Keses("120", 0);
                    jaratKezelo.Keses("87", -20);
                    jaratKezelo.Keses("22", -20);
                }
            );

        }
        [TestCase]
        public void MikorIndulTest()
        {
            jaratKezelo.UjJarat("87", "BudaPest", "Berlin", new DateTime(2021, 2, 5, 13, 8, 10));
            Assert.AreEqual(new DateTime(2021, 2, 5, 13, 8, 10), jaratKezelo.MikorIndul("87"));
            jaratKezelo.UjJarat("120", "London", "Parizs", new DateTime(2021, 2, 5, 13, 8, 10));
            Assert.AreEqual(new DateTime(2021, 2, 5, 13, 8, 10), jaratKezelo.MikorIndul("120"));

            jaratKezelo.UjJarat("10", "Kecskemét", "Madrid", new DateTime(2021, 2, 5, 13, 8, 10));
            Assert.AreEqual(new DateTime(2021, 2, 5, 13, 8, 10), jaratKezelo.MikorIndul("22"));
        }

        [TestCase]
        public void KetJarat()
        {
            jaratKezelo.UjJarat("87", "BudaPest", "Berlin", new DateTime(2021, 2, 5, 13, 8, 10));
            jaratKezelo.UjJarat("120", "London", "Parizs", new DateTime(2021, 2, 5, 13, 8, 10));
            jaratKezelo.UjJarat("22", "Kecskemét", "Madrid", new DateTime(2021, 2, 5, 13, 8, 10));
            Assert.Throws<ArgumentException>(
                () =>
                {
                    jaratKezelo.UjJarat("87", "BudaPest", "Berlin", new DateTime(2021, 2, 5, 13, 8, 10));
                    jaratKezelo.UjJarat("120", "London", "Parizs", new DateTime(2021, 2, 5, 13, 8, 10));
                    jaratKezelo.UjJarat("22", "Kecskemét", "Madrid", new DateTime(2021, 2, 5, 13, 8, 10));
                }
            );

        }

    }
}
