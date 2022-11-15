using System;
using NUnit.Framework;

namespace GreatSolver.Tests
{
    [TestFixture]
    public class Line_Test
    {
        [Test]
        public void AAndBIsZero()
        {
            var line = new Line(0, 0);
            Assert.AreEqual(true, line.GetRoots().IsAny);
        }

        [Test]
        public void BIsZero()
        {
            var line = new Line(1, 0);
            Assert.AreEqual(new double[] { 0 }, line.GetRoots().Value);
        }

        [Test]
        public void AIsZero()
        {
            var line = new Line(0, 1);
            Assert.AreEqual(null, line.GetRoots().Value);
        }

        [Test]
        public void Standard()
        {
            var line = new Line(2, 1);
            Assert.AreEqual(new double[] { 0.5 }, line.GetRoots().Value);
        }
    }
}