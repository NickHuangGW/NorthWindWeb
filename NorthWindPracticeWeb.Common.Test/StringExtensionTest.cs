using System;
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
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("StringExtension")]
        [TestProperty("StringExtension", "IsNullOrWhiteSpace")]
        public void IsNullOrWhiteSpace_輸入空值_應為True()
        {
            //arrange (準備)
            var value = (string)null;

            //act (執行)
            var actual = value.IsNullOrWhiteSpace();

            //assert (驗證)
            actual.Should().BeTrue();
        }
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("StringExtension")]
        [TestProperty("StringExtension", "IsNullOrWhiteSpace")]
        public void IsNullOrWhiteSpace_輸入空字串_應為True()
        {
            //arrange (準備)
            var value = string.Empty;

            //act (執行)
            var actual = value.IsNullOrWhiteSpace();

            //assert (驗證)
            actual.Should().BeTrue();
        }
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("StringExtension")]
        [TestProperty("StringExtension", "IsNullOrWhiteSpace")]
        public void IsNullOrWhiteSpace_輸入空白_應為True()
        {
            //arrange (準備)
            var value = " ";

            //act (執行)
            var actual = value.IsNullOrWhiteSpace();

            //assert (驗證)
            actual.Should().BeTrue();
        }
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("StringExtension")]
        [TestProperty("StringExtension", "IsNullOrWhiteSpace")]
        public void IsNullOrWhiteSpace_輸入空白字符_應為False()
        {
            //arrange (準備)
            var value = "/t";

            //act (執行)
            var actual = value.IsNullOrWhiteSpace();

            //assert (驗證)
            actual.Should().BeFalse();
        }
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("StringExtension")]
        [TestProperty("StringExtension", "IsNullOrWhiteSpace")]
        public void IsNullOrWhiteSpace_輸入字符_應為False()
        {
            //arrange (準備)
            var value = "A";

            //act (執行)
            var actual = value.IsNullOrWhiteSpace();

            //assert (驗證)
            actual.Should().BeFalse();

        }

        [TestMethod]
        [Owner("Nick")]
        [TestCategory("StringExtension")]
        [TestProperty("StringExtension", "HasValue")]
        public void HasValue_輸入空值_應為False()
        {
            //arrange (準備)
            var value = (string)null;

            //act (執行)
            var actual = value.HasValue();

            //assert (驗證)
            actual.Should().BeFalse();
        }
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("StringExtension")]
        [TestProperty("StringExtension", "HasValue")]
        public void HasValue_輸入空字串_應為False()
        {
            //arrange (準備)
            var value = string.Empty;

            //act (執行)
            var actual = value.HasValue();

            //assert (驗證)
            actual.Should().BeFalse();
        }
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("StringExtension")]
        [TestProperty("StringExtension", "HasValue")]
        public void HasValue_輸入空白_應為False()
        {
            //arrange (準備)
            var value = " ";

            //act (執行)
            var actual = value.HasValue();

            //assert (驗證)
            actual.Should().BeFalse();
        }
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("StringExtension")]
        [TestProperty("StringExtension", "HasValue")]
        public void HasValue_輸入空白字符_應為False()
        {
            //arrange (準備)
            var value = "/t";

            //act (執行)
            var actual = value.HasValue();

            //assert (驗證)
            actual.Should().BeTrue();
        }
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("StringExtension")]
        [TestProperty("StringExtension", "HasValue")]
        public void HasValue_輸入字符_應為True()
        {
            //arrange (準備)
            var value = "A";

            //act (執行)
            var actual = value.HasValue();

            //assert (驗證)
            actual.Should().BeTrue();
        }

        [TestMethod]
        [Owner("Nick")]
        [TestCategory("StringExtension")]
        [TestProperty("StringExtension", "BehindSubstring")]
        public void BehindSubstring_輸入空值_應發生拋出ArgumentNullException()
        {
            //arrange (準備)
            var value = (string)null;

            //act (執行)
            Action actual = () => value.BehindSubstring(3);

            //assert (驗證)
            actual.Should().Throw<ArgumentNullException>();
        }
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("StringExtension")]
        [TestProperty("StringExtension", "BehindSubstring")]
        public void BehindSubstring_輸入空字串_應發生拋出ArgumentNullException()
        {
            //arrange (準備)
            var value = string.Empty;

            //act (執行)
            Action actual = () => value.BehindSubstring(3);

            //assert (驗證)
            actual.Should().Throw<ArgumentNullException>();
        }
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("StringExtension")]
        [TestProperty("StringExtension", "BehindSubstring")]
        public void BehindSubstring_輸入空白_應發生拋出ArgumentNullException()
        {
            //arrange (準備)
            var value = " ";

            //act (執行)
            Action actual = () => value.BehindSubstring(3);

            //assert (驗證)
            actual.Should().Throw<ArgumentNullException>();
        }
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("StringExtension")]
        [TestProperty("StringExtension", "BehindSubstring")]
        public void BehindSubstring_輸入空白字符_應發生拋出ArgumentNullException()
        {
            //arrange (準備)
            var value = "/t";

            //act (執行)
            Action actual = () => value.BehindSubstring(3);

            //assert (驗證)
            actual.Should().Throw<ArgumentOutOfRangeException>();
        }
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("StringExtension")]
        [TestProperty("StringExtension", "BehindSubstring")]
        public void BehindSubstring_輸入大於字串數字_應拋出ArgumentOutOfRangeException()
        {
            //arrange (準備)
            var value = "A";

            //act (執行)
            Action actual = () => value.BehindSubstring(3);

            //assert (驗證)
            actual.Should().Throw<ArgumentOutOfRangeException>();
        }
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("StringExtension")]
        [TestProperty("StringExtension", "BehindSubstring")]
        public void BehindSubstring_輸入字串ABCDE_擷取字串數字3_應為CDE()
        {
            //arrange (準備)
            var value = "ABCDE";

            //act (執行)
            var actual = value.BehindSubstring(3);

            //assert (驗證)
            actual.Should().Be("CDE");
        }
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("StringExtension")]
        [TestProperty("StringExtension", "BehindSubstring")]
        public void BehindSubstring_輸入字串5個空白_擷取字串數字3_應拋出ArgumentNullException()
        {
            //arrange (準備)
            var value = "     ";

            //act (執行)
            Action actual = () => value.BehindSubstring(3);

            //assert (驗證)
            actual.Should().Throw<ArgumentNullException>();
        }
        [TestMethod]
        [Owner("Nick")]
        [TestCategory("StringExtension")]
        [TestProperty("StringExtension", "BehindSubstring")]
        public void BehindSubstring_輸入字串CDE_擷取字串數字3_應為CDE()
        {
            //arrange (準備)
            var value = "CDE";

            //act (執行)
            var actual = value.BehindSubstring(3);

            //assert (驗證)
            actual.Should().Be("CDE");
        }
    }
}