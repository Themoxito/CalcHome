using CalcHome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows;

namespace calcmainmenutest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            Window window = new Window();
            // Act
            window.Show(); // открываем окно
            window.Close(); // закрываем окно
            // Assert
            Assert.IsFalse(window.IsVisible); // проверяем, что окно больше не отображается



        }
    }
}
