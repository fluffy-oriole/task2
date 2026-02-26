using task2;

namespace TestTask2
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void NoSubsequence()
        {
            List<int> sequence = new List<int> { 1, 2, 3, 4, 5 };
            string answer = Logic.FindSequenceNumber(sequence, 5);
            Assert.AreEqual("Такой последовательности нет", answer);
        }

        [TestMethod]
        public void NormalSubsequence()
        {
            List<int> sequence = new List<int> { 1, 2, 2, 2, 3 };
            string answer = Logic.FindSequenceNumber(sequence, 3);
            Assert.AreEqual("1 2 3", answer);
        }

        [TestMethod]
        public void EmptySequence()
        {
            List<int> sequence = new List<int> { };
            string answer = Logic.FindSequenceNumber(sequence, 3);
            Assert.AreEqual("Такой последовательности нет", answer);
        }

        [TestMethod]
        public void EmptySubsequenceLength()
        {
            List<int> sequence = new List<int> { 1, 2, 2, 2, 3 };
            string answer = Logic.FindSequenceNumber(sequence, 0);
            Assert.AreEqual("Такой последовательности нет", answer);
        }

        [TestMethod]
        public void SubsequenceAtTheEnd()
        {
            List<int> sequence = new List<int> { 1, 2, 3, 4, 4 };
            string answer = Logic.FindSequenceNumber(sequence, 2);
            Assert.AreEqual("3 4", answer);
        }

        [TestMethod]
        public void MoreThanOneSecuence()
        {
            List<int> sequence = new List<int> { 1, 2, 2, 3, 4, 4 };
            string answer = Logic.FindSequenceNumber(sequence, 2);
            Assert.AreEqual("1 2", answer);
        }
    }
}
