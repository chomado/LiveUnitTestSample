using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiveUnitTestSample;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var answer = Calc.Add(2, 3);

            // 期待される値と、実際の値を比較し、
            // 一致したら「テスト成功」（ユニットテスト）
            Assert.AreEqual(expected: 5, actual: answer);
        }

        // "tesm" でテストメソッドのスニペット (tab+tab)
        [TestMethod]
        public void AddTest()
        {
            var answer = Calc.Add(4, 5);

            // 期待される値と、実際の値を比較し、
            // 一致したら「テスト成功」（ユニットテスト）
            Assert.AreEqual(expected: 9, actual: answer);

        }
    }
}
