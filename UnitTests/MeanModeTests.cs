using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MeanMode;

namespace UnitTests
{
    [TestClass]
    public class MeanModeTests
    {
        [TestMethod]
        public void MeanMode1()
        {
            int[] numbers = new int[6];
            for (int j = 0; j < numbers.Length; j++)
            {
                numbers[j] = 1;
            }
            Assert.IsTrue(MeanMode.Program.MeanMode(numbers));
        }

        [TestMethod]
        public void MeanMode2()
        {
            int[] numbers = new int[5];
            numbers[0] = 4;
            numbers[1] = 4;
            numbers[2] = 4;
            numbers[3] = 6;
            numbers[4] = 2;
            Assert.IsTrue(MeanMode.Program.MeanMode(numbers));
        }

        [TestMethod]
        public void MeanMode3()
        {
            int[] numbers = new int[6];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 9;
            numbers[5] = 9;
            //{1,2,3,4,9,9}
            Assert.IsFalse(MeanMode.Program.MeanMode(numbers));
        }

        [TestMethod]
        public void MeanMode4()
        {
            int[] numbers = new int[9];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;
            numbers[5] = 6;
            numbers[6] = 7;
            numbers[7] = 8;
            numbers[8] = 9;
            //{1,2,3,4,5,6,7,8,9}
            Assert.IsFalse(MeanMode.Program.MeanMode(numbers));
        }

        [TestMethod]
        public void MeanMode5()
        {
            int[] numbers = new int[900];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 2;
            }
            Assert.IsTrue(MeanMode.Program.MeanMode(numbers));
        }

        [TestMethod]
        public void MeanMode6()
        {
            int[] numbers = { -3, -3, -3, 0, 0, 0, 3, 3, 3 };

            Assert.IsFalse(MeanMode.Program.MeanMode(numbers));
        }

        [TestMethod]
        public void MeanMode7()
        {
            int[] numbers = new int[900];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 2;
            }

            numbers[0] = 4;
            numbers[899] = 0;
            Assert.IsTrue(MeanMode.Program.MeanMode(numbers));
        }

        [TestMethod]
        public void MeanMode8()
        {
            int[] numbers = { 0, 0, 0, 3, 3, 3, -3, -3, -3, };

            Assert.IsFalse(MeanMode.Program.MeanMode(numbers));
        }
    }
}