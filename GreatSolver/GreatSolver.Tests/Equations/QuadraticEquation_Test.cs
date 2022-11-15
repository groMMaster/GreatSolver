using NUnit.Framework;
using System;

namespace GreatSolver.Tests
{
    [TestFixture]
    public class QuadraticEquation_Test
    {
        [Test]
        public void PositiveDiscriminant()
        {
            var quation = new QuadraticEquation(1, 2, -3);
            Assert.AreEqual(new double[] { -3, 1 }, quation.GetRoots().Value);
        }

        [Test]
        public void DiscriminantIsZero()
        {
            var quation = new QuadraticEquation(1, -2, 1);
            Assert.AreEqual(new double[] { 1 }, quation.GetRoots().Value);
        }

        [Test]
        public void NegativeDiscriminant()
        {
            var quation = new QuadraticEquation(1, 2, 3);
            Assert.AreEqual(null, quation.GetRoots().Value);
        }

        [Test]
        public void BIsZeroOne()
        {
            var quation = new QuadraticEquation(1, 0, -4);
            Assert.AreEqual(new double[] { -2, 2 }, quation.GetRoots().Value);
        }

        [Test]
        public void BIsZeroTwo()
        {
            var quation = new QuadraticEquation(1, 0, 4);
            Assert.AreEqual(null, quation.GetRoots().Value);
        }

        [Test]
        public void BIsZeroThree()
        {
            var quation = new QuadraticEquation(-1, 0, 4);
            Assert.AreEqual(new double[] { 2, -2 }, quation.GetRoots().Value);
        }

        [Test]
        public void CIsZero()
        {
            var quation = new QuadraticEquation(1, 4, 0);
            Assert.AreEqual(new double[] {-4, 0 }, quation.GetRoots().Value);
        }

        [Test]
        public void AIsZero()
        {
            Assert.Throws<ArgumentException>(() => new QuadraticEquation(0, 4, 1));
        }

        [Test]
        public void BAndCIsZero()
        {
            var quation = new QuadraticEquation(1, 0, 0);
            Assert.AreEqual(new double[] { 0 }, quation.GetRoots().Value);
        }
    }
}