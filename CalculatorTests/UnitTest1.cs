using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorClass;

namespace CalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var obj = new Class1();

            //Act
            var result = obj.operation(1, '+', 1);

            //Assert
            Assert.AreEqual(result, 2);

        }//addition

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var obj = new Class1();

            //Act
            var result = obj.operation(10, '-', 5);

            //Assert
            Assert.AreEqual(result, 5);

        }//subtraction

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            var obj = new Class1();

            //Act
            var result = obj.operation(10, '*', 5);

            //Assert
            Assert.AreEqual(result, 50);
            
        }//subtraction

        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            var obj = new Class1();

            //Act
            var result = obj.operation(10, '/', 5);

            //Assert
            Assert.AreEqual(result, 2);

        }//subtraction


    }
}
