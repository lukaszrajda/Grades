using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void StringComparisions()
        {
            string name1 = "Test";
            string name2 = "test";

            bool result = string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);

        }
        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;
            x1 = 4;

            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariablesHoldsAReference()
        {
            var g1 = new GradeBook();
            var g2 = g1;

            g1.Name = "Test grade book";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
