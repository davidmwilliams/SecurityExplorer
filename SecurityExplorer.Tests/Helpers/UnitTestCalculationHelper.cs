using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecurityExplorer.Helpers;

namespace SecurityExplorer.Tests.Helpers
{
    [TestClass]
    public class UnitTestCalculationHelper
    {
        [TestMethod]
        public void TestMethodGetDecimalPointPosition_WithoutDecimal()
        {
            Assert.AreEqual(3, CalculationHelper.GetDecimalPointPosition(-999));
            Assert.AreEqual(1, CalculationHelper.GetDecimalPointPosition(9));
        }

        [TestMethod]
        public void TestMethodGetDecimalPointPosition_()
        {
            Assert.AreEqual(1, CalculationHelper.GetDecimalPointPosition(9.99));
            Assert.AreEqual(2, CalculationHelper.GetDecimalPointPosition(99.09));
        }

        [TestMethod]
        public void TestMethodGetDecimalPointPosition_IgnoreNegativeSign()
        {
            Assert.AreEqual(1, CalculationHelper.GetDecimalPointPosition(-9.99));
            Assert.AreEqual(2, CalculationHelper.GetDecimalPointPosition(-99.09));
        }

        [TestMethod]
        public void TestMethodGetDecimalPointPosition_WhenPowerTo10()
        {
            Assert.AreEqual(16, CalculationHelper.GetDecimalPointPosition(1125899906842620.1));
        }

        [TestMethod]
        public void TestMethodGetPowerForFileSize()
        {
            Assert.AreEqual(0, CalculationHelper.GetPowerForFileSize(1)); //Byte
            Assert.AreEqual(0, CalculationHelper.GetPowerForFileSize(2)); //Bytes

            Assert.AreEqual(0, CalculationHelper.GetPowerForFileSize(1023));
            Assert.AreEqual(1, CalculationHelper.GetPowerForFileSize(1024)); //Kilobyte

            Assert.AreEqual(1, CalculationHelper.GetPowerForFileSize(1048575));
            Assert.AreEqual(2, CalculationHelper.GetPowerForFileSize(1048576)); //Megabyte

            Assert.AreEqual(2, CalculationHelper.GetPowerForFileSize(1073741823));
            Assert.AreEqual(3, CalculationHelper.GetPowerForFileSize(1073741824)); //Gigabyte

            Assert.AreEqual(3, CalculationHelper.GetPowerForFileSize(1099511627775));
            Assert.AreEqual(4, CalculationHelper.GetPowerForFileSize(1099511627776)); //Terabyte

            Assert.AreEqual(4, CalculationHelper.GetPowerForFileSize(1125899906842619));

            //TODO problem with rounding. If need to have more than TB need more precision.
            //Assert.AreEqual(5, CalculationHelper.GetPowerForFileSize(1125899906842620)); //Petabyte

            //Assert.AreEqual(5, CalculationHelper.GetPowerForFileSize(1152921504606849000));
            //Assert.AreEqual(6, CalculationHelper.GetPowerForFileSize(1152921504606850000)); //Etabyte
        }

        [TestMethod]
        public void TestMethodGetFormatterFileSize()
        {
            Assert.AreEqual("1 B", CalculationHelper.GetFormatterFileSize(1)); //Byte
            Assert.AreEqual("2 B", CalculationHelper.GetFormatterFileSize(2)); //Bytes

            Assert.AreEqual("1023 B", CalculationHelper.GetFormatterFileSize(1023));
            Assert.AreEqual("1 KB", CalculationHelper.GetFormatterFileSize(1024)); //Kilobyte

            Assert.AreEqual("1024 KB", CalculationHelper.GetFormatterFileSize(1048575));
            Assert.AreEqual("1 MB", CalculationHelper.GetFormatterFileSize(1048576)); //Megabyte

            Assert.AreEqual("1024 MB", CalculationHelper.GetFormatterFileSize(1073741823));
            Assert.AreEqual("1 GB", CalculationHelper.GetFormatterFileSize(1073741824)); //Gigabyte

            Assert.AreEqual("1024 GB", CalculationHelper.GetFormatterFileSize(1099511627775));
            Assert.AreEqual("1 TB", CalculationHelper.GetFormatterFileSize(1099511627776)); //Terabyte

            Assert.AreEqual("1024 TB", CalculationHelper.GetFormatterFileSize(1125899906842619));
        }
    }
}