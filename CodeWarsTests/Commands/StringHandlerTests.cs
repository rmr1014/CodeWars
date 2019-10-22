using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars.Commands.Tests
{
    [TestClass]
    public class StringHandlerTests
    {
        #region GetVowelCount

        [TestMethod]
        public void GetVowelCount_StringWithOneVowel_ReturnsZero()
        {
            // Arrange
            var stringHandler = new StringHandler();
            var str = "???";

            // Act
            var result = stringHandler.GetVowelCount(str);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void GetVowelCount_StringWithOneVowel_ReturnsOne()
        {
            // Arrange
            var stringHandler = new StringHandler();
            var str = "Bad";

            // Act
            var result = stringHandler.GetVowelCount(str);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetVowelCount_StringWithAllVowels_ReturnsFive()
        {
            // Arrange
            var stringHandler = new StringHandler();
            var str = "aeiou";
            // Act
            var result = stringHandler.GetVowelCount(str);

            // Assert
            Assert.AreEqual(5, result);
        }

        #endregion
    }
}