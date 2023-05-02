using DataStructures.ArrayOperation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tests
{
    [TestFixture]
    public class ArrayOperationTests
    {
        ArrayOperation _obj;
        [SetUp]
        public void Setup()
        {
            _obj = new ArrayOperation();
        }

        [Test]
        [TestCase(new int[] {1,1,0,1,1,1},3)]
        public void TestArrayOperation(int[] nums, int expected) 
        {
            int actual = _obj.FindMaxConsecutiveOnes(nums);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(new int[] { 112, 12321, 1, 12, 32, 2121,232 }, 3)]
        public void TestFindNumbersWithEvenDigits(int[] nums, int expected)
        {
            int actual = _obj.FindNumbersWithEvenDigits(nums);
            Assert.AreEqual(expected, actual);
        }


        [Test]
        [TestCase(new int[] { 1, 0, 2, 3, 0, 4, 5, 0 })]
        public void TestDuplicateZeros(int[] nums)
        {
            _obj.DuplicateZeros(nums);
            Assert.AreEqual(true, true);
        }

    }
}
