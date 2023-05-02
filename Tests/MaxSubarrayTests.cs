using DataStructures.MaxSubarray;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    public class MaxSubarrayTests
    {
        MaxSubarray _obj;
        [SetUp]
        public void Setup()
        {
            _obj = new MaxSubarray();
        }



        [Test]
        //[TestCase(new int[] {  -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
        [TestCase(new int[] { -1 }, -1)]
       // [TestCase(new int[] { 5, 4, -1, 7, 8 }, 23)]
        public void GetMaxArrayTest(int[] nums, int acceptedSum)
        {
           // int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int maxSum = _obj.GetMaxSubarray(nums);
            Assert.AreEqual(acceptedSum, maxSum);
        }

        [Test]
        [TestCase(new int[] {  -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
        [TestCase(new int[] { -1 }, -1)]
        [TestCase(new int[] { 5, 4, -1, 7, 8 }, 23)]
        public void GetMaxArrayOptimizedTest(int[] nums, int acceptedSum)
        {
            // int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int maxSum = _obj.GetMinSubarrayOptimized(nums);
            Assert.AreEqual(acceptedSum, maxSum);
        }
    }
}
