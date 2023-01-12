using NUnit.Framework;
using System.Collections.Generic;

namespace TriangleTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var input = new List<string>();
            var expected = new List<string>();
            
            input.Add("2 2 1");
            expected.Add("Isosceles");

            input.Add("3 3 3");
            expected.Add("Equilateral");

            input.Add("3 4 5");
            expected.Add("NoneOfThese");

            input.Add("1 1 3");
            expected.Add("NoneOfThese");

            var output = Triangle.Result.triangleType(input);


            Assert.AreEqual(output, expected);
        }
    }
}