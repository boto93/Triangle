using NUnit.Framework;
using System.Collections.Generic;

namespace TriangleTest
{
    public class TriangleTests
    {
        List<string> input = new List<string>();
        List<string> expected = new List<string>();

        [SetUp]
        public void Setup()
        {
            this.input = new List<string>();
            this.expected = new List<string>();
        }

        [Test]
        public void ShouldFindIsoscelesTriangle()
        {
            input.Add("2 2 1");
            expected.Add("Isosceles");

            var output = Triangle.Result.triangleType(input);

            Assert.AreEqual(output, expected);
        }
        [Test]
        public void ShouldFindEquilateralTriangle()
        {
            input.Add("3 3 3");
            expected.Add("Equilateral");

            var output = Triangle.Result.triangleType(input);

            Assert.AreEqual(output, expected);
        }
        [Test]
        public void ShouldFindScaleneTriangle()
        {
            input.Add("3 4 5");
            expected.Add("None Of These");

            var output = Triangle.Result.triangleType(input);

            Assert.AreEqual(output, expected);
        }
        [Test]
        public void ShouldFindInvalidTriangle()
        {
            input.Add("1 1 3");
            expected.Add("None Of These");

            var output = Triangle.Result.triangleType(input);

            Assert.AreEqual(output, expected);
        }

    }
}