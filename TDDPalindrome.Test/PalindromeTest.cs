using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDPalindrome.Test
{
    [TestClass]
    public class PalindromeTest
    {
        private PalindromeFinder _palindromeFinder = null;

        [TestInitialize]
        public void InitTest()
        {
            _palindromeFinder = new PalindromeFinder();
        }
        #region Positive Cases
        [TestMethod]
        public void DoesPalindromeReturnTrue()
        {
            //Arrange
            string value = "rotator";
            bool expected = true;


            //Act
            bool actual = _palindromeFinder.IsPalindrome(value);

            //Asstert
            Assert.AreEqual(expected, actual);

        }
        #endregion Positive Cases

        #region Negative Cases
        [TestMethod]
        public void IsPalindromeReturnFalse()
        {
            //Arrange
            string value = "raggartangenter";
            bool expected = false;

            //Act
            bool actual = _palindromeFinder.IsPalindrome(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //[ExpectedException(typeof(ArgumentNullException))]
        public void IsPalindromeThrowArgumentNullException()
        {
            //Arrange
            string value = null;

            try
            {
                bool actual = _palindromeFinder.IsPalindrome(value);

                //If no exception is thrown, then it fails.

                Assert.Fail("Expected ArgumentNullException");
            }
            catch (ArgumentNullException)
            {
                
                //This is what should happen. No fail.
            }
            catch
            {
                Assert.Fail("Expected ArgumentNullException");
            }
            //Act
            

        }
        [TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        public void IsPalindromeThrowArgumentException()
        {
            //Arrange
            string value = "a";

            try
            {      //If no exception is thrown, then it fails.

                bool actual = _palindromeFinder.IsPalindrome(value);

                Assert.Fail("Expected ArgumentNullException");
            }
            catch (ArgumentException)
            {

                //This is what should happen. No fail.
            }
            catch
            {
                Assert.Fail("Expected ArgumentNullException");
            }
            //Act
            

        }


        #endregion Negative Cases
    }
}
