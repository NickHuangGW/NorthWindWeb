using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NorthWindPracticeWeb.Common.Extensions;

namespace NorthWindPracticeWeb.Common.Test
{
    [TestClass]
    public class StringExtensionTest
    {
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("StringExtension")]
        [TestProperty("StringExtension", "IsNullOrEmpty")]
        public void IsNullOrEmpty_輸入空字串_應為True()
        {
            //arrange (準備)
            var value = "";

            //act (執行)
            var actual = value.IsNullOrEmpty();

            //assert (驗證)
            actual.Should().BeTrue();
        }
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("StringExtension")]
        [TestProperty("StringExtension", "IsNullOrEmpty")]
        public void IsNullOrEmpty_輸入空白_應為False()
        {
            //arrange (準備)
            var value = " ";

            //act (執行)
            var actual = value.IsNullOrEmpty();

            //assert (驗證)
            actual.Should().BeFalse();
        }
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("StringExtension")]
        [TestProperty("StringExtension", "IsNullOrEmpty")]
        public void IsNullOrEmpty_輸入空白字符_應為False()
        {
            //arrange (準備)
            var value = "/t";

            //act (執行)
            var actual = value.IsNullOrEmpty();

            //assert (驗證)
            actual.Should().BeFalse();
        }
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("StringExtension")]
        [TestProperty("StringExtension", "IsNullOrEmpty")]
        public void IsNullOrEmpty_輸入字符_應為False()
        {
            //arrange (準備)
            var value = "A";

            //act (執行)
            var actual = value.IsNullOrEmpty();

            //assert (驗證)
            actual.Should().BeFalse();
        }
    }
}