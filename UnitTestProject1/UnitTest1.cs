using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaintForm;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckTextValidation() //Makes sure an exception is thrown if text is entered, instead of a number, into a text box.
        {
            //arrange
            string toCheck = "Fish"; 
            //act
            bool isDec = Functions.CheckNum(toCheck);  //Throws an exception due to toCheck not being a number.
            //assert
            Assert.AreEqual(isDec, false); //If an exception is thrown, isDec is false.
        }

        [TestMethod]
        public void CheckSymbolValidation() //Makes sure an exception is thrown if a symbol is entered, instead of a number, into a text box.
        {
            //arrange
            string toCheck = "£";
            //act
            bool isDec = Functions.CheckNum(toCheck);  //Throws an exception due to toCheck not being a number.
            //assert
            Assert.AreEqual(isDec, false); //If an exception is thrown, isDec is false.
        }

        [TestMethod]
        public void CheckOverflowValidation() //Makes sure an exception is thrown if a number larger than allowed is entered into a text box
        {
            //arrange
            string toCheck = "1000000000000000000000000000000"; 
            //act
            bool isDec = Functions.CheckNum(toCheck); //Throws an exception due to toCheck being larger than the maximum magnitude allowed.
            //assert
            Assert.AreEqual(isDec, false); //If an exception is thrown, isDec is false.
        }

        [TestMethod]
        public void CheckPositiveValidation() //Makes sure an exception is thrown if a negative number is entered into a text box.
        {
            //arrange
            string toCheck = "-2.5";
            //act
            bool isDec = Functions.CheckNum(toCheck); //Generates an error message due to toCheck being negative (you cannot have negative dimensions etc.).
            //assert
            Assert.AreEqual(isDec, false); //If an exception is thrown, isDec is false.
        }

        [TestMethod]
        public void CheckCompositeValidation() //Makes sure an exception is thrown if a string containing numbers as well as other characters is entered.
        {
            //arrange
            string toCheck = "30a12";
            //act
            bool isDec = Functions.CheckNum(toCheck); //Generates an error message due to toCheck containing a character that isn't a digit.
            //assert
            Assert.AreEqual(isDec, false); //If an exception is thrown, isDec is false.
        }

        [TestMethod]
        public void CheckSuccessValidation() //Makes sure an exception is not thrown if a positive number below the maximum value is entered is entered.
        {
            //arrange
            string toCheck = "12.5";
            //act
            bool isDec = Functions.CheckNum(toCheck); //No exception should be thrown.
            //assert
            Assert.AreEqual(isDec, true); //If an exception is not thrown, isDec will be true.
        }
    }
}
