using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;

namespace AlCommon.Util.Tests
{
    [TestClass()]
    public class CommonTests
    {
        public interface ICalculator
        {
            int Add(int a, int b);
        }

        /// <summary>
        /// 程式碼有一個介面ICalculator
        /// 我可以用Substitute.For<ICalculator>(); 
        /// 產生一個 假的ICalculator實體
        /// calculator.Add(3,6).Returns(9);
        /// 就是設定add方法 當傳入的參數是3，6時 回傳9
        /// 這就是隔離，我不管add方法寫對還是錯，我可以設定我期待的回傳值
        /// 最後實際去執行add然後驗證是否如預期是9
        /// </summary>
        [TestMethod()]
        public void HelloNSubstitute()
        {
            //arrange
            //NSubstitute會產生一個ICalculator 假的實體出來
            ICalculator calculator = Substitute.For<ICalculator>();
            //設定假的實體的Add方法當傳入3,6 回傳 9
            calculator.Add(3, 6).Returns(9);
            var expected = 9;

            //act
            var actual = calculator.Add(3, 6);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}