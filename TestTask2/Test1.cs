using task2;

namespace TestTask2
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void NoSubsequence()
        {
            int[] sequence = new int[] { 1, 2, 3, 4, 5 };
            int answer = Logic.FindSequenceNumber(sequence, 5, 5);
            Assert.AreEqual(-1, answer);
        }

        [TestMethod]
        public void NormalSubsequence()
        {
            int[] sequence = new int[] { 1, 2, 2, 2, 3 };
            int answer = Logic.FindSequenceNumber(sequence, 5, 3);
            Assert.AreEqual(1, answer);
        }
        
        [TestMethod]
        public void EmptySequence()
        {
            int[] sequence = new int[] { };
            int answer = Logic.FindSequenceNumber(sequence, 0, 3);
            Assert.AreEqual(-1, answer);
        }
        
        [TestMethod]
        public void EmptySubsequenceLength()
        {
            int[] sequence = new int[] { 1, 2, 2, 2, 3 };
            int answer = Logic.FindSequenceNumber(sequence, 5, 0);
            Assert.AreEqual(-1, answer);
        }

        [TestMethod]
        public void SubsequenceAtTheEnd()
        {
            int[] sequence = new int[] { 1, 2, 3, 4, 4 };
            int answer = Logic.FindSequenceNumber(sequence, 3, 2);
            Assert.AreEqual(-1, answer);
        }
        
        [TestMethod]
        public void MoreThanOneSecuence()
        {
            int[] sequence = new int[] { 1, 2, 2, 3, 4, 4 };
            int answer = Logic.FindSequenceNumber(sequence, 6, 2);
            Assert.AreEqual(1, answer);
        }
    }
}
