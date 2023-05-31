namespace AlgorithmsTestProject
{
	public static class StackQueueProblemTests
	{
        [Test]
        public static void TestStackPush()
        {
            var t = new Stack<int>();
            t.Push(3);

            var f = new Stack<int>();
            Assert.AreEqual(t.Peek(), 3);
        }

        [Test]
        public static void TestStackPeek()
        {
            var t = new Stack<int>();
            t.Push(3);

            
            Assert.AreEqual(t.Peek(), 3);
        }

        [Test]
        public static void TestStackPop()
        {
            var t = new Stack<int>();
            t.Push(3);
            t.Push(3);
            t.Push(3);
            t.Push(4);


            Assert.AreEqual(t.Pop(), 4);
        }

        [Test]
        public static void TestStackIsEmpty()
        {
            var t = new Stack<int>();
            Assert.AreEqual(t.IsEmpty, true);
            t.Push(3);
            Assert.AreEqual(t.IsEmpty, false);
        }
    }
}

