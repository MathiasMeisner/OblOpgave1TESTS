using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obl_Opgave1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Obl_Opgave1.Tests
{
    [TestClass()]
    public class BeerTests
    {
        private Beer beer;

        [TestInitialize()]
        public void Init()
        {
            beer = new Beer("Tuborg", 1, 20, 5);
        }

        [TestMethod()]
        public void NameTest()
        {
            Assert.AreEqual("Tuborg", beer.Name);
            Assert.ThrowsException<ArgumentException>(() => beer.Name = "Tub");
            Assert.ThrowsException<ArgumentNullException>(() => beer.Name = null);
        }

        [TestMethod()]
        public void IdTest()
        {
            Assert.AreEqual(1, beer.Id);
        }

        [TestMethod()]
        public void PriceTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer.Price = 0);
            beer.Price = 15;
            Assert.AreEqual(15, beer.Price);
        }

        [TestMethod()]
        public void AbvTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer.Abv = -1);
            beer.Abv = 4.6;
            Assert.AreEqual(4.6, beer.Abv);
            beer.Abv = 80;
            Assert.AreEqual(80, beer.Abv);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer.Abv = 101);
        }
    }
}