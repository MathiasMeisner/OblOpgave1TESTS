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
            Assert.ThrowsException<ArgumentException>(() => beer.Name = null);
        }
    }
}

namespace Obl_Opgave1Tests
{
    class BeerTests
    {
    }
}