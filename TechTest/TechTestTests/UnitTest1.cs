using NUnit.Framework;
using TechTest;

namespace TechTestTests
{
    public class Tests
    {

        [TestCase(28)]
        [TestCase(7)]
        [TestCase(14)]
        public void PlongTest(int a)
        {
            var actual = TechTestClass.PlingPlangPlong(a);
            Assert.AreEqual("Plong",actual);
        }

        [TestCase(3)]
        [TestCase(6)]
        public void PlingTest(int a)
        {
            var actual = TechTestClass.PlingPlangPlong(a);
            Assert.AreEqual("Pling", actual);
        }

        [TestCase(5)]
        [TestCase(-5)]
        public void PlangTest(int a)
        {
            var actual = TechTestClass.PlingPlangPlong(a);
            Assert.AreEqual("Plang", actual);
        }

        [TestCase(30)]
        public void PlingPlangTest(int a)
        {
            var actual = TechTestClass.PlingPlangPlong(a);
            Assert.AreEqual("PlingPlang", actual);
        }
        [TestCase(70)]
        public void PlongPlangTest(int a)
        {
            var actual = TechTestClass.PlingPlangPlong(a);
            Assert.AreEqual("PlangPlong", actual);
        }

        [TestCase(21)]
        public void PlingPlongTest(int a)
        {
            var actual = TechTestClass.PlingPlangPlong(a);
            Assert.AreEqual("PlingPlong", actual);
        }

        [TestCase(105)]
        public void PlingPlangPlong(int a)
        {
            var actual = TechTestClass.PlingPlangPlong(a);
            Assert.AreEqual("PlingPlangPlong", actual);
        }

        [TestCase(34)]
        [TestCase(-34)]
        public void NumReturnTest(int a)
        {
            var actual = TechTestClass.PlingPlangPlong(a);
            Assert.AreEqual(a.ToString(), actual);
        }

    }
}