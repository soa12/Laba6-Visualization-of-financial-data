using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataConversion;
using DomainModel;

namespace DataConversionTest
{
    [TestClass]
    public class ConversionFromCSVTest
    {
        [TestMethod]
        public void TestMethodToObject()
        {
            string path = @"D:\Новая папка\Учеба\4 курс\Проектирование ИС и ИТ\Лаба 6\Laba6\EURRUB_171120_171120.csv";
            string path1 = @"D:\Новая папка\Учеба\4 курс\Проектирование ИС и ИТ\Лаба 6\Laba6\EURRUB_171120_171120(1).csv";
            ConversionFromCSV testClass = new ConversionFromCSV(path1);
            List<CurrencyRate> forCheckList = testClass.ToObject();
            //CurrencyRate forCheckCurrencyRate = forCheckList.FirstOrDefault();

            Assert.IsNotNull(forCheckList);
        }
    }
}
