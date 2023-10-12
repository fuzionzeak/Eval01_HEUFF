using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassesFlotte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesFlotte.Tests
{
    [TestClass()]
    public class UtilitaireTests
    {
        [TestMethod()]
        public void ChargeUtileTest()
        {
            Utilitaire U1 = new Utilitaire(1000, 500, 2500);
            Assert.AreEqual(500, U1.unPtac);
        }

        [TestMethod()]
        public void PrevoirEntretienTest()
        {
            // TODO
        }
    }
}