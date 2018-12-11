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
    }
}