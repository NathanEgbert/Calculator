using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorClass;

namespace CalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Addition()
        {
            //Arrange
            var obj = new Class1();

            //Act
            var result = obj.operation(1, '+', 1);

            //Assert
            Assert.AreEqual(result, 2);

        }//addition

        [TestMethod]
        public void Subtraction()
        {
            //Arrange
            var obj = new Class1();

            //Act
            var result = obj.operation(10, '-', 5);

            //Assert
            Assert.AreEqual(result, 5);

        }

        [TestMethod]
        public void Multiplication()
        {
            //Arrange
            var obj = new Class1();

            //Act
            var result = obj.operation(10, '*', 5);

            //Assert
            Assert.AreEqual(result, 50);
            
        }

        [TestMethod]
        public void Division()
        {
            //Arrange
            var obj = new Class1();

            //Act
            var result = obj.operation(10, '/', 5);

            //Assert
            Assert.AreEqual(result, 2);

        }


    }
}
