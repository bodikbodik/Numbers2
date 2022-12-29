using NUnit.Framework;
using System;
using System.IO;

namespace Numbers2Tasks.Tests
{
    [TestFixture]
    public class TasksTests
    {
        private StringWriter writer;

        [SetUp]
        public void SetUp()
        {
            this.writer = new StringWriter();
            Console.SetOut(this.writer);
        }

        [TearDown]
        public void Cleanup()
        {
            this.writer.Close();
        }

        [TestCase(43, "3")]
        [TestCase(65, "5")]
        [TestCase(78, "8")]
        public void Task1_ReturnsCorrectValue(int n, string expected)
        {
            Tasks.Task1(n);
            var actual = this.writer.GetStringBuilder().ToString().Trim();

            Assert.AreEqual(expected, actual, "Task1 returns incorrect value.");
        }


        [TestCase(67, "76")]
        [TestCase(34, "43")]
        [TestCase(38, "83")]
        public void Task2_ReturnsCorrectValue(int n, string expected)
        {
            Tasks.Task2(n);
            var actual = this.writer.GetStringBuilder().ToString().Trim();

            Assert.AreEqual(expected, actual, "Task2 returns incorrect value.");
        }

        [TestCase(300, "3")]
        [TestCase(385, "583")]
        [TestCase(790, "97")]
        public void Task3_ReturnsCorrectValue(int n, string expected)
        {
            Tasks.Task3(n);
            var actual = this.writer.GetStringBuilder().ToString().Trim();

            Assert.AreEqual(expected, actual, "Task3 returns incorrect value.");
        }

        [TestCase(300, "30")]
        [TestCase(385, "538")]
        [TestCase(790, "79")]
        public void Task4_ReturnsCorrectValue(int n, string expected)
        {
            Tasks.Task4(n);
            var actual = this.writer.GetStringBuilder().ToString().Trim();

            Assert.AreEqual(expected, actual, "Task4 returns incorrect value.");
        }
    }
}
