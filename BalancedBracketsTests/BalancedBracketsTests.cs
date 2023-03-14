using BalancedBrackets;

namespace BalancedBracketsTests
{
    using BalancedBrackets;

    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void StringAndBracketsReturnsTrue() 
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("launch[Code]"));
        }
        [TestMethod]
        public void BracketsBeforeStringReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]launchCode"));
        }
        [TestMethod]
        public void EmptyStringReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }
        [TestMethod]
        public void SingleBracketWithStringReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[launchCode"));
        }
        [TestMethod]
        public void ReversedBracketsWithStringReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("launch]Code["));
        }
        [TestMethod]
        public void SingleBracketsWithStringReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("launchCode["));
        }
        [TestMethod]
        public void OpeningBracketsReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]launchCode"));
        }
    }

}