using DataStructures.TwoSum;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    public class TwoSumTests
    {
        TwoSum _obj;
        [SetUp]
        public void Setup()
        {
            _obj = new TwoSum();
        }
        [Test]
        [TestCase(new int[] { 2, 7, 11, 15}, 9, new int[] {0,1 })]
        [TestCase(new int[] { 3, 2, 4 }, 6, new int[] { 1,2})]
        [TestCase(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void TwoSumLinearSearchTest(int[] nums, int target, int[] expectedArr)
        {
            int[] result = _obj.TwoSumLinearSearch(nums, target);
            Assert.AreEqual(expectedArr, result);
        }

        [Test]
        [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [TestCase(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [TestCase(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void TwoSumUsingHashTable(int[] nums, int target, int[] expectedArr)
        {
            int[] result = _obj.TwoSumUsingHashMap(nums, target);
            Assert.AreEqual(expectedArr, result);
        }






    }
}
