using Lesson_13;
using NUnit.Framework;

namespace NUnitLesson_13
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

       [Test]
        public void AddTest_1()
        {
            var exp = new MyList(new int[] { 2, 4, 6 });
            var currentList = new MyList(new int[] { 2, 4 });
            currentList.Add(6);
            Assert.AreEqual(exp.Lenght, currentList.Lenght);
        }

        [Test]
        public void AddTest_2()
        {
            var exp = new MyList(new int[] { 2, 4, 6 });
            var currentList = new MyList(new int[] { 2, 4 }); 

            currentList.Add(6);
            Assert.AreEqual(exp, currentList);
        }
        [Test]
        public void RemoveFirstTest_3() 
        {
            var exp = new MyList(new int[] { 4, 6, 8 });
            var currentList = new MyList(new int[] { 2, 4, 6 ,8 });
            currentList.RemoveFirst();
            Assert.AreEqual(exp, currentList);
        }
        [Test]
        public void RemoveTest_4()
        {
            var exp = new MyList(new int[] { 2, 4,6, 8,10,12,14,15 });
            var currentList = new MyList(new int[] { 2, 4, 6, 8,10,12,14,15,16 });
            currentList.RemoveItemByIndex(8);
            Assert.AreEqual(exp, currentList);
        }
        [Test]
        public void RemoveTest_5()
        {
            var exp = new MyList(new int[] { 2, 4, 6, 8, 10, 12, 14, 16 });
            var currentList = new MyList(new int[] { 2, 4, 6, 8, 10, 12, 14, 15, 16 });
            currentList.RemoveItemByIndex(7);
            Assert.AreEqual(exp, currentList);
        }
        [Test]
        public void MaxElementTest_6()
        {
            var exp = new MyList(16);
            var currentList = new MyList(new int[] { 2, 4, 6, 8, 10, 16, 14, 15, 8 });
            Assert.AreEqual(exp.GetMaxValue(), currentList.GetMaxValue());
        }
        [Test]
        public void MinElementTest_7()
        {
            var exp = new MyList(2);
            var currentList = new MyList(new int[] { 4, 6, 8, 10, 2, 14, 15, 8 });
            Assert.AreEqual(exp.GetMinValue(), currentList.GetMinValue());
        }
        [Test]
        public void ReversTest_8()
        {
            var exp = new MyList(new int[] { 10,8,6,4,2});
            var currentList = new MyList(new int[] { 2, 4, 6, 8, 10});
            currentList.Reverse();
            Assert.AreEqual(exp, currentList);
        }
        [Test]
        public void AddFirst_9()
        {
            var exp = new MyList(new int[] { 4, 6, 8, 10 });
            var currentList = new MyList(new int[] { 6, 8, 10 });
            currentList.AddFirst(4);
            Assert.AreEqual(exp, currentList);
        }
        [Test]
        public void AddAtIndex_10()
        {
            var exp = new MyList(new int[] { 4, 6, 2, 8, 10 });
            var currentList = new MyList(new int[] { 4, 6, 8, 10 });
            currentList.AddAtIndex(2,2);
            Assert.AreEqual(exp, currentList);
        }
    }
}