using System;
using NUnit.Framework;

namespace NUnitTests
{
    public class Tests
    {

        [TestCase(1, ExpectedResult = 10, Description = "Term in [0;2] range")]
        [TestCase(3, ExpectedResult = 13.6, Description = "Term in [3;5] range")]
        [TestCase(4, ExpectedResult = 13.6, Description = "Term in [3;5] range")]
        [TestCase(7, ExpectedResult = 16.5, Description = "Term in [6;8] range")]
        [TestCase(8, ExpectedResult = 16.5, Description = "Term in [6;8] range")]
        [TestCase(9, ExpectedResult = 20, Description = "Term > 8")]
        [TestCase(100, ExpectedResult = 20, Description = "Term > 8")]
        public decimal Get_CorrectDepositInterest_ReturnsResult(int depositTerm) => Homework_2.TestClass.GetDepositInterest(depositTerm);

        [Test]
        public void Get_DepositTermBelowZero_ReturnsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Homework_2.TestClass.GetDepositInterest(-1));
        }
    }
}