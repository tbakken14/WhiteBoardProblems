using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Project.Tests {
    [TestClass]
    public class ProjectTests {
        [TestMethod]
        [DataRow("cat", "hat", false)]
        [DataRow("cat", "bat", false)]
        [DataRow("cat", "act", true)]
        [DataRow("cat", "tac", true)]
        [DataRow("cat", "fact", false)]
        public void anagram_test(string word1, string word2, bool result) {
            Assert.AreEqual(Project.Anagram.isAnagram(word1, word2), result);
        }
    }
}