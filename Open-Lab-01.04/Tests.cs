using NUnit.Framework;

namespace Open_Lab_01._04
{
    public class Tests
    {
        [TestCase(10, 5, 25)]
        [TestCase(1, 10, 5)]
        [TestCase(100, 50, 2500)]
        [TestCase(1, 2, 1)]
        [TestCase(2, 4, 4)]
        public void Area(double foundation, double height, double result)
        {
            var triangle = new Triangle();
            Assert.That(triangle.Area(foundation, height), Is.EqualTo(result));
        }
    }
}