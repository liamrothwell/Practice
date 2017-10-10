using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingChallengesCSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallengesCSharpTwoSum.Tests
{
    [TestClass()]
    public class ProgramTwoSumTests
    {
        [TestMethod()]
        public void ReverseArrayTwoSumTest()
        {

            int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] reversedArray = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1};
            var results = Program.ReverseArray(array);
            CollectionAssert.AreEqual(results, reversedArray);
            
        }
    }
}