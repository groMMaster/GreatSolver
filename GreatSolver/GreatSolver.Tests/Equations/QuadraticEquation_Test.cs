using NUnit.Framework;
using System;

namespace GreatSolver.Tests
{
    [TestFixture]
    public class QuadraticEquation_Test
    {
        void TestQuadraticEquation(double a, double b, double c, params double[] expectedResults)
        {
            var quation = new QuadraticEquation(a, b, c);
            var result = quation.GetRoots();

            Assert.AreEqual(expectedResults, result.Value);
            Assert.IsFalse(result.IsAny);
        }

        [Test]
        public void PositiveDiscriminant()
        {
            TestQuadraticEquation(1, 2, -3, -3, 1);
        }

        [Test]  
        public void DiscriminantIsZero()
        {
            TestQuadraticEquation(1, -2, 1, 1);
        }

        [Test]
        public void NegativeDiscriminant()
        {
            TestQuadraticEquation(1, 2, 3, null);
        }

        [Test]
        public void BIsZeroOne()
        {
            TestQuadraticEquation(1, 0, -4, -2, 2);
        }

        [Test]
        public void BIsZeroTwo()
        {
            TestQuadraticEquation(1, 0, 4, null);
        }

        [Test]
        public void BIsZeroThree()
        {
            TestQuadraticEquation(-1, 0, 4, 2, -2);
        }

        [Test]
        public void CIsZero()
        {
            TestQuadraticEquation(1, 4, 0, -4, 0);
        }

        [Test]
        public void AIsZero()
        {
            Assert.Throws<ArgumentException>(() => new QuadraticEquation(0, 4, 1));
        }

        [Test]
        public void BAndCIsZero()
        {
            TestQuadraticEquation(1, 0, 0, 0);
        }
    }
}