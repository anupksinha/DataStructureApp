using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace DataStructureApp.Tests
{
    [TestFixture]
    public class DuplicateElementTest
    {
        private ContainDuplicate _containDuplicateObj;
        [SetUp]
        public void Setup()
        {
            _containDuplicateObj = new ContainDuplicate();
        }

        [Test]
        [TestCase(new int[] {2,4,3,9,1,3})]
        [TestCase(new int[] { 2, 4, 9, 1, -7 ,9})]
        [TestCase(new int[] { 2, 4, 9, 1, -1,-1 })]
        [TestCase(new int[] { 2, 4, 9, 2, 3 })]
        public void FindDublicteElementUsingLinearSearch(int[] nums)
        {
            bool hasDuplicate = _containDuplicateObj.ContainDuplicateLinearSearch(nums);
            Assert.IsTrue(hasDuplicate);
        }

        [Test]
        [TestCase(new int[] { 2, 4, 3, 9, 1, 3 })]
        [TestCase(new int[] { 2, 4, 9, 1, -7, 9 })]
        [TestCase(new int[] { 2, 4, 9, 1, -1, -1 })]
        [TestCase(new int[] { 2, 4, 9, 2, 3 })]
        public void FindDublicteElementUsingSorting(int[] nums)
        {
            bool hasDuplicate = _containDuplicateObj. ContainDuplicateUsingSorting(nums);
            Assert.IsTrue(hasDuplicate);
        }


        [Test]
        [TestCase(new int[] { 2, 4, 3, 9, 1, 3 })]
        [TestCase(new int[] { 2, 4, 9, 1, -7, 9 })]
        [TestCase(new int[] { 2, 4, 9, 1, -1, -1 })]
        [TestCase(new int[] { 2, 4, 9, 2, 3 })]
        public void FindDublicteElementUsingHashSet(int[] nums)
        {
            bool hasDuplicate = _containDuplicateObj.ContainDuplicateUsingHashset(nums);
            Assert.IsTrue(hasDuplicate);
        }



    }
}
