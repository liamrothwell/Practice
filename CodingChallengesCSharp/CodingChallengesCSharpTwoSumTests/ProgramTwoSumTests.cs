using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallengesCSharpTwoSumTests
{
    [TestClass()]
    public class ProgramTwoSumTests
    {
        [TestMethod()]
        public void MainTwoSumTest()
        {
            int[] array = { 5, 6, 12, 18, 16, 4, 2 };
            int[] returnShouldBe = {1, 5};
            int targetNumber = 10;

            int[] result = CodingChallengesCSharp.Program.TwoSum(array, targetNumber);

            CollectionAssert.AreEqual(returnShouldBe, result);
            
        }
    }
}