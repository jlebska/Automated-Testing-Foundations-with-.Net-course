using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNet_Automation_course.Tests
{
    [TestClass()]
    public class CharCounterTests
    {
        private CharCounter charCounter;

        [TestInitialize]
        public void SetUp()
        {
            //Arrange
            charCounter = new CharCounter();
        }

        [TestMethod()]
        [DataRow("_@ ", 0)]
        [DataRow("aaa",1)]
        [DataRow("aAa", 3)]
        [DataRow("aA a", 3)]
        [DataRow("a1b2", 4)]
        public void CountUnequalCharTest(string str, int expected)
        {
            //Act
            int actual = charCounter.CountUnequalChar(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow("222", 0)]
        [DataRow("123", 0)]
        [DataRow("_@ ", 0)]
        [DataRow("abc", 1)]
        [DataRow("aAa", 1)]
        [DataRow("aaa", 3)]
        [DataRow("a aa", 3)]
        public void CountEqualLettersTest(string str, int expected)
        {
            //Act
            int actual = charCounter.CountEqualLetters(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow("aaa", 0)]
        [DataRow("abc", 0)]
        [DataRow("_@ ", 0)]
        [DataRow("123", 1)]
        [DataRow("2@2", 2)]
        [DataRow("111", 3)]
        public void CountEqualDigitsTest(string str, int expected)
        {
            //Act
            int actual = charCounter.CountEqualDigits(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}