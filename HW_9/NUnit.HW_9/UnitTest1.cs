using HW_9;
using NUnit.Framework;

namespace NUnit.HW_9
{
    public class Tests
    {
        [TestCase(2, 3, 5)]
        [TestCase(-5, 0, -5)]
        [TestCase(4, 9, 13)]
        public void SumTest_1(double firstnumber, double secondnumber, double exp) 
        {
            var calclogic = new Calculator();

            var res = calclogic.Sum(firstnumber,secondnumber);

            Assert.AreEqual(exp, res);
        }

        [TestCase(2, 3, -1)]
        [TestCase(-5, -6, 1)]
        [TestCase(14, 7, 7)]
        public void SubtractionTest_2(double firstnumber, double secondnumber, double exp)
        {
            var calclogic = new Calculator();

            var res = calclogic.Subtraction(firstnumber, secondnumber);

            Assert.AreEqual(exp, res);
        }

        [TestCase(2, 3, 6)]
        [TestCase(-5, 6, -30)]
        [TestCase(7, 7, 49)]
        public void MultiplicationTest_3(double firstnumber, double secondnumber, double exp)
        {
            var calclogic = new Calculator();

            var res = calclogic.Multiplication(firstnumber, secondnumber);

            Assert.AreEqual(exp, res);
        }

        [TestCase(8, 2, 4)]
        [TestCase(-9, 3, -3)]
        [TestCase(7, 7, 1)]
        public void DivisionTest_4(double firstnumber, double secondnumber, double exp)
        {
            var calclogic = new Calculator();

            var res = calclogic.Division(firstnumber, secondnumber);

            Assert.AreEqual(exp, res);
        }

        [TestCase(7,new int[] {},new int[] {7})]
        [TestCase(12, new int[] {-2}, new int[] {-2, 12})]
        [TestCase(8, new int[] {3, 4, 6}, new int[] {3, 4, 6, 8})]
        [TestCase(-3, new int[] {6, 7}, new int[] {6, 7, -3})]
        public void AddElementTest_1(int value, int[] inputArray, int[] expectedArray)
        {
            WorkWithArray actualArray = new WorkWithArray(inputArray);

            actualArray.AddElement(value);

            Assert.AreEqual(expectedArray, actualArray.GetArr());
        }

        [TestCase(2, new int[] { 12, 3, 4, 5 }, new int[] { 12, 3, 5 })]
        [TestCase(0, new int[] { 8, 9, 10, 5 }, new int[] { 9, 10, 5 })]
        [TestCase(1, new int[] { 1, 3, 5, 7 }, new int[] { 1, 5, 7 })]
        public void DeleteElementTest_2(int index, int[] inputArray, int[] expectedArray) 
        {
            WorkWithArray actualArray = new WorkWithArray(inputArray);

            actualArray.DeleteElement(index);

            Assert.AreEqual(expectedArray, actualArray.GetArr());
        }

        [TestCase(new int[] { 12, 3, 4 }, new int[] { 0, 0, 0 })]
        [TestCase(new int[] { 1, 3, 5, 7 }, new int[] { 0, 0, 0, 0 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 0, 0 })]
        public void ClearArrayTest_3(int[] inputArray, int[] expectedArray)
        {
            WorkWithArray actualArray = new WorkWithArray(inputArray);

            actualArray.ClearArray();

            Assert.AreEqual(expectedArray, actualArray.GetArr());
        }

        [TestCase(new int[] { 12, 3, 4 }, new int[] { 12, 4, 3 })]
        [TestCase(new int[] { 1, 3, 5, 2, 9  }, new int[] { 9, 5, 3, 2, 1 })]
        [TestCase(new int[] { 1, 10 }, new int[] { 10, 1 })]
        public void SortArrayElementTest_4(int[] inputArray, int[] expectedArray)
        {
            WorkWithArray actualArray = new WorkWithArray(inputArray);

            actualArray.SortArray();

            Assert.AreEqual(expectedArray, actualArray.GetArr());
        }

        [TestCase(110, "one hundred ten")]
        [TestCase(12, "twelve")]
        [TestCase(245, "two hundred forty five")]
        public void WordsConstructorTest_1(int number, string words)
        {
            Assert.AreEqual(Program.WordsConstructor(number), words);
        }
    }
}